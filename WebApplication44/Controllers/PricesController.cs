using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication44.Controllers
{
    public class PricesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
