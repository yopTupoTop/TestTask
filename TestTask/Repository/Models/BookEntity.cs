using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TestTask.Repository.Models
{
    public class BookEntity
    {
        [Key]
        public int BookId { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public int GenreId { get; set; }
        [ForeignKey("GenreId")]
        public List<GenreEntity> Genres { get; set; }
        public int AuthorBookId { get; set; }
        [ForeignKey("AuthorBookId")]
        public AuthorBookEntity AuthorBook { get; set; }
        public string Edition { get; set; }
    }
}