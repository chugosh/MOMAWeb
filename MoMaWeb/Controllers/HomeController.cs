using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MoMaWeb.Models;
using MoMaWeb.Service;
using MoMaWeb.ServiceImpl;

namespace MoMaWeb.Controllers
{
    public class HomeController : Controller
    {
        private readonly IRepostory<Student> _repostory;

        public HomeController(IRepostory<Student> repostory)
        {
            this._repostory = repostory;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Details()
        {
            return View(_repostory.GetList());
        }

        public IActionResult ShowOne(int id)
        {
            var student = _repostory.GetList().ToList().FirstOrDefault(x => x.id == id);
            return View(student);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(StudentCreateModel student)
        {
            var s = new Student(){
                name = student.FirstName + student.LastName,
                age = student.Age,
            };
            var newModel = _repostory.Add(s);
            // return View(nameof(ShowOne), newModel); //这种返回 虽然页面变了但是url没有变
            return RedirectToAction(nameof(ShowOne), new{ id = newModel.id}); //重定向指的是url改变
        }


    }
}
