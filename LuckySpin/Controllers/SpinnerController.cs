﻿using Microsoft.AspNetCore.Mvc;

// TODO: edit the Index Action to return the Lucky7 class output as "new ContentResult" rather than a view
namespace LuckySpin.Controllers
{
    public class SpinnerController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }
    }
}
