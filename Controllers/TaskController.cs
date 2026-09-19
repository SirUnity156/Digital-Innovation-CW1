using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcTask.Controllers;

public class TaskController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}