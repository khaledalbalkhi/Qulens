using System;
using Microsoft.AspNetCore.Mvc;

namespace Qulens.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
