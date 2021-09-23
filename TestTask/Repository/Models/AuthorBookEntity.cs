using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TestTask.Repository.Models
{
    public class AuthorBookEntity
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("AuthorId")]
        public int AuthorId {get; set; }
        [ForeignKey("BookId")]
        public int BookId { get; set; }
    }
}