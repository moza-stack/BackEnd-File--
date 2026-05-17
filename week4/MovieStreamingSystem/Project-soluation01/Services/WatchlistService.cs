using MovieStreamingSystem.Data;
using Project_soluation01.Models;

namespace MovieStreamingSystem.Services
{
    public class WatchlistService
    {
        private readonly ApplicationDbContext _context;

        public WatchlistService(ApplicationDbContext context)
        {
            _context = context;
        }

        public void AddToWatchlist(int userId, int movieId)
        {
            var exists = _context.Watchlists
                .Any(w => w.UserId == userId && w.MovieId == movieId);

            if (!exists)
            {
                var watchlist = new Watchlist
                {
                    UserId = userId,
                    MovieId = movieId,
                    AddedDate = DateTime.Now
                };

                _context.Watchlists.Add(watchlist);
                _context.SaveChanges();
            }
        }
    }
}