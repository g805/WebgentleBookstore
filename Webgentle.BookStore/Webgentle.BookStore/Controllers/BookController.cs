﻿using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Webgentle.BookStore.Models;
using Webgentle.BookStore.Repository;

namespace Webgentle.BookStore.Controllers
{
    public class BookController : Controller
    {
        private readonly BookRepository _bookRepository = null;

        public BookController()
        {
            _bookRepository = new BookRepository();
        }
        /*public List<BookModel> GetAllBooks()
        {
            return _bookRepository.GetAllBooks();
        }*/

        public ViewResult GetAllBooks()
        {
            return View();
        }

        public BookModel GetBook(int id)
        {
            return _bookRepository.GetBookById(id);
        }

        public List<BookModel> SearchBooks(string bookName,string authorName)
        {
            return _bookRepository.SearchBook(bookName,authorName);
        }
            
    }
}
