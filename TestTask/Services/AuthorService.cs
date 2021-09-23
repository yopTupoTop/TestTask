using System.Collections.Generic;
using System.Threading.Tasks;
using TestTask.Common.Converters;
using TestTask.Repository.Models;
using TestTask.Common.Interfaces;
using TestTask.Common.Models;

namespace TestTask.Services
{
    /// <inheritdoc />
    public class AuthorService : IAuthorService
    {
        private readonly IContext _context;
        
        public AuthorService(IContext context)
        {
            _context = context;
        }
        
        public List<Author> GetAuthors()
        {
          return  _context.GetAuthors().AuthorsConverter();
        }

        public void CreateAuthor(List<Author> authors)
        {
            var repositoryAuthor = authors.AuthorsConverter();
            _context.CreateAuthor(repositoryAuthor);
        }

        public void UpdateAuthor(List<Author> authors)
        {
            var repositoryAuthor = authors.AuthorsConverter();
            _context.UpdateAuthor(repositoryAuthor);
        }

        public void DeleteAuthors(List<Author> authors)
        {
            var repositoryAuthor = authors.AuthorsConverter();
            _context.DeleteAuthors(repositoryAuthor);
        }
    }
}