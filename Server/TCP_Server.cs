using System;
using System.Net;
using System.Net.Sockets;

namespace Server
{

    internal class TCP_Server
    {
        TcpListener tcpListener;
        public TCP_Server(IPAddress any, int v)
        {
            
        }

        public event Action<string>? Message;

        public void StartAsync()
        {
            throw new NotImplementedException();
        }

        public void Start()
        {
            //Message?.Invoke($"Starting TCP Server...{listener.LocalEndPoint}");
            //listener.Start();
            Message?.Invoke("TCP Server started.Waiting...");
        }

        public void Stop()
        {
            throw new NotImplementedException();
        }
    }
}