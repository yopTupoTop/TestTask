using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TestTask.Repository.Models
{
    public class AuthorEntity
    {
        [Key]
        public int AuthorId { get; set; }
        public string FIO { get; set; }
        public DateTime BirthDate { get; set; }
        public int AuthorBookId { get; set; }
        [ForeignKey("AuthorBookId")]
        public AuthorBookEntity AuthorBook { get; set; }
    }
}