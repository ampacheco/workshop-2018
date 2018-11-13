using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using src.Models;


using Pivotal.Extensions.Configuration.ConfigServer; 
using Microsoft.Extensions.Options;

namespace src.Controllers
{
    public class HomeController : Controller
    {

        public HomeController(IOptions<ConfigurationData> appConfigurationData)
        {
            AppConfigurarionData = appConfigurationData.Value; 
        }

        private ConfigurationData AppConfigurarionData {get; set; }


        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }
        public IActionResult ConfigServer()
        {
            ViewData["Message"] = "Your Config Server Page";

            // Get Data from ConfigurationData

            ViewData["AuthenticationProvider"] = AppConfigurarionData.AuthenticationProvider;
            ViewData["ServiceDiscoveryUri"] = AppConfigurarionData.ServiceDiscoveryUri;
            ViewData["DotNetConfSantiagoEdition"] = AppConfigurarionData.DotNetConfSantiagoEdition;
            
            return View();
        }
        
        public IActionResult EurekaServer() 
        {
            return View();
        }
        
        public IActionResult HystrixDashboard() 
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
