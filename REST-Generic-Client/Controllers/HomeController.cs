using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using REST_Generic_Client.Client;
using REST_Generic_Client.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace REST_Generic_Client.Controllers
{
    public class HomeController : Controller
    {

        private readonly IBaseClient<ClientMockModel> _client;

        public HomeController(IBaseClient<ClientMockModel> client)
        {
            _client = client;
        }



        public IActionResult Index()
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
