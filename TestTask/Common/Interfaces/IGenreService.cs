using System.Collections.Generic;
using TestTask.Repository.Models;
using TestTask.Common.Models;

namespace TestTask.Common.Interfaces
{
    public interface IGenreService
    {
        public List<Genre> Seeder();
        public List<Genre> GetGenres();
        public void CreateGenres(List<Genre> genres);
        public void UpdateGenres(List<Genre> genres);
        public void DeleteGenres(List<Genre> genres);
    }
}