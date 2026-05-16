using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    public class TCP_ClientConnection
    {
        static int idCounter = 0;
        public int Id { get; private set; }

        TcpClient client;

        public event Action<TCP_ClientConnection, string> IncomingMessage;
        public event Action<TCP_ClientConnection> DisconnectMessage;

        public TCP_ClientConnection(TcpClient client)
        {
            Id = idCounter++;
            this.client = client;
        }

        public Task WorkAsync() => Task.Run(() => Work());

        public void Work()
        {
            if (client == null || !client.Connected)
                return;

            NetworkStream stream = client.GetStream();

            
        }
    }
}

