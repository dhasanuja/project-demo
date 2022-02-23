using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace git.Controllers
{
    public class DemoController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
