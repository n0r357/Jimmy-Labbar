using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GroupAssignment_L3_1.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GroupAssignment_L3_1.Controllers
{
    public class PeopleController : Controller
    {
        // GET: /<controller>/
        [HttpGet]
        public IActionResult Index()
        {
            var model = DataManager.ListPeople();
            return View(model);
        }
        [HttpPost]
        public IActionResult Index(int id)
        {
            var model = DataManager.GetPerson(id);
            return View(model);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(PeopleCreateVM person)
        {
            if (!ModelState.IsValid)
                return View(person);
            DataManager.AddPerson(person);
            return RedirectToAction(nameof(PeopleController.Index));
        }
        [HttpGet]
        public IActionResult Details(int id)
        {
            var model = DataManager.GetPerson(id);
            model.AcceptTerms = false;
            return View(model);
        }
        [HttpPost]
        public IActionResult Details(PeopleCreateVM person)
        {
            if (!ModelState.IsValid)
                return View(person);
            DataManager.EditPerson(person);
            return RedirectToAction(nameof(PeopleController.Index));
        }
    }
}
