using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Client
{
    internal class UserConnection
    {
        TcpClient ?Client;
        IPAddress address;
        int port;
        string name;

        public string Name 
        {
            get => Name; 
            set
            {
                if (!Name.Equals(value))
                {
                    Name = value;
                }
            }
        }

        public bool Connected => Client != null && Client.Connected;

        public event Action<bool> ConnectedEstablished;
        public event Action<string> IncomingMessage;
        public event Action<bool> SendCompleted;

        public UserConnection(IPAddress address, int port, string name)
        {
            Client = new TcpClient();
            this.address = address;
            this.port = port;
            this.name = name;
        }

        public async Task ConnectAsync() => await Task.Run(Connect);

        public void Connect()
        {
            if(Connected)
                return;

            try
            {
                Client.Connect(address, port);
                ConnectedEstablished?.Invoke(true);
            }
            catch (Exception)
            {
                Client = null;
                ConnectedEstablished?.Invoke(false);
            }
        }

        public async Task SendMessageAsync(string message) => await Task.Run(() => SendMessage(message));
        
        public void Disconnect() 
        {
            try
            {
                if (Connected)
                {
                    SendMessage("exit");
                    Client!.Close();
                }
            }
            catch (Exception)
            {

            }
            finally
            {
                ConnectedEstablished?.Invoke(false);
                Client = null;
            }
        }

        public void SendMessage(string message)
        {
            if (!Connected)
                return;

            try
            {
                NetworkStream stream = Client!.GetStream();
                byte[] bytes = Encoding.UTF8.GetBytes(message);
                stream.Write(bytes, 0, bytes.Length);
                SendCompleted?.Invoke(true);
            }
            catch (Exception)
            {
                SendCompleted?.Invoke(false);
            }
            
            
        }
        public async Task ReadMessageAsync(string message) => await Task.Run(() => ReadMessage(message));

        public void ReadMessage(string message)
        {
            if(!Connected)
                return;


            NetworkStream stream = Client!.GetStream();
            int bytes;
            byte[] buffer = new byte[256];
            StringBuilder sb = new StringBuilder();

            do
            {
                bytes = stream.Read(buffer, 0, buffer.Length);
                sb.Append(Encoding.UTF8.GetString(buffer));

            }while (stream.DataAvailable);
            IncomingMessage?.Invoke(sb.ToString());

        }
    }
}
