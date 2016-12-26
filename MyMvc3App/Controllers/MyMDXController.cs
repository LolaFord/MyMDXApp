using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyMvc3App.Controllers
{
    public class MyMDXController : Controller
    {
        //
        // GET: /MyMDX/

        ///public ActionResult Index()
        //{
            //return View();
        //}

        public ActionResult Index()
        {
            return View();
        }
        
        public string Welcome(string name, int numTimes = 1)
        {
            string message = "Hello " + name + ", numTimes is: " + numTimes;
            return "" + Server.HtmlEncode(message) + "";
        }
    }
}
