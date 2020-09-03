using System;

namespace TcpClient1
{
    class Program
    {
        static void Main(string[] args)
        {
            NewClient worker = new NewClient();
            worker.Start();
            Console.ReadLine();

        }
    }
}
