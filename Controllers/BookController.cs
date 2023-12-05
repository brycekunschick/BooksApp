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


        public IActionResult Index(string searchString)//method that allows us to read the information from the database
        {

         List<Book> booksList = _context.books.ToList();//gets a list of all the books in the books table

            if(!String.IsNullOrEmpty(searchString))
            {
                booksList = booksList.Where(bk => bk.Title.Contains(searchString)).ToList();
                //The "bk" here can be anything because the compiler knows that it is working with a list of books
            }

            return View(booksList);
        }

        [HttpGet]
        //this is an http get request; you are getting the form
        public IActionResult Create() 
        {
            return View();
        }

        //this is an http post request, you are posting the data
        [HttpPost]
        public IActionResult Create(Book bookObj)
        {
            _context.books.Add(bookObj);//getting ready to add the book
            _context.SaveChanges();//this is when we actually add the book to the db

            return RedirectToAction("Index", "Book");

        }

        public IActionResult Details(int id) 
        {
            //connect to the book table in the database and fetch the book with the id that has been provided as a parameter
            Book myBook =    _context.books.Find(id);
            
            return View(myBook);

        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            //fetch the book associated with the ID that has been provided
            var myBook = _context.books.Find(id);

            return View(myBook);
        }

        [HttpPost]
        public IActionResult Edit(int id, [Bind("BookID, Title, Description, Author, DatePublished, Genre, Price")] Book myBook)
        {
            if (myBook.BookID == id) //checks ID matches URL, not necessary but sometimes needed to fix issues
            {

                if (ModelState.IsValid)
                {
                    _context.books.Update(myBook);
                    _context.SaveChanges();
                }

            }

                return RedirectToAction("Index");

        }


        [HttpGet]
        public IActionResult Delete(int id)
        {
            //fetch the book associated with the ID that has been provided
            var myBook = _context.books.Find(id);

            return View(myBook);//The view will render the book object that is being passed to it. Then, the HTML page that is generated will be displayed for the user
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeletePost(int id)
        {
            //find the record
            var myBook = _context.books.Find(id);

            if (myBook != null)
            {
                _context.books.Remove(myBook);
                _context.SaveChanges();
            }

            return RedirectToAction("Index");
        }

    }
}
