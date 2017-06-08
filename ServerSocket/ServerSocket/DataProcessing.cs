using System;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
namespace ServerSocket
{
    public static class DataProcessing
    {
        public static string DoReplyEnigma(string InputData) // отправляем такой ответ на клиент, если было запрошено угадать сдвиг
        {
            List<double> freqs = new List<double>(); // частоты
            foreach (var str in Frequinces(InputData).Split('|'))
            {
                double fr = Convert.ToDouble(str);
                freqs.Add(fr);
            }
            int tempIndex = freqs.IndexOf(freqs.Max());//максимальная частота
            int charE = (int)'e';// по результам експеримента буква "е" в англ. алфавите встречается чаще всего в текстах
            int charTempIndex = 97 + tempIndex;//буква с максимальной частотой 
            return Math.Abs(charTempIndex - charE).ToString(); //шаг - это модуль разницы символа с максимальной частотой в нашем тексте с частотой буквы "е"
        }
        public static string DoReplyCheaper(string InputData)
        {
            Regex regexLowRegister = new Regex("[a-z]");//принимать будем только буквы англ. алфавита малые
            Regex regexUpRegister = new Regex("[A-Z]");//... и большие
            int symbolLowZ = (int)'z';
            int symbolLowA = (int)'a';
            int symbolUpZ = (int)'Z';
            int symbolUpA = (int)'A';
            int currentSymbol = 0;
            string returndata = null;
            string[] dataBlocks = InputData.Split('/');
            int Rotn = Convert.ToInt32(dataBlocks[1]);
            char convertedChar = ' ';
            foreach (char ch in dataBlocks[0])
            {
                currentSymbol = (int)ch;
                if (regexLowRegister.IsMatch(ch.ToString()))//если малая буква
                {
                    if (dataBlocks[2] == "en")//если расшифровка
                    {
                        convertedChar = Encrypt(currentSymbol, Rotn, symbolLowZ, symbolLowA);//то расшифровуем
                    }
                    else
                    {
                        convertedChar = Decrypt(currentSymbol, Rotn, symbolLowZ, symbolLowA);//иначе зашифровуем
                    }
                    returndata += convertedChar.ToString();
                }
                if (regexUpRegister.IsMatch(ch.ToString()))//если болшая буква
                {
                    if (dataBlocks[2] == "en")//если расшифровка
                    {
                        convertedChar = Encrypt(currentSymbol, Rotn, symbolUpZ, symbolUpA);//то расшифровуем
                    }
                    else
                    {
                        convertedChar = Decrypt(currentSymbol, Rotn, symbolUpZ, symbolUpA);//иначе зашифровуем
                    }
                    returndata += convertedChar.ToString();
                }
                if (!regexLowRegister.IsMatch(ch.ToString()) && !regexUpRegister.IsMatch(ch.ToString()))
                    returndata += ch.ToString();
            }
            return returndata + "/" + Frequinces(dataBlocks[0]);// ответ как зашифров/расшифров. текст + частоты
        }
        private static char Encrypt(int currentSymbol, int Rotn, int symbolZ, int symbolA) // к символу прибаляем шаг; если превышает - то идем по алфавиту с начала
        {
            char convertedChar = ' ';
            if ((currentSymbol + Rotn) <= symbolZ)
                convertedChar = (char)(currentSymbol + Rotn);
            else
                convertedChar = (char)((currentSymbol + Rotn) - symbolZ + symbolA - 1);
            return convertedChar;
        }

        private static char Decrypt(int currentSymbol, int Rotn, int symbolZ, int symbolA)// от символа отнимаем шаг; если меньше чем начало алфавита - то идем по алфавиту с конца
        {
            char convertedChar = ' ';
            if ((currentSymbol - Rotn) >= symbolA)
                convertedChar = (char)(currentSymbol - Rotn);
            else
                convertedChar = (char)((currentSymbol - Rotn) - symbolA + symbolZ + 1);
            return convertedChar;
        }
        static string chars = string.Empty;
        private static string Frequinces(string InputData)//ищем частоты (колчиество каждой буквы деленное на количество букв!!! в текте)
        {
            string LowerCharData = InputData.ToLower();
            string Alphabet = string.Empty;
            string answer = string.Empty;
            int A = (int)'a';
            int Z = (int)'z';
            for (int i = A; i < Z + 1; i++)
            {
                Alphabet += ((char)i).ToString();
            }
            double temp = 0;
            for (int i = 0; i < Alphabet.Length; i++)
            {
                temp = 0;
                for (int j = 0; j < LowerCharData.Length; j++)
                {
                    if (Alphabet[i] == LowerCharData[j])
                    {
                        temp++;
                    }
                }
                answer += (temp / CountChars(LowerCharData)).ToString() + "|";
            }
            answer = answer.Remove(answer.Length - 1);
            chars = CountChars(LowerCharData).ToString();
            return answer;
        }
        private static double CountChars(string InputData)//подсчет количества букв!!! в тексте
        {
            double count = 0;
            Regex regex = new Regex("[a-z]");
            foreach (char ch in InputData)
            {
                if (regex.IsMatch(ch.ToString()))
                {
                    count++;
                }
            }
            return count;
        }
    }
}
