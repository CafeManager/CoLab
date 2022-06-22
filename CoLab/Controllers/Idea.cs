using Microsoft.AspNetCore.Mvc;
// using System.Text.Encodings.Web;

namespace CoLab.Controllers
{
    public class Idea : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        // GET: /HelloWorld/

        //public string Index()
        //{
        //    return "This is my default action...";
        //}

        // 
        // GET: /HelloWorld/Welcome/ 

        public string Welcome()
        {
            return "This is the Welcome action method...";
        }
    }

}
