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
            // Returns a HTML response to the browser
        }

        // Every public method in a controller is a HTTP endpoint i.e
        // providing the url below while run the enpoint below
        // GET: /HelloWorld/Welcome/ 

        public IActionResult Welcome(string name, int numTimes = 1)
        {
            //return HtmlEncoder.Default.Encode($"Hello {name} , ID: {numTimes}");
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;
            return View();// 
            //ViewData["Message"] = "Hello " + name;
            //ViewData["num"];

            //return HtmlEncoder.Default.Encode($"Hello {name}, ID: {id}");
        }
    }
}