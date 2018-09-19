using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace SimpleWebScraper
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var client = new WebClient())
            {
                var googleMainPage = client.DownloadString("https://www.google.com");
                Console.WriteLine(googleMainPage);
            }
        }
    }
}