using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;


namespace Client
{
    internal class UserConnection
    {
        TcpClient Client;
        IPAddress address;
        int port;
        string name;
    }
}
