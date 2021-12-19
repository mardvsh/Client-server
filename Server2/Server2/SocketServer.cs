using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Threading;
using System.Net;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Security;
using System.IO;
using System.ComponentModel;
using System.Globalization;

namespace Server2
{
    class SocketServer
    {
        [DllImport("user32.dll", SetLastError = true)]
        public static extern ushort GetKeyboardLayout([In] int idThread);
        [DllImport("user32.dll", SetLastError = true)]
        public static extern int GetWindowThreadProcessId([In] IntPtr hWnd, [Out, Optional] IntPtr lpdwProcessId);
        [DllImport("user32.dll", SetLastError = true)]
        public static extern IntPtr GetForegroundWindow();
        static ushort GetKeyboardLayout()
        {
            return (ushort)GetKeyboardLayout(GetWindowThreadProcessId(GetForegroundWindow(),
                                                                      IntPtr.Zero));
        }
        public Socket server;
        public Socket client;
        private IPEndPoint ip;
        private List<Thread> thread_list;
        private int max_conn;
        public List<string> messageSend = new List<string>();
        public List<string> ClientList = new List<string>();
        public SocketServer(string ip, Int32 port)
        {
            this.max_conn = 2;
            this.thread_list = new List<Thread>();
            this.ip = new IPEndPoint(IPAddress.Any, port);
            this.server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            this.server.Bind(this.ip);
            this.server.Listen(this.max_conn);
        }

        public void Start()
        {
            for (int i = 0; i < this.max_conn; i++)
            {
                Thread th = new Thread(Listening);
                th.Start();
                thread_list.Add(th);
            }
        }

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

        private void Listening()
        {
            while (true)
            {
                try
                {
                    using (client = this.server.Accept())
                    {
                        this.ClientList.Add(client.RemoteEndPoint.ToString());
                        if (client.Connected)
                        {

                            List<string> message = new List<string>();
                            string name = Environment.MachineName;
                            string userName = Environment.UserName;
                            string vers0 = "", vers1 = "", ci0N = "", ci1N = "";

                            var version = new OSVersionInfo();
                            version.dwOSVersionInfoSize = Marshal.SizeOf(version);
                            Kernel.GetVersionEx(version);

                            if (Marshal.GetLastWin32Error() != 0)
                                Console.WriteLine(Marshal.GetLastWin32Error());
                            uint ver = version.dwBuildNumber;
                            if (ver == 9200) vers0 = "Windows 8";
                            else if (ver == 9600) vers0 = "Windows 8.1";
                            else if (ver == 10240) vers0 = "Windows 10";
                            else if (ver == 7600) vers0 = "Windows 7";
                            else if (ver == 6000) vers0 = "Windows Vista";
                            else if (ver == 2600) vers0 = "Windows XP";
                            else if (ver == 2195) vers0 = "Windows 2000";
                            else vers0 = "Windows 11";
                            int id = GetKeyboardLayout();
                            CultureInfo ci0 = CultureInfo.GetCultureInfo(id);
                            ci0N = ci0.Name;

                            if (vers0 != vers1 || ci0N != ci1N)
                            {
                                vers1 = vers0; ;
                                ci1N = ci0N;
                                message.Add("Текущая расскладка (код): " + ci0N + " (" + id + ")" + "; Версия операционной системы: " + vers0);
                                message.Add("[end]");
                                SendAll(client, message);
                            }
                        }
                    }
                }
                catch { }

            }
        }
        public void SendAll(Socket handler, List<string> message)
        {
            for (int i = 0; i < message.Count;)
            {
                Send(message[i], handler);
                message.RemoveAt(i);
                Thread.Sleep(5);
            }
        }
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

