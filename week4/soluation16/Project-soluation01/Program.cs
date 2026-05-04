
namespace Project_Solution01
{
    //1. class Movie 
    class Movie
    {
        public string Title { get; set; }
        public string Genre { get; set; }
        public int Year { get; set; }
        public int Rating { get; set; }

        public Movie(string title, string genre, int year, int rating = 5)
        {
            Title = title;
            Genre = genre;
            Year = year;

            if (rating >= 1 && rating <= 10)
                Rating = rating;
            else
                Rating = 5;
        }
    }

    //2 .class User 
    class User
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public User(string name, int age)
        {
            Name = name;
            Age = age;

            Console.WriteLine($"Welcome {Name}!");
        }
    }
    //3 .class Review 
    class Review
    {
        public string UserName { get; set; }
        public string MovieTitle { get; set; }
        public string Comment { get; set; }
        public int Rate { get; set; }

        public Review(string userName, string movieTitle, string comment, int rate)
        {
            UserName = userName;
            MovieTitle = movieTitle;
            Comment = comment;
            Rate = rate;
        }
    }

    // Main Requirements
    internal class Program
    {
        static void Main(string[] args)
        {

            Movie m1 = new Movie("Inception", "Sci-Fi", 2010, 9);
            Movie m2 = new Movie("Titanic", "Drama", 2011, 8);
            Movie m3 = new Movie("Avatar", "Action", 2009, 7);

            User u1 = new User("Moza", 25);

            Console.WriteLine("\nMovies:");
            Console.WriteLine(m1.Title + " - " + m1.Rating);
            Console.WriteLine(m2.Title + " - " + m2.Rating);
            Console.WriteLine(m3.Title + " - " + m3.Rating);

            Review r1 = new Review("Moza", "Inception", "Great movie!", 10);

            Console.WriteLine("\nReviews:");
            Console.WriteLine(r1.UserName + " rated " + r1.MovieTitle + ": " + r1.Rate + " - " + r1.Comment);

        }
    }
}