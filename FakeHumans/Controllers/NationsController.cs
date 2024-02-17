using FakeHumans.Other;
using Microsoft.AspNetCore.Mvc;

namespace FakeHumans.Controllers;

public class NationsController : Controller
{
    public IActionResult Russians() => View(HumanContainer.Russians);
    public IActionResult Germans() => View(HumanContainer.Germans);
    public IActionResult Americans() => View(HumanContainer.Americans);
    public IActionResult Italians() => View(HumanContainer.Italians);
}
