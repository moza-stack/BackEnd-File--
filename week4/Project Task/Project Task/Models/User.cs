namespace MovieStreamingSystem.Models
{
    public class User
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        // Navigation Properties
        public List<Review> Reviews { get; set; } = new List<Review>();

        public List<Watchlist> Watchlists { get; set; } = new List<Watchlist>();
    }
}