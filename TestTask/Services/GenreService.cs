using System.Collections.Generic;
using TestTask.Common.Converters;
using TestTask.Repository.Models;
using TestTask.Common.Interfaces;
using TestTask.Common.Models;

namespace TestTask.Services
{
    public class GenreService : IGenreService
    {
        private readonly IContext _context;
        public GenreService(IContext context)
        {
            _context = context;
        }
        public List<Genre> Seeder()
        {
            return _context.Seeder().GenreConverter();
        }

        public List<Genre> GetGenres()
        {
            return _context.GetGenres().GenreConverter();
        }

        public void CreateGenres(List<Genre> genres)
        {
            var repositoryGenre = genres.GenreConverter();
            _context.CreateGenres(repositoryGenre);
        }

        public void UpdateGenres(List<Genre> genres)
        {
            var repositoryGenre = genres.GenreConverter();
            _context.UpdateGenres(repositoryGenre);
        }

        public void DeleteGenres(List<Genre> genres)
        {
            var repositoryGenre = genres.GenreConverter();
            _context.DeleteGenres(repositoryGenre);
        }
    }
}