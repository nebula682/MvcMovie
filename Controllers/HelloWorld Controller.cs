using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET: /HelloWorld/
        public IActionResult Index()
{
    return View();
}

        // GET: /HelloWorld/Welcome/
    public IActionResult Welcome(string name, int numTimes = 1)
{
    // Store data to pass to the view
    ViewData["Message"] = "Hello " + name;
    ViewData["NumTimes"] = numTimes;

    // Return the Razor view
    return View();
}
    }
}
