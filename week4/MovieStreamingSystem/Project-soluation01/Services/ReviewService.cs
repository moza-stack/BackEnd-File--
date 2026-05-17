using Microsoft.EntityFrameworkCore;
using MovieStreamingSystem.Data;
using Project_soluation01.Models;

namespace MovieStreamingSystem.Services
{
    public class ReviewService
    {
        private readonly ApplicationDbContext _context;

        public ReviewService(ApplicationDbContext context)
        {
            _context = context;
        }

        public void AddReview(Review review)
        {
            _context.Reviews.Add(review);
            _context.SaveChanges();
        }

        public List<Review> GetMovieReviews(int movieId)
        {
            return _context.Reviews
                .Include(r => r.User)
                .Where(r => r.MovieId == movieId)
                .ToList();
        }
    }
}