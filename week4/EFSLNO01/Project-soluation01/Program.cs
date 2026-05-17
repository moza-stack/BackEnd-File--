namespace Project_soluation01
{
    internal class Program
    {
        static void Main(string[] args)
        {

            AppDbContext db = new AppDbContext();

            student s1 = new student();
            Courses c1 = new Courses();

            Console.Write("Enter Name");
            s1.name = Console.ReadLine();

            Console.Write("Enter Age ");
            s1.age = Convert.ToInt32(Console.ReadLine());

            db.Add(s1);
            db.SaveChanges();

            Console.WriteLine("Student Added Successfully");
            //AppDbContext db = new AppDbContext();
            //student s1 = new student();
            //Courses c1 = new Courses();
            //s1.name = "Moza";
            //s1.age = 25;
            //db.Add(s1);
            //db.SaveChanges();
        }
    }
}
