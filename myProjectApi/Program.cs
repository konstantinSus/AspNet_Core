using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using myProjectApi;

namespace myProjectApiêàçà
{
    public class Program
    {
        public static void Main(string[] args)
        {

        
  
            //var extent = new ExtentReports();
            //ExtentHtmlReporter htmlReporter = new ExtentHtmlReporter(@"C:\Users\pain-\OneDrive\Desktop\report.html");
            //extent.AttachReporter(htmlReporter);
            //htmlReporter.Start();
            //htmlReporter.Flush();

            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
