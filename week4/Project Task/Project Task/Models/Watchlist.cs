namespace MovieStreamingSystem.Models
{
    public class Watchlist
    {
        // Composite Key
        public int UserId { get; set; }

        public int MovieId { get; set; }

        public DateTime AddedDate { get; set; }

        // Navigation Properties
        public User User { get; set; }

        public Movie Movie { get; set; }
    }
}