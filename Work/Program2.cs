using System;
using System.Collections.Concurrent;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace UdpChat
{
    class Server
    {
        private readonly UdpClient socket;
        private readonly ConcurrentDictionary<IPEndPoint, string> users = new();

        public Server(int port)
        {
            socket = new UdpClient(port);
            Console.WriteLine($"Server is listening on port {port}");
        }

        public async Task RunAsync()
        {
            while (true)
            {
                var packet = await socket.ReceiveAsync();
                string msg = Encoding.UTF8.GetString(packet.Buffer);
                var sender = packet.RemoteEndPoint;

                if (!users.ContainsKey(sender))
                {
                    users[sender] = msg;
                    Console.WriteLine($"User joined: {msg} ({sender})");
                    continue;
                }

                string name = users[sender];
                string finalMsg = $"{name}: {msg}";
                Console.WriteLine(finalMsg);

                byte[] data = Encoding.UTF8.GetBytes(finalMsg);
                foreach (var u in users.Keys)
                    await socket.SendAsync(data, data.Length, u);
            }
        }

        static async Task Main()
        {
            var server = new Server(8888);
            await server.RunAsync();
        }
    }
}
