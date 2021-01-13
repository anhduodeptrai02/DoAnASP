using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using DoAnASP.NET1.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using DoAnASP1.Areas.Admin.Data;
using DoAnASP1.Areas.Admin.Models;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using Microsoft.EntityFrameworkCore;

namespace DoAnASP.NET1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly DPcontext _context;

        public HomeController(DPcontext context)
        {
            _context = context;
        }

        //public HomeController(ILogger<HomeController> logger)
        //{
        //    _logger = logger;
        //}

        public async Task<IActionResult> Index()
        {
            if (HttpContext.Session.GetInt32("soluottruycap") == null)
            {
                HttpContext.Session.SetInt32("soluottruycap", 1);
            }
            else
            {
                HttpContext.Session.SetInt32("soluottruycap", (int)(HttpContext.Session.GetInt32("soluottruycap")+1));
            }
            ViewData["soluottruycap"] = HttpContext.Session.GetInt32("soluottruycap");
            var dPcontext = from m in _context.SanPham select m;
            ViewBag.SanPham = dPcontext;
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }
        public async Task<IActionResult> Details(int? id)
        {
            if (HttpContext.Session.GetInt32("soluotxem") == null)
            {
                HttpContext.Session.SetInt32("soluotxem", 1);
            }
            else
            {
                HttpContext.Session.SetInt32("soluotxem", (int)(HttpContext.Session.GetInt32("soluotxem") + 1));
            }
            ViewData["soluotxem"] = HttpContext.Session.GetInt32("soluotxem");
            if (id == null)
            {
                return NotFound();
            }

            var hoaDon = await _context.SanPham
                .FirstOrDefaultAsync(m => m.MaSP == id);
            if (hoaDon == null)
            {
                return NotFound();
            }

            return View(hoaDon);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
