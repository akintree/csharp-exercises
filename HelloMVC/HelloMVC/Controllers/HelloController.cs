using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace HelloMVC.Controllers
{
    public class HelloController: Controller
    {


        [HttpGet]
        public IActionResult Index(string name, string language)
        {
            string html = "<form method='post'>" + 
                "<input type='text' name='name' />" + 
                "<select name='language'>" +
                    "<option value='english'>English</option>" +
                    "<option value='spanish'>Spanish</option>" +
                    "<option value='french'>French</option>" +
                    "<option value='german'>German</option>" +
                    "<option value='mandarin'>Mandarin</option>" + 
                "</select>" +
                "<input type='submit' value='Greet me!' />" + "</form>";
            //return Redirect("/Hello/Goodbye");
            return Content(html, "text/html");
        }

        public static string CreateMessage(string name, string language)
        {
            string greeting;
            if (language == "mandarin")
            {
                greeting = "Ni hao";
            }
            else if (language == "spanish")
            {
                greeting = "Hola";
            }
            else if (language == "french")
            {
                greeting = "Bonjour";
            }
            else if (language == "german")
            {
                greeting = "Guten tag";
            }
            else
            {
                greeting = "Hello";
            }
            return greeting + " " + name;
        }

        //public static cookieCounter()
        //{
        //    if (Request.Cookies("visitCount") == null)
        //{
        //    int visitCount = 1;
        //    string value = visitCount.ToString();
        //    Response.Cookies.Append(name, value);
        //}
            
        //}

        [Route("/Hello")]
        [HttpPost]
        public IActionResult Display(string language, string name = "World")
        {
            return Content(string.Format("<h2><i>{0}</i></h2>", CreateMessage(name, language)), "text/html");
        }

        //[Route("/Hello/{name}")]
        public IActionResult Index2(string name)
        {
            return Content(string.Format("<h1>Hello {0}</h1>", name), "text/html");
        }
        public IActionResult Goodbye()
        {
            return Content("Goodbye");
        }
    }
}
