using System.Collections.Generic;
using System.Linq;
using TestTask.Common.Models;

namespace TestTask.Common.Converters
{
    public static class Converters
    {
        public static List<Author> AuthorsConverter(this List<Repository.Models.AuthorEntity> authors)
        {
            if (authors == null)
            {
                return new List<Author>();
            }

            return authors.Select(x => new Models.Author
            {
                FIO = x.FIO,
                BirthDate = x.BirthDate,
                //Books = x.Books.BooksConverter()
            }).ToList();
        }

        public static List<Book> BooksConverter(this List<Repository.Models.BookEntity> books)
        {
            if (books == null)
            {
                return new List<Book>();
            }

            return books.Select(x => new Book
            {
                Name = x.Name,
                Date = x.Date,
                Genres = x.Genres.GenreConverter(),
                //Authors = x.Authors.AuthorsConverter(),
                Edition = x.Edition
            }).ToList();
        }

        public static List<Genre> GenreConverter(this List<Repository.Models.GenreEntity> genres)
        {
            if (genres == null)
            {
                return new List<Genre>();
            }

            return genres.Select(x => new Genre
            {
                Name = x.Name
            }).ToList();
        }

        public static List<Repository.Models.AuthorEntity> AuthorsConverter(this List<Common.Models.Author> authors)
        {
            if (authors == null)
            {
                return new List<Repository.Models.AuthorEntity>();
            }

            return authors.Select(x => new Repository.Models.AuthorEntity()
                {
                    FIO = x.FIO,
                    BirthDate = x.BirthDate,
                    //Books = x.Books.BooksConverter()
                }
            ).ToList();
        }

        public static List<Repository.Models.BookEntity> BooksConverter(this List<Common.Models.Book> books)
        {
            if (books == null)
            {
                return new List<Repository.Models.BookEntity>();
            }

            return books.Select(x => new Repository.Models.BookEntity()
                {
                    Name = x.Name,
                    Date = x.Date,
                    Genres = x.Genres.GenreConverter(),
                    //Authors = x.Authors.AuthorsConverter(),
                    Edition = x.Edition
                }
            ).ToList();
        }

        public static List<Repository.Models.GenreEntity> GenreConverter(this List<Common.Models.Genre> genres)
        {
            if (genres == null)
            {
                return new List<Repository.Models.GenreEntity>();
            }

            return genres.Select(x => new Repository.Models.GenreEntity()
                {
                    Name = x.Name
                }
            ).ToList();
        }
    }
}