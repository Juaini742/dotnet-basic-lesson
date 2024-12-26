using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _10_async_await
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            System.Console.WriteLine("Start process");
            var data = await DownloadAsync();
            System.Console.WriteLine($"Result: {data}");

            var task1 = DownloadAsyncServer("Server 1");
            var task2 = DownloadAsyncServer("Server 2");
            var task3 = DownloadAsyncServer("Server 3");

            var results = await Task.WhenAll(task1, task2, task3);
            foreach (var result in results)
            {
                Console.WriteLine(result);
            }
        }

        static async Task<string> DownloadAsync()
        {
            System.Console.WriteLine("Downloading...");

            await Task.Delay(3000); // 3 second
            System.Console.WriteLine("Downloading finish");
            return "Data Server...";
        }

        static async Task<string> DownloadAsyncServer(string server)
        {
            System.Console.WriteLine("Downloading....");

            await Task.Delay(3000);
            return $"Server: {server}";
        }
    }
}
