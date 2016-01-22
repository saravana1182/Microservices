using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Microservices
{
    public class Program
    {
        public async void Main(string[] args)
        {
            var length = await Method1();
            Console.WriteLine(length);
            Console.WriteLine("ready");
            
            Console.ReadLine();
        }

        public async Task<int> Method1()
        {
            HttpClient client = new HttpClient();

            Task<string> getStringTask = client.GetStringAsync("http://google.com") ;


            string urlContents = await getStringTask;

            // The return statement specifies an integer result.
            // Any methods that are awaiting AccessTheWebAsync retrieve the length value.
            return urlContents.Length;

        }
    }
}
