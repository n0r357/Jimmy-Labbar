using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GroupAssignment_L2.Filters;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GroupAssignment_L2.Controllers
{
    public class HomeController : Controller
    {
        // GET: /<controller>/
        //[NonAction]   Ej syndlig för http-anrop
        //[HttpGet]
        //[HttpPost]
        //[Route("test")]   Ändrar url
        //[Route("{Index}/test")]
        //[Route("{action}--{id}--{name}")]
        public IActionResult Index()
        {
            return View();
        }

        //[ActionName("Time")]
        //[RequireHttps]
        //[TestFilterAttribute]
        public IActionResult Time(int id, string name)
        {
            var time = DateTime.Now;
            ViewBag.time = time;
            return View();
        }
    }
}
