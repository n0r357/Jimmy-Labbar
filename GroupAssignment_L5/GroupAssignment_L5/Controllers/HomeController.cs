using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GroupAssignment_L5.Models;
using Microsoft.AspNetCore.Http;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GroupAssignment_L5.Controllers
{
    public class HomeController : Controller
    {
        // GET: /<controller>/
        [HttpGet]
        public IActionResult Index()
        {
            if (Request.Cookies["UserName"] != null)
            {
                var model = new UserLoginVM { UserName = Request.Cookies["UserName"] };
                return View(model);
            }
                //return RedirectToAction(nameof(Profile));
            return View();
        }
        [HttpPost]
        public IActionResult Index(UserLoginVM viewModel)
        {
            if (!ModelState.IsValid)
                return View(viewModel);
            //    Response.Cookies.Append("UserName", viewModel.UserName);

            // Persistering i sju dagar:

            Response.Cookies.Append("UserName", viewModel.UserName,
                new CookieOptions { Expires = DateTime.Now.AddDays(7) });

            return RedirectToAction(nameof(Profile));
        }
        [HttpGet]
        public IActionResult Profile()
        {
            var model = new UserDisplayVM { UserName = Request.Cookies["UserName"] };
            return View(nameof(Profile), model);
        }
    }
}
