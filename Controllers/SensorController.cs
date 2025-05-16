using Microsoft.AspNetCore.Mvc;

namespace cosmonautica_v2.Controllers;

public class SensorController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}