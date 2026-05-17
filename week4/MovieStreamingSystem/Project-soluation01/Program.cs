using MovieStreamingSystem.Data;
using Project_soluation01.Models;


ApplicationDbContext db = new ApplicationDbContext();

User user = new User()
{
    Name = "Moza",
    Email = "moza@gmail.com"
};

db.Users.Add(user);
db.SaveChanges();

Console.WriteLine("User Added");