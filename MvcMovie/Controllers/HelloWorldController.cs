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

        public string Index()
        {
            return "This is my default action...";
        }

        // 
        // GET: /HelloWorld/Welcome/ 

        public string Welcome(string name, int id = 1)
        {
            // 
            return HtmlEncoder.Default.Encode($"Hello {name}, ID: {id}");
        }
    }
}