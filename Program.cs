using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace ApiClient
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var client = new HttpClient();

            var responseBodyAsStream = await client.GetStreamAsync("https://official-joke-api.appspot.com/random_joke");

            var item = await JsonSerializer.DeserializeAsync<Item>(responseBodyAsStream);

            Console.Clear();
            Console.WriteLine($"{item.Setup}\n\n{item.Punchline}");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey(true).Key.ToString();
            Console.Clear();

        }
    }
}