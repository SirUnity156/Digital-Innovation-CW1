using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using DigitalInnovationCW1.Models;

namespace DigitalInnovationCW1.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    public IActionResult LoginSignup()
    {
        return View();
    }

    public IActionResult Company()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
