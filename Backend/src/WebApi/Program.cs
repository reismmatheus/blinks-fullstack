using Microsoft.Owin.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApi
{
    class Program
    {
        static void Main(string[] args)
        {
            string url = "Http://localhost:5000/";

            using (WebApp.Start(url: url))
            {
                Console.WriteLine($"API online on {url}");
                System.Threading.Thread.Sleep(-1);
            }
        }
    }
}
