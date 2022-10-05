using AJAX_homework.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AJAX_homework.Controllers
{
    public class ApiController : Controller
    {
        DemoContext _context = new DemoContext();
        //private readonly DemoContext _context; //把資料庫注入
        //public ApiController( DemoContext context)
        //{
        //    _context = context;
        //}
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Register(Member member)
        {
            DemoContext demo = new DemoContext();
            Member re = demo.Members.FirstOrDefault(p => p.Name == member.Name);
                       
            if (re != null)
                return Content("此姓名已被使用", "text/plain");
            else
                return Content("姓名可以使用", "text/plain");

        }
        public IActionResult City()
        {
            //讀取資料庫城市名稱
            var cities = _context.Addresses.Select(a => a.City).Distinct();
            return Json(cities); //回傳的是一組Json字串，在client端需要轉型成Json物件才能正常讀取
        }

        //根據城市名稱讀取鄉鎮區的資料
        public IActionResult Site(string city)
        {
            var sites = _context.Addresses.Where(a => a.City == city).Select(a => a.SiteId).Distinct();
            return Json(sites);
        }

        //根據鄉鎮區名稱讀取路的資料
        public IActionResult Road(string site)
        {
            var roads = _context.Addresses.Where(a => a.SiteId == site).Select(a => a.Road).Distinct();
            return Json(roads);
        }
    }
}
