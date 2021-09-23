using System;
using System.Collections.Generic;
using TestTask.Common.Enums;
using TestTask.Repository.Models;
using Microsoft.AspNetCore.Mvc;
using TestTask.Common.Interfaces;
using TestTask.Common.Models;

namespace TestTask.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GenreController : ControllerBase
    {
        private readonly IGenreService _genreService;

        public GenreController(IGenreService genreService)
        {
            _genreService = genreService;
        }
        [HttpGet("seed")]
        public List<Genre> Seeder()
        {
            return _genreService.Seeder();
        }
        [HttpGet]
        public List<Genre> GetGenre()
        {
            return _genreService.GetGenres();
        }
        [HttpPost("create")]
        public void CreateGenre(List<Genre> genres)
        {
            _genreService.CreateGenres(genres);
        }
        [HttpPost("update")]
        public void UpdateGenre(List<Genre> genres)
        {
            _genreService.UpdateGenres(genres);
        }
        [HttpPost("delete")]
        public void DeleteGenre(List<Genre> genres)
        {
            _genreService.DeleteGenres(genres);
        }
    }
}