using System;
namespace WebApiClient
{
    class Program
    {
        static async Task Main(string[]args)
        {
            Console.WriteLine("press any key...");
            Console.ReadLine();

            using (System.Net.Http.HttpClient client = new HttpClient())
            {
                var response = await client.GetAsync("http://localhost:5109/Values");
                response.EnsureSuccessStatusCode();
                if (response.IsSuccessStatusCode)
                {
                    string message = await response.Content.ReadAsStringAsync();
                    Console.WriteLine(message);
                }
                else
                {
                    Console.WriteLine($"response error code:{response.StatusCode}");
                }
            }


            Console.ReadLine();
            Console.WriteLine("Hello, World!");
        }
    }
}


