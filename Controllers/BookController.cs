﻿using BooksApp_Sec02.Data;
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

    }
}
