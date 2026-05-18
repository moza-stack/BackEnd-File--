using Microsoft.EntityFrameworkCore;
using MovieStreamingSystem.Data;
using MovieStreamingSystem.Models;

ApplicationDbContext db = new ApplicationDbContext();



// Add Category

Category category = new Category()
{
    Name = "Action"
};

db.Categories.Add(category);
db.SaveChanges();

Console.WriteLine("Category Added");



// Add Movie


Movie movie = new Movie()
{
    Title = "Fast X",
    Description = "Action Movie",
    ReleaseYear = 2023,
    CategoryId = category.Id
};

db.Movies.Add(movie);
db.SaveChanges();

Console.WriteLine("Movie Added");



// Add User


User user = new User()
{
    Name = "Moza",
    Email = "moza@gmail.com"
};

db.Users.Add(user);
db.SaveChanges();

Console.WriteLine("User Added");


// Add Review


Review review = new Review()
{
    Comment = "Amazing movie",
    Rating = 5,
    UserId = user.Id,
    MovieId = movie.Id
};

db.Reviews.Add(review);
db.SaveChanges();

Console.WriteLine("Review Added");



// Add To Watchlist


Watchlist watchlist = new Watchlist()
{
    UserId = user.Id,
    MovieId = movie.Id,
    AddedDate = DateTime.Now
};


// التحقق من عدم تكرار الفيلم بالمفضلة
bool exists = db.Watchlists.Any(w =>
    w.UserId == user.Id &&
    w.MovieId == movie.Id);

if (!exists)
{
    db.Watchlists.Add(watchlist);
    db.SaveChanges();

    Console.WriteLine("Movie Added To Watchlist");
}
else
{
    Console.WriteLine("Movie already exists in watchlist");
}



// Get All Movies


var movies = db.Movies
    .Include(m => m.Category)
    .ToList();

Console.WriteLine("\nMovies List:");

foreach (var item in movies)
{
    Console.WriteLine($"{item.Title} - {item.Category.Name}");
}



// Get Reviews Per Movie


var movieReviews = db.Reviews
    .Include(r => r.User)
    .Include(r => r.Movie)
    .Where(r => r.MovieId == movie.Id)
    .ToList();

Console.WriteLine("\nMovie Reviews:");

foreach (var item in movieReviews)
{
    Console.WriteLine($"{item.User.Name}: {item.Comment} - Rating: {item.Rating}");
}



// Get User With Watchlist


var userWithWatchlist = db.Users
    .Include(u => u.Watchlists)
    .ThenInclude(w => w.Movie)
    .FirstOrDefault(u => u.Id == user.Id);

Console.WriteLine($"\n{userWithWatchlist.Name} Watchlist:");

foreach (var item in userWithWatchlist.Watchlists)
{
    Console.WriteLine(item.Movie.Title);
}



// Update Movie


var updateMovie = db.Movies.FirstOrDefault();

if (updateMovie != null)
{
    updateMovie.Title = "Fast and Furious";

    db.SaveChanges();

    Console.WriteLine("Movie Updated");
}



// Delete Movie


var deleteMovie = db.Movies.FirstOrDefault();

if (deleteMovie != null)
{
    db.Movies.Remove(deleteMovie);

    db.SaveChanges();

    Console.WriteLine("Movie Deleted");
}



// Top Rated Movies


var topMovies = db.Reviews
    .GroupBy(r => r.MovieId)
    .Select(g => new
    {
        MovieId = g.Key,
        AverageRating = g.Average(r => r.Rating)
    })
    .OrderByDescending(x => x.AverageRating)
    .ToList();

Console.WriteLine("\nTop Rated Movies:");

foreach (var item in topMovies)
{
    Console.WriteLine($"Movie ID: {item.MovieId} - Average Rating: {item.AverageRating}");
}