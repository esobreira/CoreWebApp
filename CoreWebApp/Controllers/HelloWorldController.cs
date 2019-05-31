using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CoreWebApp.Controllers
{
    public class HelloWorldController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        //public string Index()
        //{
        //    return "This is my default action.";
        //}

        public string Welcome(string name, int ID = 1)
        {
            //return "This is the Welcome action method.";
            return HtmlEncoder.Default.Encode($"Hello {name}, ID: {ID}");
        }
    }
}