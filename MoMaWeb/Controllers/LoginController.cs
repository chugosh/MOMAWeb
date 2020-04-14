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
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        // public IActionResult Create(UserInfo userInfo)
        // {
            
        // }
    }
    
}