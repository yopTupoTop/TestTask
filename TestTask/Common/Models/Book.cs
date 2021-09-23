using System;
using System.Collections.Generic;

namespace TestTask.Common.Models
{
    public class Book
    {
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public List<Genre> Genres { get; set; }
        public List<Author> Authors { get; set; }
        public string Edition { get; set; }
    }
}