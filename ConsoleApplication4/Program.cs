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

namespace ConsoleApplication4
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


        public static void ThreadProc(Object stateInfo) 
        {
            //bool accept = false;
            //Client_connect socket = (Client_connect)stateInfo;
            OpenGL GL = (OpenGL)stateInfo;
            Client_connect socket = new Client_connect();
            Socket my_sock = socket.Connection();
            GL.ToClient(my_sock);
            //while (!accept)
            //    Console.WriteLine(GL.mx);
            Console.ReadKey();
        }
    }
}
