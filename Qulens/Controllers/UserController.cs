using System;
using Microsoft.AspNetCore.Mvc;

namespace Qulens.Controllers;

public class UserController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}