using MovieStreamingSystem.Data;
using Project_soluation01.Models;

namespace MovieStreamingSystem.Services
{
    public class MovieService
    {
        private readonly ApplicationDbContext _context;

        public MovieService(ApplicationDbContext context)
        {
            _context = context;
        }

        // Add
        public void AddMovie(Movie movie)
        {
            _context.Movies.Add(movie);
            _context.SaveChanges();
        }

        // Get All
        public List<Movie> GetMovies()
        {
            return _context.Movies.ToList();
        }

        // Update
        public void UpdateMovie(int id, string title)
        {
            var movie = _context.Movies.Find(id);

            if (movie != null)
            {
                movie.Title = title;
                _context.SaveChanges();
            }
        }

        // Delete
        public void DeleteMovie(int id)
        {
            var movie = _context.Movies.Find(id);

            if (movie != null)
            {
                _context.Movies.Remove(movie);
                _context.SaveChanges();
            }
        }
    }
}