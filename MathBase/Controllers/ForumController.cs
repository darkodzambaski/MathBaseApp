﻿using Microsoft.AspNetCore.Mvc;

namespace MathBase.Controllers
{
    public class ForumController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
