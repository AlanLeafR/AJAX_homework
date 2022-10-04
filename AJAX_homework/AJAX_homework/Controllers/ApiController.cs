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
    }
}
