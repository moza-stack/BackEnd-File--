using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_soluation01.Models
{
    public class Category
    {
        public int Id { get; set; }

        public string? Name { get; set; }

        public List<Movie> Movies { get; set; } = new();
    }
}
