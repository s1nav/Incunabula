using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IncunabulaWebApp.Data;
using IncunabulaWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace IncunabulaWebApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ListBooks()
        {
            var repo = new DataRepository(new DataContext());
            var list = repo.Books;
            return View(list);
        }

        public IActionResult EditBook() => View();

        public IActionResult AddBook() => View();

        [HttpPost]
        public IActionResult AddBook(Book book)
        {
            var repo = new DataRepository(new DataContext());
            repo.AddBook(book);

            return RedirectToAction(nameof(Index));
        }
    }
}
