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
            byte[] buffer = new byte[1024];
            buffer = Encoding.UTF8.GetBytes($"Welcome to the TCP Server! Your ID is {Id}");
            stream.Write(buffer, 0, buffer.Length);

            int bytesRead;

            try
            {
                while (true)
                {
                    StringBuilder? builder = new StringBuilder();
                    do
                    {
                        bytesRead = stream.Read(buffer, 0, buffer.Length);
                        builder.Append(Encoding.UTF8.GetString(buffer, 0, bytesRead));
                    }
                    while (stream.DataAvailable);

                    if (bytesRead == 0)
                    {
                        //DisconnectMessage?.Invoke(this);
                        break;
                    }

                    IncomingMessage?.Invoke(this, builder.ToString());

                    builder = null;
                }
            }
            catch (Exception)
            {
                //throw;
            }

            client.Close();

        }
    }
}

