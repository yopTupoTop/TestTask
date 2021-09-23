using System;
using System.Collections.Generic;

namespace TestTask.Common.Models
{
    public class Author
    {
        public string FIO { get; set; }
        public DateTime BirthDate { get; set; }
        public List<Book> Books { get; set; }
    }
}