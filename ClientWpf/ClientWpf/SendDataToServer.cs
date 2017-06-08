using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
namespace ClientWpf
{
    class SendDataToServer
    {
        private int ROTN;//сдвиг
        private int Port;//порт
        private string Word;//текст на расшифровку/зашифровку
        private bool IsEnigma;// true - найти предпоагаемый сдвиг; false - зашифровать/расшифровать сообщение
        private string Crypt;//en = encrypt         de = decrypt
        private string IPAddres;
        private IPAddress ipAddr;
        private IPEndPoint ipEndPoint;
        private Socket sender;
        public SendDataToServer(int rotn, string word, string crypt, int port, string ip, bool enigma)
        {
            ROTN = rotn;
            Word = word;
            Crypt = crypt;
            Port = port;
            IPAddres = ip;
            IsEnigma = enigma;
        }
        public string Answer
        {
            get
            {
                return Encoding.UTF8.GetString(bytes, 0, bytesRec);//получаем ответ из байтов в строку
            }
        }
        public string IP
        {
            get
            {
                return IPAddres;
            }
        }
        public int PORT
        {
            get
            {
                return Port;
            }
        }
        public void SendData()
        {
            try
            {
                SendMessageFromSocket();//отсылаем на сервер
            }
            catch (Exception ex)
            {
                System.Windows.MessageBox.Show(ex.Message, "Error", System.Windows.MessageBoxButton.OK, System.Windows.MessageBoxImage.Error);
            }
            finally
            {
                Console.ReadLine();
            }
        }
        byte[] bytes;
        int bytesRec;
        private void SendMessageFromSocket()
        {
            // Буфер для входящих данных
            bytes = new byte[10000];
            // Соединяемся с удаленным устройством

            // Устанавливаем удаленную точку для сокета
            ipAddr = IPAddress.Parse(IPAddres);
            ipEndPoint = new IPEndPoint(ipAddr, Port);
            sender = new Socket(ipAddr.AddressFamily, SocketType.Stream, ProtocolType.Tcp);

            // Соединяем сокет с удаленной точкой
            sender.Connect(ipEndPoint);

            //Console.Write("Введите сообщение: ");
            string message = string.Empty;
            if (!IsEnigma)
                message = Word + "/" + ROTN.ToString() + "/" + Crypt;
            else
                message = Word;

            //Console.WriteLine("Сокет соединяется с {0} ", sender.RemoteEndPoint.ToString());
            byte[] msg = Encoding.UTF8.GetBytes(message);

            // Отправляем данные через сокет
            int bytesSent = sender.Send(msg);

            // Получаем ответ от сервера
            bytesRec = sender.Receive(bytes);

            // Освобождаем сокет
            sender.Shutdown(SocketShutdown.Both);
            sender.Close();
        }
    }
}
