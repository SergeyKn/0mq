using NetMQ;
using NetMQ.Sockets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequestResponce
{
    public class Server
    {
        public void Run()
        {
            Task.Run(() =>
            {
                using (var server = new ResponseSocket())
                {
                    server.Bind("tcp://*:5556");
                    while (true)
                    {
                        string msg = server.ReceiveFrameString();
                        Console.WriteLine("From Client: {0}", msg);
                        server.SendFrame("World");
                    }
                }
            });
        }
    }
}
