using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProductStoreWebApp.Models;

namespace ProductStoreWebApp.Controllers
{
    public class DashboardController : Controller
    {
        [HttpGet]
        public IActionResult Hello(){

            return View();
        }
    }
}