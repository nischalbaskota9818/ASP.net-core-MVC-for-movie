using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;


namespace MvcMovie.Controllers;


public class HelloWorldController : Controller // Every public method in a controller is callable as an HTTP endpoint
{
    public IActionResult Index() //The Index method  ran the statement return View(),specified that the method should use a view template file to render a response to the browser.
    {
        return View();
    }

    // GET: /HelloWorld/Welcome/    //specifies an HTTP GET method that's invoked by appending /HelloWorld/Welcome/ to the URL.
    // Requires using System.Text.Encodings.Web; ->  to pass some parameter information from the URL to the controller. For example, /HelloWorld/Welcome?name=nischal &numtimes=5.

    // numTimes parameter defaults to 1 if no value is passed for that parameter.


    //yo welcome method ko lagi hamile Views/HelloWorld/welcome.cshtml file banako xau ra teslae local host ma display garda yesari lekhxau : https://localhost:7128/HelloWorld/Welcome?name=Nischal&numtimes=5
    public IActionResult Welcome(string name, int numTimes = 1)
    {
        ViewData["Message"] = "Hello" + name; //he ViewData dictionary is a dynamic object, which means any type can be used.he ViewData object has no defined properties until something is added and  contains data that will be passed to the view.
        ViewData["NumTimes"] = numTimes;
        return View();
    }
}
