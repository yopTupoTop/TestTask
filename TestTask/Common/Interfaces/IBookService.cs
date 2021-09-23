using System.Collections.Generic;
using TestTask.Repository.Models;
using TestTask.Common.Models;

namespace TestTask.Common.Interfaces
{
    public interface IBookService
    {
        public List<Book> GetBooks();
        public void CreateBooks(List<Book> books);
        public void UpdateBooks(List<Book> books);
        public void DeleteBooks(List<Book> books);
    }
}