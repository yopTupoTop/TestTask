using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using TestTask.Common.Interfaces;
using TestTask.Common.Models;

namespace TestTask.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BookController : ControllerBase
    {
        private readonly IBookService _bookService;

        public BookController(IBookService bookService)
        {
            _bookService = bookService;
        }
        
        [HttpGet]
        public List<Book> GetBooks()
        {
            return _bookService.GetBooks();
        }
        [HttpPost("create")]
        public void CreateBooks(List<Book> books)
        {
            _bookService.CreateBooks(books);
        }
        [HttpPost("update")]
        public void UpdateBooks(List<Book> books)
        {
            _bookService.UpdateBooks(books);
        }
        [HttpPost("delete")]
        public void DeleteBooks(List<Book> books)
        {
            _bookService.DeleteBooks(books);
        }
    }
}