
using System;
using WSserver.Models;
using WebSocketSharp;
using WebSocketSharp.Server;

namespace WSserver;

    public class Program
    {
        public class Echo : WebSocketBehavior
        {
            protected override void OnMessage(MessageEventArgs e)
            {
                Console.WriteLine("Received Message from Echo client: "+ e.Data);
                Send(e.Data);
            }

        }

        public class EchoAll : WebSocketBehavior
        {
            protected override void OnMessage (MessageEventArgs e)
            {
                Console.WriteLine("Received Message from Echo client:" + e.Data);
                Sessions.Broadcast(e.Data);
            }
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var posts = new List<Post>();

            WebSocketServer ws = new WebSocketServer("ws://127.0.0.1:5501");

            ws.AddWebSocketService<Echo>("/Echo");
            ws.AddWebSocketService<EchoAll>("/EchoAll");

            ws.Start();

            Console.WriteLine("Ws server started at ws://127.0.0.1:5501");

            Console.ReadKey();
            ws.Stop();
        }
    }
