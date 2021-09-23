namespace TestTask.Repository.Models
{
    public class GenreEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public GenreEntity(string genre)
        {
            Name = genre;
        }

        public GenreEntity()
        {
            
        }
    }
}