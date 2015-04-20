using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using Tao.OpenGl;
using Tao.FreeGlut;
using Tao.Platform.Windows;
//using System.Net;
//using System.Net.Sockets;

namespace TestClientCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //bool accept = false;
            
            OpenGL GL = new OpenGL();
            ThreadPool.QueueUserWorkItem(new WaitCallback(ThreadProc), GL);
            GL.Opengl();
            //while (!accept)
            //    Console.WriteLine(GL.mx);
            Console.ReadKey();
        }


        static void ThreadProc(Object stateInfo)
        {
            OpenGL GL = (OpenGL)stateInfo;
            Server_connect socket = new Server_connect();
            Socket my_sock = socket.Connection();
            GL.ToServer(my_sock);
            Console.ReadKey();
        }
    }
}
