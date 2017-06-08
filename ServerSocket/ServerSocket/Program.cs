using System;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Text.RegularExpressions;
namespace ServerSocket
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Server server = new Server(2222);//обьект класса сервер
            server.ListenSocket();//слушаем клиентов
        }
        
    }
}