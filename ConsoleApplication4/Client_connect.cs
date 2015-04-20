using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace ConsoleApplication4
{
    class Client_connect
    {
        


        //public int count = 0;
        public Socket Connection()
        {
            Socket sock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            //IPHostEntry ipHost = Dns.GetHostEntry("localhost");
            //IPAddress ipAddr = ipHost.AddressList[0];
            // IPAddress ipAddr = null;
            IPEndPoint ipEnd = new IPEndPoint(IPAddress.Any, 19945);
            //IPEndPoint ipEnd = new IPEndPoint(IPAddress.Any, 19945);

            //Socket sock = new Socket(ipAddr.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
            //Socket sock = new Socket(ipAddr.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
            sock.Bind(ipEnd);
            sock.Listen(10);

            Socket client;
            byte[] buf = new byte[10];
           

            Console.WriteLine("W");
            client = sock.Accept();
            Console.WriteLine("Client connected");

            //int bytesRec = client.Receive(buf);
            //string s = Encoding.ASCII.GetString(buf, 0, bytesRec);
            //Console.WriteLine(s);
            //buf = Encoding.ASCII.GetBytes(s);
            //client.Send(buf);

            return client;

        }
    }
}
