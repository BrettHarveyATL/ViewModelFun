using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ViewModelFun.Models;

namespace ViewModelFun.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
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
        [HttpGet("users")]

        public IActionResult Users()
        {
            User newUser = new User()
            {
                FirstName = "Moose",
                LastName = "Anderson"
            };
            return View(newUser);
        }
        [HttpGet("names")]
        public IActionResult Names()
        {
            // to a View that has defined a model as @model string[]
            string[] names = new string[]
            {
            "Sally",
            "Billy",
            "Joey",
            "Moose"
            };
            return View(names);
        }
        [HttpGet("numbers")]
        public IActionResult Numbers()
        {
            // to a View that has defined a model as @model string[]
            int[] numbers = new int[]
            {1,2,3,10,43,4};
            return View(numbers);
        }
    }

}
