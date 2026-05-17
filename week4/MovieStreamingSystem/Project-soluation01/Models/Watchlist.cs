using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_soluation01.Models
{
    public class Watchlist
    {
        public int UserId { get; set; }

        public int MovieId { get; set; }

        public DateTime AddedDate { get; set; }

        public User User { get; set; }

        public Movie Movie { get; set; }
    }
}
