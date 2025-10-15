using System;
using System.Net.Http;
using System.Threading.Tasks;
namespace HomeWork
{
    class Program
    {
        static async Task Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("=== Downloading HTML's page ===");
            Console.Write("Write http addres (for example , https://example.com): ");  
            string? url = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(url))
            {
                Console.WriteLine("None adress. Proggram is closed.");
                return;
            }

            try
            {
                using HttpClient client = new HttpClient();

                Console.WriteLine("\nDownload page...");
                string html = await client.GetStringAsync(url);

                Console.WriteLine("\nPage is dоwnloaded correctly!\n");
                Console.WriteLine("First of 100 HTML's rows:\n");
                Console.WriteLine(html.Length > 100 ? html.Substring(0, 500) + "..." : html);
            }
            catch (Exception ex)
            {
                Console.WriteLine($" {ex.Message}");
            }
        }
    }
}