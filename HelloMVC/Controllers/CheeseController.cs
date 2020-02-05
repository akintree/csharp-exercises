﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HelloMVC.Controllers
{
    public class CheeseController : Controller
    {
        // GET: /<controller>/

        static private Dictionary<string, string> Cheeses = new Dictionary<string, string>();

        public IActionResult Index()
        {
            ViewBag.cheeses = Cheeses;

            return View();
        }

        public IActionResult Add()
        {
            return View();
        }

        public IActionResult Remove()
        {
            ViewBag.cheeses = Cheeses;
            return View();
        }

        [HttpPost]
        [Route("/Cheese/Add")]
        public IActionResult NewCheese(string name, string description)
        {
            //string numbers = "0,1,2,3,4,5,6,7,8,9";
            //if (name != "")
            //{
            //    for (int i = 0; i < numbers.Length; i++)
            //    {
            //        if (name.IndexOf(numbers[i]) == -1)
            //        {
            //           string Message Exception 
            //        }
            //    }
            //}
            Cheeses.Add(name, description);
            return Redirect("/Cheese");
        }

        [HttpPost]
        [Route("/Cheese/Remove")]
        public IActionResult CheeseDelete(string[] cheeseArray)
        {
            for(int i = 0; i < cheeseArray.Length; i++)
            {
                if (Cheeses.ContainsKey(cheeseArray[i]))
                {
                    Cheeses.Remove(cheeseArray[i]);
                }
            }
            return Redirect("/Cheese");
        }
    }
}
