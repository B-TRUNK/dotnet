// https://learn.microsoft.com/en-us/aspnet/core/tutorials/first-mvc-app/adding-controller?view=aspnetcore-10.0&tabs=visual-studio-code

using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers;

public class HelloWorldController : Controller
{
    // 
    // GET: /HelloWorld/
    public string Index()
    {
        return "This is my default action...";
    }
    // 
    // GET: /HelloWorld/Welcome/ 
    public string Welcome(string name, int numTimes)
    {
        // http://localhost:5087/helloworld/welcome?name=Abanoub&numTimes=35
        // HtmlEncoder.Default.Encode to protect the app from malicious input, such as through JavaScript.
        return HtmlEncoder.Default.Encode($"Hello {name}, NumTimes is: {numTimes}");    
    }
}