using System;
using UDP;

namespace UdpManager
{
    class Program
    {
        static void Main(string[] args)
        {
            UDPSocket s = new UDPSocket();
            s.Server("127.0.0.1", 9044);

            UDPSocket c = new UDPSocket();
            c.Client("127.0.0.1", 9044);
            c.Send("0X800");

            Console.ReadKey();
        }
    }
}
