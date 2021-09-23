using System.Collections.Generic;
using System.Threading.Tasks;
using TestTask.Repository.Models;
using TestTask.Common.Models;

namespace TestTask.Common.Interfaces
{
    public interface IAuthorService
    {
        public List<Author> GetAuthors();

        public void CreateAuthor(List<Author> authors);

        public void UpdateAuthor(List<Author> authors);

        public void DeleteAuthors(List<Author> authors);
    }
}