using System.Collections.Generic;
using TestTask.Common.Converters;
using TestTask.Repository.Models;
using TestTask.Common.Interfaces;
using TestTask.Common.Models;

namespace TestTask.Services
{
    public class BookService : IBookService
    {
        private readonly IContext _context;
        
        public BookService(IContext context)
        {
            _context = context;
        }
        public List<Book> GetBooks()
        {
           return _context.GetBooks().BooksConverter();
        }

        public void CreateBooks(List<Book> books)
        {
            var repositoryBook = books.BooksConverter();
            _context.CreateBooks(repositoryBook);
        }

        public void UpdateBooks(List<Book> books)
        {
            var repositoryBook = books.BooksConverter();
            _context.UpdateBooks(repositoryBook);
        }

        public void DeleteBooks(List<Book> books)
        {
            var repositoryBook = books.BooksConverter();
            _context.DeleteBooks(repositoryBook);
        }
    }
}