using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Threading;
using System.Net;
using System.Diagnostics;


namespace Client
{
    class SocketClient
    {
        
        public Socket client;
        private IPEndPoint ip;
        public List<string> ReceiveMessage = new List<string>(); //список для полученных сообщений
        public SocketClient(string ipAddress, Int32 port)
        {
            this.ip = new IPEndPoint(IPAddress.Parse(ipAddress), port);
            this.client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        }

        public bool Connect()
        {
            try
            {
                this.client.Connect(this.ip); //подключение по введенному ip
                return true;
            }
            catch
            {
                return false;
            }
        }
        public void Receive()
        {
            string message = String.Empty; //задаем пустую строку для сообщения
            byte[] GetBytes = new byte[1024]; //сюда записываем переданные байты
            try
            {
                int b = client.Receive(GetBytes); 
                message = Encoding.UTF8.GetString(GetBytes, 0, b); //преобразуем полученые байты в строку
                if (message != "")
                    this.ReceiveMessage.Add(message);
            }
            catch
            { }
        }
        public void Disconnect()
        {
            if (client.Connected)
            this.client.Disconnect(false);
        }
    }
}

