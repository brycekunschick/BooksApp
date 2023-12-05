using BooksApp_Sec02.Data;
using BooksApp_Sec02.Models;
using Microsoft.AspNetCore.Mvc;

namespace BooksApp_Sec02.Controllers
{
    public class BookController : Controller
    {

        private BooksDBContext _context;//will hold a reference to the database object

        public BookController(BooksDBContext context) 
        { 
            _context = context;//passes the reference to the database into the _context variable

        }


        public IActionResult Index()//method that allows us to read the information from the database
        {

         List<Book> booksList = _context.books.ToList();//gets a list of all the books in the books table

            return View(booksList);
        }

        public IActionResult Create() 
        {
            return View();
        }

    }
}
