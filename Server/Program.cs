using System.Net;

namespace Server
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Title = "TCP Server";
            TCP_Server server = new TCP_Server(IPAddress.Loopback, 1000);

            server.Message += (message) => Console.WriteLine(message);
            server.StartAsync();


            string command;
            while (true)
            {
                command = Console.ReadLine();
                if (command == "exit")
                {
                    server.Stop();
                    break;
                }
            }
        }
    }
}
