using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;
using Microsoft.AspNetCore.Http;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication1.Controllers
{
    public class BandsController : Controller
    {
        // GET: /<controller>/
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Band band)
        {
            if (!ModelState.IsValid)
                return View(band);
            DataManager.AddBand(band);
            HttpContext.Session.SetString("FormSubmitted", DateTime.Now.ToString());
            return RedirectToAction(nameof(BandsController.Index));
        }
        public IActionResult Index()
        {
            var model = DataManager.GetIndexList();
            var formSubmitted = HttpContext.Session.GetString("FormSubmitted");
            //var model = DataManager.GetAllBands();
            //var albums = DataManager.GetAllAlbums();
            //ViewData["TheId"] = id;
            //ViewBag.TheId = id;
            //ViewBag.Bands = DataManager.GetAllBands();
            return View(model);
        }

        public IActionResult Details(int id)
        {
            var model = DataManager.GetBand(id);
            ViewBag.Band = model;
            return View();
        }
        public IActionResult Albums()
        {
            var model = DataManager.GetAllAlbums();
            //ViewBag.Band = model;
            return View(model);
        }
        /*
        public IActionResult Albums(int id)
        {
            var model = DataManager.GetBand(id);
            //ViewBag.Band = model;
            return View(model);
        }
        */
    }
}
