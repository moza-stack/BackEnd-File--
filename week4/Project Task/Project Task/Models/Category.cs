namespace MovieStreamingSystem.Models
{
    public class Category
    {
        public int Id { get; set; }

        public string Name { get; set; }

        // Navigation Property
        public List<Movie> Movies { get; set; } = new List<Movie>();
    }
}