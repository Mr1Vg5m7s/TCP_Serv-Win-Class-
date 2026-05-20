using System;
using System.Net;
using System.Net.Sockets;

namespace Server
{

    internal class TCP_Server
    {

        TcpListener listener;

        List<TCP_ClientConnection> clients = new List<TCP_ClientConnection>();

        public event Action<string>? Message;

        public TCP_Server(IPAddress ipaddress, int port)
        {
            listener = new TcpListener(ipaddress, port);
        }

        public void StartAsync() => Task.Run(() => Start());

        public void Start()
        {
            try
            {
                Message?.Invoke($"Starting TCP Server on {listener.LocalEndpoint}");
                listener.Start();
                Message?.Invoke("TCP Server started. Waiting for clients...");
                while (true)
                {
                    TcpClient client = listener.AcceptTcpClient();
                    TCP_ClientConnection connection = new TCP_ClientConnection(client);
                    connection.IncomingMessage += (conn, message) =>
                    {
                        Message?.Invoke($"Received from Client {conn.Id}: {message}");
                        // Echo the message back to the client
                    };
                    connection.DisconnectMessage += (conn) =>
                    {
                        Message?.Invoke($"Client {conn.Id} disconnected.");
                        clients.Remove(conn);
                    };
                    clients.Add(connection);
                    Message?.Invoke($"Client {connection.Id} connected.");
                    connection.WorkAsync();
                }
            }
            catch (Exception ex)
            {
                Message?.Invoke($"Error starting TCP Server: {ex.Message}");
                return;
            }
        }

        public void Stop()
        {
            listener.Stop();
        }
    }
}