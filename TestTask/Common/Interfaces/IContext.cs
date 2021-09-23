using System.Collections.Generic;
using System.Threading.Tasks;
using TestTask.Repository.Models;
using Author = TestTask.Common.Models.Author;

namespace TestTask.Common.Interfaces
{
    public interface IContext
    {
        public List<AuthorEntity> GetAuthors();
        public void CreateAuthor(List<Repository.Models.AuthorEntity> authors);
        public void UpdateAuthor(List<Repository.Models.AuthorEntity> authors);
        public void DeleteAuthors(List<Repository.Models.AuthorEntity> authors);
        public List<Repository.Models.BookEntity> GetBooks();
        public void CreateBooks(List<Repository.Models.BookEntity> books);
        public void UpdateBooks(List<Repository.Models.BookEntity> books);
        public void DeleteBooks(List<Repository.Models.BookEntity> books);
        public List<GenreEntity> Seeder();
        public List<Repository.Models.GenreEntity> GetGenres();
        public void CreateGenres(List<GenreEntity> genres);
        public void UpdateGenres(List<GenreEntity> genres);
        public void DeleteGenres(List<GenreEntity> genres);
    }
}