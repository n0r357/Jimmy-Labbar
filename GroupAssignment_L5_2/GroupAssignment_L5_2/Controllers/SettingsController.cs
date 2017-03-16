using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GroupAssignment_L5_2.Models;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.AspNetCore.Http;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GroupAssignment_L5_2.Controllers
{
    public class SettingsController : Controller
    {
        StateManager state = new StateManager();
        IMemoryCache cache;
        public SettingsController(IMemoryCache cache)
        {
            this.cache = cache;
        }
        // GET: /<controller>/
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(CreateVM viewModel)
        {
            if (!ModelState.IsValid)
                return View(viewModel);
            cache.Set(state.Email, viewModel.Email);
            HttpContext.Session.SetString(state.CompanyName, viewModel.CompanyName);
            TempData[state.IsCreated] = state.CompanyName;
            return RedirectToAction(nameof(Display));
        }
        [HttpGet]
        public IActionResult Display()
        {
            DisplayVM viewModel = new DisplayVM()
            {
                Email = cache.Get<string>(state.Email),
                CompanyName = HttpContext.Session.GetString(state.CompanyName),
            };
            if ((string)TempData[state.IsCreated] != null)
            {
                viewModel.IsCreated = true;
            }
            return View(viewModel);
        }
    }
}
