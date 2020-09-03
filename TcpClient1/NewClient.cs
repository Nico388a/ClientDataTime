using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace TcpClient1
{
    class NewClient
    {
        public void Start()
        {
            TcpClient socket = new TcpClient();
            socket.Connect(IPAddress.Loopback, 3003);

            NetworkStream ns = socket.GetStream();
            StreamReader sr = new StreamReader(ns);
            StreamWriter sw = new StreamWriter(ns);
            sw.WriteLine("15:23&2005-02-25");


            sw.Flush();

            string strRetur = sr.ReadLine();

            Console.WriteLine(strRetur);
        }
    }
}
