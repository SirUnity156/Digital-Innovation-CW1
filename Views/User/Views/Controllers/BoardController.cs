using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcBoard.Controllers;

public class BoardController : Controller
{
    public IActionResult ExampleBoard()
    {
        return View();
    }
}