using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace ConsoleApp_Lab1
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var httpClient = new HttpClient()
            {
                BaseAddress = new Uri("")
            };

            var jsonResponse = await httpClient.GetStringAsync("");

            Console.WriteLine(jsonResponse);
            Console.WriteLine("====> Hello World!");
        }
    }
}
