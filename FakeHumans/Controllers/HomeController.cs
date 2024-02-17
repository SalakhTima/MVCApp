using Microsoft.AspNetCore.Mvc;

namespace FakeHumans.Controllers;

public class HomeController : Controller
{
    public IActionResult Index() => View();
}
