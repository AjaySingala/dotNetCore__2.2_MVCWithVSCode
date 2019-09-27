using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        // 
        // GET: /HelloWorld/

        public IActionResult Index()
        {
            //return "This is my default action...";
            return View();
        }

        // 
        // GET: /HelloWorld/Welcome/ 

        public string Welcome()
        {
            return "This is the Welcome action method...";
        }

        // GET: /HelloWorld/Greet?name=ajay&numTimes=3
        // Requires using System.Text.Encodings.Web;
        public IActionResult Greet(string name, int numTimes = 1)
        {
            //return HtmlEncoder.Default.Encode($"Hello {name}, NumTimes is: {numTimes}");
            
            ViewData["message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;
            return View();
        }

        // GET: /HelloWorld/GreetId/333?name=ajay
        // Requires using System.Text.Encodings.Web;
        public string GreetId(string name, int id = 1)
        {
            return HtmlEncoder.Default.Encode($"Hello {name}, NumTimes is: {id}");
        }
    }
}