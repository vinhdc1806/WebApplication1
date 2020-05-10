using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class NewController : Controller
    {
        public string chuoi() 
        {
            return ("hello");
        }
        public IActionResult Index()
        {
            return View();
        }
        public int so()
        {
            return new Random().Next(1000, 10000);
        }
    }
}