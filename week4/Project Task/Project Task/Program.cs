using Microsoft.EntityFrameworkCore;
using MovieStreamingSystem.Data;
using MovieStreamingSystem.Models;

ApplicationDbContext db = new ApplicationDbContext();


// 1. إضافة التصنيفات (Categories)

var actionCat = db.Categories.FirstOrDefault(c => c.Name == "Action") ?? new Category { Name = "Action" };
var comedyCat = db.Categories.FirstOrDefault(c => c.Name == "Comedy") ?? new Category { Name = "Comedy" };
var sciFiCat = db.Categories.FirstOrDefault(c => c.Name == "Sci-Fi") ?? new Category { Name = "Sci-Fi" };

if (actionCat.Id == 0) db.Categories.Add(actionCat);
if (comedyCat.Id == 0) db.Categories.Add(comedyCat);
if (sciFiCat.Id == 0) db.Categories.Add(sciFiCat);

db.SaveChanges();
Console.WriteLine("✅ Categories Handled (Action, Comedy, Sci-Fi)");

// 2. إضافة الأفلام (Movies)

var movie1 = db.Movies.FirstOrDefault(m => m.Title == "Interstellar") ?? new Movie { Title = "Interstellar", Description = "Epic sci-fi theme", ReleaseYear = 2014, CategoryId = sciFiCat.Id };
var movie2 = db.Movies.FirstOrDefault(m => m.Title == "The Avengers") ?? new Movie { Title = "The Avengers", Description = "Superheroes team up", ReleaseYear = 2012, CategoryId = actionCat.Id };
var movie3 = db.Movies.FirstOrDefault(m => m.Title == "The Hangover") ?? new Movie { Title = "The Hangover", Description = "Comedy road trip", ReleaseYear = 2009, CategoryId = comedyCat.Id };
var movie4 = db.Movies.FirstOrDefault(m => m.Title == "Inception") ?? new Movie { Title = "Inception", Description = "Dream within a dream", ReleaseYear = 2010, CategoryId = sciFiCat.Id };

if (movie1.Id == 0) db.Movies.Add(movie1);
if (movie2.Id == 0) db.Movies.Add(movie2);
if (movie3.Id == 0) db.Movies.Add(movie3);
if (movie4.Id == 0) db.Movies.Add(movie4);

db.SaveChanges();
Console.WriteLine("✅ Movies Handled (Interstellar, Avengers, Hangover, Inception)");


// 3. إضافة المستخدمين (Users)

var userMoza = db.Users.FirstOrDefault(u => u.Email == "moza@gmail.com") ?? new User { Name = "Moza", Email = "moza@gmail.com" };
var userAhmed = db.Users.FirstOrDefault(u => u.Email == "ahmed@gmail.com") ?? new User { Name = "Ahmed", Email = "ahmed@gmail.com" };
var userSara = db.Users.FirstOrDefault(u => u.Email == "sara@gmail.com") ?? new User { Name = "Sara", Email = "sara@gmail.com" };

if (userMoza.Id == 0) db.Users.Add(userMoza);
if (userAhmed.Id == 0) db.Users.Add(userAhmed);
if (userSara.Id == 0) db.Users.Add(userSara);

db.SaveChanges();
Console.WriteLine("✅ Users Handled (Moza, Ahmed, Sara)");


// 4. إضافة مراجعات وتقييمات متنوعة (Reviews)

List<Review> newReviews = new List<Review>()
{
    new Review { Comment = "Masterpiece! Best movie ever.", Rating = 5, UserId = userMoza.Id, MovieId = movie1.Id },
    new Review { Comment = "Very fun and action-packed.", Rating = 4, UserId = userAhmed.Id, MovieId = movie2.Id },
    new Review { Comment = "Hilarious, laughed from start to end.", Rating = 5, UserId = userSara.Id, MovieId = movie3.Id },
    new Review { Comment = "Confusing but brilliant.", Rating = 4, UserId = userMoza.Id, MovieId = movie4.Id },
    new Review { Comment = "Overrated action movie.", Rating = 3, UserId = userSara.Id, MovieId = movie2.Id },
    new Review { Comment = "Visually stunning!", Rating = 5, UserId = userAhmed.Id, MovieId = movie1.Id }
};

foreach (var rev in newReviews)
{
    // التحقق لمنع تكرار نفس التقييم لنفس المستخدم على نفس الفيلم
    if (!db.Reviews.Any(r => r.UserId == rev.UserId && r.MovieId == rev.MovieId))
    {
        db.Reviews.Add(rev);
    }
}
db.SaveChanges();
Console.WriteLine("✅ Reviews Handled successfully");


// 5. إضافة المفضلة للمستخدمين (Watchlists)

List<Watchlist> watchlists = new List<Watchlist>()
{
    new Watchlist { UserId = userMoza.Id, MovieId = movie1.Id, AddedDate = DateTime.Now },
    new Watchlist { UserId = userMoza.Id, MovieId = movie4.Id, AddedDate = DateTime.Now },
    new Watchlist { UserId = userAhmed.Id, MovieId = movie2.Id, AddedDate = DateTime.Now },
    new Watchlist { UserId = userSara.Id, MovieId = movie1.Id, AddedDate = DateTime.Now }
};

foreach (var w in watchlists)
{
    if (!db.Watchlists.Any(x => x.UserId == w.UserId && x.MovieId == w.MovieId))
    {
        db.Watchlists.Add(w);
    }
}
db.SaveChanges();
Console.WriteLine("✅ Watchlists Handled successfully.\n");


// 6. عرض قائمة الأفلام وتصنيفاتها

var moviesList = db.Movies.Include(m => m.Category).ToList();
Console.WriteLine("🎬 System Movies Directory:");
foreach (var item in moviesList)
{
    Console.WriteLine($"- {item.Title} | Category: {item.Category.Name} ({item.ReleaseYear})");
}


// 7. عرض أعلى الأفلام تقييماً بالترتيب التنازلي مع المعدل الحقيقي

var topMovies = db.Reviews
    .Include(r => r.Movie)
    .GroupBy(r => new { r.MovieId, r.Movie.Title })
    .Select(g => new
    {
        MovieTitle = g.Key.Title,
        AverageRating = g.Average(r => r.Rating)
    })
    .OrderByDescending(x => x.AverageRating)
    .ToList();

Console.WriteLine("\n🏆 Top Rated Movies Leaderboard:");
foreach (var item in topMovies)
{
    Console.WriteLine($"- {item.MovieTitle} | ⭐ Average Rating: {item.AverageRating:F1}/5");
}