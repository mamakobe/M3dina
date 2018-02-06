using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using M3dina.Models;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using M3dina.Helpers;

namespace M3dina.Controllers
{
    public class HomeController : Controller
    {
        
        public IActionResult Index()
        {


            return View();
        }


       
        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
