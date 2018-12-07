using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BookStore.Models;

namespace BookStore.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        BookStoreEntities storeDB = new BookStoreEntities();

        public ActionResult Index()
        {
            // Get most popular albums
            var books = GetTopSellingBookss(5);

            return View(books);
        }

        private List<Book> GetTopSellingAlbums(int count)
        {
            // Group the order details by album and return
            // the albums with the highest count

            return storeDB.Books
                .OrderByDescending(a => a.OrderDetails.Count())
                .Take(count)
                .ToList();
        }
    }
}
}

