using System.Collections.Generic;
using TestTask.Repository.Models;
using Microsoft.AspNetCore.Mvc;
using TestTask.Common.Interfaces;
using TestTask.Common.Models;

namespace TestTask.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthorController : ControllerBase
    {
        private readonly IAuthorService _authorService;
        
        public AuthorController(IAuthorService authorService)
        {
            _authorService = authorService;
        }
        
        [HttpGet]
        public List<Author> GetAuthors()
        {
            return _authorService.GetAuthors();
        }

        [HttpPost("create")]
        public void CreateAuthor(List<Author> authors)
        {
            _authorService.CreateAuthor(authors);
        }

        [HttpPost("update")]
        public void UpdateAuthor(List<Author> authors)
        {
            _authorService.UpdateAuthor(authors);
        }

        [HttpPost("delete")]
        public void DeleteAuthors(List<Author> authors)
        {
            _authorService.DeleteAuthors(authors);
        }
    }
}