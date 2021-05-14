


using Microsoft.VisualBasic;
using Microsoft.Net;
using System.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {

                    //TAMBIEN QUIERO CREAR CONFLICTOS
                    webBuilder.UseStartup<Startup>();
                    webBuilder.UseStartup<Startup>();
                    webBuilder.UseStartup<Startup>();
                });
    }
}
