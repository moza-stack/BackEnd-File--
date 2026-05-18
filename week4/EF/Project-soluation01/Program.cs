//namespace Project_soluation01
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            AppDbContext db = new AppDbContext();
//            Student s1 = new Student();
//            Courses c1 = new Courses();
//            s1.name = "Moza";
//            s1.age = 25;
//            db.Add(s1);
//            db.SaveChanges();
//        }
//    }
//}
namespace Project_soluation01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AppDbContext db = new AppDbContext();

            Student s1 = new Student();

            // إدخال الاسم
            Console.Write("Enter Name: ");
            s1.name = Console.ReadLine();

            // إدخال العمر
            Console.Write("Enter Age: ");
            s1.age = Convert.ToInt32(Console.ReadLine());

            // إضافة الطالب لقاعدة البيانات
            db.Add(s1);

            // حفظ البيانات
            db.SaveChanges();

            Console.WriteLine("\nStudent Added Successfully");

            // عرض البيانات في الكونسول
            Console.WriteLine("\nStudent Information");

            Console.WriteLine($"Name: {s1.name}");
            Console.WriteLine($"Age: {s1.age}");
        }
    }
}