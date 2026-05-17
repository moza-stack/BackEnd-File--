using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_soluation01.Models
{
    public class Movie
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public int ReleaseYear { get; set; }

        // Foreign Key
        public int CategoryId { get; set; }

        // Navigation Property
        public Category Category { get; set; }

        public List<Review> Reviews { get; set; } = new();

        public List<Watchlist> Watchlists { get; set; } = new();
    }
}
