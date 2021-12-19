using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Threading;
using System.Net;
using System.Runtime.InteropServices;
using System.Management;
using System.IO;
using System.Diagnostics;


namespace Server1
{
    class SocketServer
    {
        public string messageA = "";
        public int id0 = -1;
        public IntPtr hand0;
        public Socket server;
        private IPEndPoint ip;
        private List<Thread> thread_list;
        private int max_conn;
        public List<string> messageSend = new List<string>(); //для отправки сообщения
        public List<string> ClientList = new List<string>();
        public SocketServer(string ip, Int32 port)
        {
            this.max_conn = 10; //сколько клиентов могут подключаться к этому серверу
            this.thread_list = new List<Thread>();

            //процедура содания сервера чтобы он запустился и слушал подключения
            this.ip = new IPEndPoint(IPAddress.Any, port);
            this.server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            this.server.Bind(this.ip);
            this.server.Listen(this.max_conn);
        }
        string prpP = "";
        public void Start()
        {
            for (int i = 0; i < this.max_conn; i++)
            {
                Thread th = new Thread(Listening);
                th.Start();
                thread_list.Add(th);
            }
        }
        //закрытие подключений
        public void Dispose()
        {
            foreach (Thread th in thread_list)
            {
                th.Interrupt();
            }
            server.Close();
        }

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
        public class OSVersionInfo
        {
            public int dwOSVersionInfoSize;
            public uint dwMajorVersion;
            public uint dwMinorVersion;
            public uint dwBuildNumber;
            public uint dwPlatformId;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
            public String szCSDVersion;
            public ushort wServicePackMajor;
            public ushort wServicePackMinor;
            public ushort wSuiteMask;
            public byte wProductType;
            public byte wReserved;
        }

        class Kernel
        {
            [DllImport("kernel32.dll", SetLastError = true, CharSet = CharSet.Auto)]
            public static extern bool GetVersionEx([In, Out] OSVersionInfo info);
        }

        //слушаем клиента
        public void Listening()
        {
            while (true)
            {
                try
                {
                    using (Socket client = this.server.Accept())
                    {
                        this.ClientList.Add(client.RemoteEndPoint.ToString());
                        if (client.Connected)
                        {
                            //Process process; 
                            Process process = Process.GetCurrentProcess();
                            int prp;
                            int id;
                            IntPtr hand;
                            List<string> message = new List<string>(); //строка, куда добавлять будем инфу для передачи
                            while (client.Connected)
                            {
                                process.Refresh();
                                process = Process.GetCurrentProcess();
                                id = process.Id;
                                hand = process.Handle;
                                prp = process.BasePriority;
                                if (prp == 4) prpP = "Idle";
                                else if (prp == 6) prpP = "Below Normal";
                                else if (prp == 8) prpP = "Normal";
                                else if (prp == 10) prpP = "Above Normal";
                                else if (prp == 13) prpP = "High";
                                else if (prp == 24) prpP = "Real Time";
                                message.Add("Приоритет серверного процесса: " + prpP + "(" + prp + ")" + "; Иденификатор и дескриптор серверного процесса : " + id + "/" + hand);
                                message.Add("[end]"); //это обязательно, чтобы клиент понял шо все конец
                                if (messageA != message[0])//если полученное сообщение не равно отправленному заполняем и отправляем (2 доп задание)
                                {
                                    messageA = message[0];
                                    SendAll(client, message);//тут передаем
                                }
                                else
                                {
                                    messageA = message[0];
                                    message.Clear();
                                }
                        }
                    }
                    }
                }
                catch
                {
                }
            }
        }
        //передача
        public void SendAll(Socket handler, List<string> message)
        {
            for (int i = 0; i < message.Count;)
            {
                //передача по байтам
                Send(message[i], handler);
                message.RemoveAt(i);
                Thread.Sleep(500);
            }
        }
        //сенд который делит на байты и передает
        public void Send(string message, Socket handler)
        {
            byte[] tosend = Encoding.UTF8.GetBytes(message);
            try
            {
                handler.Send(tosend, 0, tosend.Length, SocketFlags.None);
            }
            catch
            {
            }
        }
    }
}
