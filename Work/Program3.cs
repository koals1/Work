using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace UdpChat
{
    class Client
    {
        private readonly UdpClient client;
        private readonly IPEndPoint serverEndpoint;
        private readonly string username;

        public Client(string name, string host, int port)
        {
            username = name;
            serverEndpoint = new IPEndPoint(IPAddress.Parse(host), port);
            client = new UdpClient();
        }

        public async Task StartAsync()
        {
            await SendAsync(username);
            _ = ReceiveMessagesAsync();

            Console.WriteLine("Connected. Type messages below:");
            while (true)
            {
                string? line = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(line)) continue;
                await SendAsync(line);
            }
        }

        private async Task SendAsync(string text)
        {
            byte[] data = Encoding.UTF8.GetBytes(text);
            await client.SendAsync(data, data.Length, serverEndpoint);
        }

        private async Task ReceiveMessagesAsync()
        {
            while (true)
            {
                var msg = await client.ReceiveAsync();
                Console.WriteLine(Encoding.UTF8.GetString(msg.Buffer));
            }
        }

        static async Task Main()
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine() ?? "User";
            var c = new Client(name, "127.0.0.1", 8888);
            await c.StartAsync();
        }
    }
}
