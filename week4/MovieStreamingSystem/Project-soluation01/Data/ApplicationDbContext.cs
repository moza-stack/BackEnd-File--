using Microsoft.EntityFrameworkCore;
using MovieStreamingSystem.Models;

namespace MovieStreamingSystem
{
     public class ApplicationDbContext : DbContext
    {
    public DbSet<User> Users { get; set; }
    
    public DbSet<Movie> Movies { get; set; }
    
    public DbSet<Category> Categories { get; set; }
    
    public DbSet<Watchlist> Watchlists { get; set; }
 
    public DbSet<Review> Reviews { get; set; }
  

   
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=MovieStreamingDb;Trusted_Connection=True;");
    }

    // 
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      
        modelBuilder.Entity<Watchlist>()
            .HasKey(w => new { w.UserId, w.MovieId });

        modelBuilder.Entity<Watchlist>()
            .HasOne(w => w.User)
            .WithMany(u => u.Watchlists)
            .HasForeignKey(w => w.UserId);

        modelBuilder.Entity<Watchlist>()
            .HasOne(w => w.Movie)
            .WithMany(m => m.Watchlists)
            .HasForeignKey(w => w.MovieId);
    }
}
}