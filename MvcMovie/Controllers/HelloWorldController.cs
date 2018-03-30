using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {

        // Each Controllers public method is an a endpoint.
        // for example Welcome() will have HelloWorld/Welcome
        // 
        // GET: /HelloWorld/

        public IActionResult Index()
        {
            return View();
        }

        // 
        // GET: /HelloWorld/Welcome/ 

        public IActionResult Welcome(string name, int id = 1)
        {
            // 
            ViewData["Message"] = "Hello " + name;
            ViewData["num"];

            return HtmlEncoder.Default.Encode($"Hello {name}, ID: {id}");
        }
    }
}