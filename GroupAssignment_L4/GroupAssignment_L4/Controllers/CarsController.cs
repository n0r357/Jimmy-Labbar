using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GroupAssignment_L4.Models;
using GroupAssignment_L4.Models.Entities;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GroupAssignment_L4.Controllers
{
    public class CarsController : Controller
    {
        MotorbreathContext context;

        public CarsController(MotorbreathContext context)
        {
            this.context = context;
        }
        // GET: /<controller>/
        [HttpGet]
        public IActionResult Index()
        {
            var model = context.ListCars();
            return View(model);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(CarsCreateVM viewModel)
        {
            if (!ModelState.IsValid)
                return View(viewModel);
            context.AddCar(viewModel);
            return RedirectToAction(nameof(CarsController.Index));
        }
    }
}
