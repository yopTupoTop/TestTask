using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TestTask.Common.Enums;
using TestTask.Common.Interfaces;
using TestTask.Repository.Models;
using Author = TestTask.Common.Models.Author;

namespace TestTask.Repository
{
    public class Context : DbContext, IContext
    {
        private DbSet<Models.AuthorEntity> Authors { get; set; }
        private DbSet<Models.BookEntity> Books { get; set; }
        private DbSet<Models.GenreEntity> Genres { get; set; }

        public Context(DbContextOptions<Context> options) : base(options)
        {
            Database.EnsureCreated();
        }

        #region Author

        public List<Repository.Models.AuthorEntity> GetAuthors()
        {
            List<AuthorEntity> authors = Authors.ToList();
            return authors;
        }

        public void CreateAuthor(List<Repository.Models.AuthorEntity> authors)
        {
            foreach (var author in authors)
            {
                Authors.Add(author);
            }
            SaveChangesAsync();
        }

        public void UpdateAuthor(List<Models.AuthorEntity> authors)
        {
            foreach (var author in authors)
            {
                var authorsToUpdate = Authors
                    .Where(x => x.AuthorId == author.AuthorId)
                    .Select(x => x).ToList();
                authorsToUpdate.ForEach(x =>
                    {
                        x.AuthorBook = author.AuthorBook;
                        x.BirthDate = author.BirthDate;
                        x.FIO = author.FIO;
                    }
                );
            }

            SaveChangesAsync();
        }

        public void DeleteAuthors(List<Models.AuthorEntity> authors)
        {
            foreach (var author in authors)
            {
                Authors.Remove(author);
            }

            SaveChangesAsync();
        }

        #endregion

        #region Book

        public List<Repository.Models.BookEntity> GetBooks()
        {
            List<Models.BookEntity> books = Books.ToList();
            return books;
        }

        public void CreateBooks(List<BookEntity> books)
        {
            foreach (var book in books)
            {
                Books.Add(book);
            }

            SaveChangesAsync();
        }

        public void UpdateBooks(List<Models.BookEntity> books)
        {
            foreach (var book in books)
            {
                var booksToUpdate = Books
                    .Where(x => x.BookId == book.BookId).ToList();
                booksToUpdate.ForEach(x =>
                {
                    x.Name = book.Name;
                    x.Date = book.Date;
                    x.AuthorBookId = book.AuthorBookId;
                    x.Genres = book.Genres;
                    x.Edition = book.Edition;
                });
            }

            SaveChangesAsync();
        }

        public void DeleteBooks(List<Models.BookEntity> books)
        {
            foreach (var book in books)
            {
                Books.Remove(book);
            }

            SaveChangesAsync();
        }

        
        #endregion

        #region Genre
        
        public List<GenreEntity> Seeder()
        {
            if (!Genres.Any())
            {
                Genres.Add(new GenreEntity(GenreEnum.Horror.ToString()));
                Genres.Add(new GenreEntity(GenreEnum.Drama.ToString()));
                Genres.Add(new GenreEntity(GenreEnum.Fantasy.ToString()));
            }

            return Genres.ToList();
        }


        public List<Models.GenreEntity> GetGenres()
        {
            List<Models.GenreEntity> genres = Genres.ToList();
            return genres;
        }

        public void CreateGenres(List<GenreEntity> genres)
        {
            foreach (var genre in genres)
            {
                Genres.Add(genre);
            }

            SaveChangesAsync();
        }

        public void UpdateGenres(List<GenreEntity> genres)
        {
            foreach (var genre in genres)
            {
                var genresToUpdate = Genres
                    .Where(x => x.Id == genre.Id)
                    .Select(x => x).ToList();
                genresToUpdate.ForEach(x => { x.Name = genre.Name; }
                );
            }
        }

        public void DeleteGenres(List<GenreEntity> genres)
        {
            foreach (var genre in genres)
            {
                Genres.Remove(genre);
            }
        }

        #endregion
    }
}
