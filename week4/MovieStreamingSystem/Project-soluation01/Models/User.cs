using System;
using System.Collections.Generic;

namespace MovieStreamingSystem.Models
{
   
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        public List<Review> Reviews { get; set; } 
        public List<Watchlist> Watchlists { get; set; } 
    }

   
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }

       
        public List<Movie> Movies { get; set; } 
    }

    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int ReleaseYear { get; set; }

        
        public int CategoryId { get; set; }
        public Category Category { get; set; } 

        
        public List<Review> Reviews { get; set; } 
        public List<Watchlist> Watchlists { get; set; } 
    }

    
    public class Review
    {
        public int Id { get; set; }
        public string Comment { get; set; }
        public int Rating { get; set; } 

       
        public int UserId { get; set; }
        public User User { get; set; }

        public int MovieId { get; set; }
        public Movie Movie { get; set; }
    }

    
    public class Watchlist
    {
        public int UserId { get; set; }
        public User User { get; set; }

        public int MovieId { get; set; }
        public Movie Movie { get; set; }

        public DateTime AddedDate { get; set; } 
    }
}