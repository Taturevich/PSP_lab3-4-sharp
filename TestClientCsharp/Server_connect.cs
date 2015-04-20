using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace TestClientCsharp
{
    class Server_connect
    {
        public Socket Connection()
        {
            //IPHostEntry ipHost = Dns.GetHostEntry(IPAddress.Parse("127.0.0.1"));//192.168.1.150
            IPAddress ipAddr = IPAddress.Parse("192.168.0.101")/*ipHost.AddressList[1]*/;
            IPEndPoint ipEndPoint = new IPEndPoint(ipAddr, 19945);

            Socket server = new Socket(ipAddr.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
            Console.WriteLine("C");
            server.Connect(ipEndPoint);
            //byte[] buf = new byte[10];
            //Console.Write("Vvod: ");
            //string s;
            //s = Console.ReadLine();

            //buf = Encoding.ASCII.GetBytes(s);
            //server.Send(buf);

            //int bytesRec = server.Receive(buf);
            //string s1 = Encoding.ASCII.GetString(buf, 0, bytesRec);

            //Console.WriteLine(s1);
            //Console.ReadKey();
            return server;
        }
    }
}
