﻿using Microsoft.AspNetCore.Mvc;

namespace WebTaskLayout.Controllers
{
    public class TeacherController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
