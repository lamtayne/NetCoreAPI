using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using DemoMVC.Models;

namespace DemoMVC.Controllers;

public class StudentController : Controller
{
        public IActionResult Student()
    {
        return View();
    }
}
