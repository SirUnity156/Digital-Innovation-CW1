using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcCompany.Controllers;

public class CompanyController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult PeopleSearch()
    {
        return View();
    }
}