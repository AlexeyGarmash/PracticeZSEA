using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;

namespace ClientWpf
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        SendDataToServer DataToSend;
        public MainWindow()
        {
            InitializeComponent();
        }
        private string En_or_De//определям, какой радиобатн выбран
        {
            get
            {
                if (EncryptRadio.IsChecked == true)
                    return "en"; // будем шифровать
                else
                    return "de";// будем расшифровывать
            }
        }
        private void GO_Button_Click(object sender, RoutedEventArgs e) // нажата кнопка отвечающая за шифровку/расшифровку
        {
            ResultTextBox.Clear();// очищаем поле результата
            ChartCanvas.Children.Clear();// очищаем диаграмму частот
            if (UserDataTextBox.Text == string.Empty || ROTNTextBox.Text == string.Empty) // если что-то не введено то ничего не делаем и не допускаем
                return;

                string IP = string.Empty; // IP сервера
                int Port = 0;// порт
                string[] HostInfo = ReadFromFile("HostInfo.txt");//файл, в котором хранятся данные о расположении сервера
                IP = HostInfo[0];
                Port = Convert.ToInt32(HostInfo[1]);
                DataToSend = new SendDataToServer(Convert.ToInt32(ROTNTextBox.Text), UserDataTextBox.Text, En_or_De, Port, IP, false);
                DataToSend.SendData();//отправлем пакет
                ResultTextBox.Text = DataToSend.Answer.Split('/')[0];//принимаем ответ от сервера
                CreateChart chart = new CreateChart(ChartCanvas, DataToSend.Answer.Split('/')[1]);
                chart.DrowColumns();//рисуем диаграмму
            
        }
        private string[] ReadFromFile(string path)
        {
            return File.ReadAllLines(path);
        }

        private void ROTNTextBox_TextChanged(object sender, TextChangedEventArgs e) // запрещаем вводить сдиг ниже нуля и выше 26
        {
            int Converted = 0;
            if (Int32.TryParse(ROTNTextBox.Text, out Converted))
            {
                if (Converted > 26)
                {
                    ROTNTextBox.Clear();
                }
            }
            else
                ROTNTextBox.Clear();
        }

        private void Enigma_Button_Click(object sender, RoutedEventArgs e)// нажата кнопка отвечающая за нахождение (примерное) шага
        {
            ResultTextBox.Clear();
            ChartCanvas.Children.Clear();
            if (UserDataTextBox.Text == string.Empty)
                return;

            string IP = string.Empty;
            int Port = 0;
            string[] HostInfo = ReadFromFile("HostInfo.txt");
            IP = HostInfo[0];
            Port = Convert.ToInt32(HostInfo[1]);
            DataToSend = new SendDataToServer(0, UserDataTextBox.Text, En_or_De, Port, IP, true);
            DataToSend.SendData();
            MessageBox.Show(DataToSend.Answer, "ROT", MessageBoxButton.OK);
        }
    }
}
