using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using ui.Models;

namespace ui.Controllers
{
    public class HomeController : Controller
    {
        TodoManager bm = new TodoManager(new EfTodoDal());

        public IActionResult Todo()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Ekle()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Ekle(todo p)
        {
                bm.TAdd(p);
                p.tarih = DateTime.Parse(DateTime.Now.ToShortDateString());
                return RedirectToAction("Getir","Home");
        }
        [HttpGet]
        public IActionResult Sil(int id)
        {
            var blogvalue = bm.GetByID(id);
            bm.TDelete(blogvalue);
            TempData["silindi"] = "Yapılacak silindi";
            return RedirectToAction("Getir", "Home");
        }
        public IActionResult Getir()
        {
            var values = bm.GetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult Tamam(int id)
        {
            var blogvalue = bm.GetByID(id);
            bm.TUpdate(blogvalue);
            
            return RedirectToAction("Getir", "Home");
        }
        public IActionResult TodoIsmek()
        {
            return View();
        }
    }
}
