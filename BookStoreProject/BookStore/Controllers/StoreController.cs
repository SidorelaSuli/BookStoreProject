using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.Controllers
{
    public class StoreController : Controller
    {
        /*public IActionResult Index()
        {
            return View();
        }*/

            //
            // GET: /Store/
            public string Index()
            {
                return "Hello from Store.Index()";
            }
            //
            // GET: /Store/Browse
            public string Browse()
            {
                return "Hello from Store.Browse()";
            }
            //
            // GET: /Store/Details
            public string Details()
            {
                return "Hello from Store.Details()";
            }
    }
}