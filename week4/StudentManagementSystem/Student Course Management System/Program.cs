using Microsoft.EntityFrameworkCore;
using StudentManagementSystem.Data;
using StudentManagementSystem.Models;

namespace Student_Course_Management_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AppDbContext db = new AppDbContext();

            SeedData(db);

            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("\n===== STUDENT MANAGEMENT SYSTEM =====");

                Console.WriteLine("\n1- Add Student");
                Console.WriteLine("2- Update Student");
                Console.WriteLine("3- Delete Student");
                Console.WriteLine("4- Get All Students");
                Console.WriteLine("5- Search Student");
                Console.WriteLine("6- LINQ Operations");
                Console.WriteLine("7- Department Report");
                Console.WriteLine("8- Exit");

                Console.WriteLine("Choose: ");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        AddStudent(db);
                        break;

                    case 2:
                        UpdateStudent(db);
                        break;

                    case 3:
                        DeleteStudent(db);
                        break;

                    case 4:
                        GetAllStudents(db);
                        break;

                    case 5:
                        SearchStudent(db);
                        break;

                    case 6:
                        LINQOperations(db);
                        break;

                    case 7:
                        DepartmentReport(db);
                        break;

                    case 8:
                        exit = true;
                        break;
                }
            }
        }

        // ================= ADD =================

        static void AddStudent(AppDbContext db)
        {
            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Age: ");
            int age = int.Parse(Console.ReadLine());

            Console.Write("Email: ");
            string email = Console.ReadLine();

            //no email repeat 
            bool exists = db.Students.Any(s => s.Email == email);

            if (exists)
            {
                Console.WriteLine("Email already exists!");
                return;
            }

            Console.Write("Department Id: ");
            int deptId = int.Parse(Console.ReadLine());

            Student s = new Student()
            {
                Name = name,
                Age = age,
                Email = email,
                DepartmentId = deptId
            };

            db.Students.Add(s);
            db.SaveChanges();

            Console.WriteLine("Student Added Successfully");
        }

        // ================= UPDATE =================

        static void UpdateStudent(AppDbContext db)
        {
            Console.Write("Enter Student Id: ");
            int id = int.Parse(Console.ReadLine());

            Student student = db.Students.FirstOrDefault(s => s.Id == id);

            if (student != null)
            {
                Console.Write("New Name: ");
                student.Name = Console.ReadLine();

                Console.Write("New Age: ");
                student.Age = int.Parse(Console.ReadLine());

                Console.Write("New Email: ");
                student.Email = Console.ReadLine();

                db.SaveChanges();

                Console.WriteLine("Updated Successfully");
            }
            else
            {
                Console.WriteLine("Student Not Found");
            }
        }

        // ================= DELETE =================

        static void DeleteStudent(AppDbContext db)
        {
            Console.Write("Enter Student Id: ");
            int id = int.Parse(Console.ReadLine());

            Student student = db.Students.FirstOrDefault(s => s.Id == id);

            if (student != null)
            {
                db.Students.Remove(student);

                db.SaveChanges();

                Console.WriteLine("Deleted Successfully");
            }
            else
            {
                Console.WriteLine("Student Not Found");
            }
        }

        // ================= GET ALL =================

        static void GetAllStudents(AppDbContext db)
        {
            var students = db.Students
                .Include(s => s.Department)
                .Include(s => s.Courses)
                .ToList();

            foreach (var s in students)
            {
                Console.WriteLine($"\nID: {s.Id}");
                Console.WriteLine($"Name: {s.Name}");
                Console.WriteLine($"Age: {s.Age}");
                Console.WriteLine($"Email: {s.Email}");
                Console.WriteLine($"Department: {s.Department.Name}");

                Console.WriteLine("Courses:");

                foreach (var c in s.Courses)
                {
                    Console.WriteLine($"- {c.Title}");
                }
            }
        }

        // ================= SEARCH =================

        static void SearchStudent(AppDbContext db)
        {
            Console.Write("Enter Name: ");

            string name = Console.ReadLine();

            var students = db.Students
                .Where(s => s.Name.Contains(name))
                .ToList();

            foreach (var s in students)
            {
                Console.WriteLine($"{s.Name} - {s.Age}");
            }
        }

        // ================= LINQ =================

        static void LINQOperations(AppDbContext db)
        {
            Console.WriteLine("\nStudents Older Than 20");

            var older = db.Students
                .Where(s => s.Age > 20)
                .ToList();

            foreach (var s in older)
            {
                Console.WriteLine(s.Name);
            }

            Console.WriteLine("\nStudent Names Only");

            var names = db.Students
                .Select(s => s.Name)
                .ToList();

            foreach (var n in names)
            {
                Console.WriteLine(n);
            }

            Console.WriteLine("\nOrder By Age");

            var ordered = db.Students
                .OrderBy(s => s.Age)
                .ToList();

            foreach (var s in ordered)
            {
                Console.WriteLine($"{s.Name} - {s.Age}");
            }

            Console.WriteLine($"\nTotal Students: {db.Students.Count()}");

            bool any = db.Students.Any(s => s.Age > 25);

            Console.WriteLine($"\nAny Student Age > 25 ? {any}");

            double avg = db.Students.Average(s => s.Age);

            Console.WriteLine($"\nAverage Age: {avg}");

            var groups = db.Students
                .Include(s => s.Department)
                .GroupBy(s => s.Department.Name);

            foreach (var g in groups)
            {
                Console.WriteLine($"\nDepartment: {g.Key}");

                foreach (var s in g)
                {
                    Console.WriteLine(s.Name);
                }
            }
        }

        // ================= REPORT =================

        static void DepartmentReport(AppDbContext db)
        {
            var report = db.Students
                .Include(s => s.Department)
                .GroupBy(s => s.Department.Name)
                .Select(g => new
                {
                    Department = g.Key,
                    StudentCount = g.Count(),
                    AverageAge = g.Average(s => s.Age)
                });

            foreach (var item in report)
            {
                Console.WriteLine($"\nDepartment: {item.Department}");
                Console.WriteLine($"Students Count: {item.StudentCount}");
                Console.WriteLine($"Average Age: {item.AverageAge}");
            }
        }

        // ================= SEED DATA =================

        static void SeedData(AppDbContext db)
        {
            if (!db.Departments.Any())
            {
                Department d1 = new Department() { Name = "IT" };
                Department d2 = new Department() { Name = "Business" };
                Department d3 = new Department() { Name = "Engineering" };

                db.Departments.AddRange(d1, d2, d3);

                db.SaveChanges();
            }

            if (!db.Courses.Any())
            {
                Course c1 = new Course() { Title = "C#", Hours = 3 };
                Course c2 = new Course() { Title = "Database", Hours = 4 };
                Course c3 = new Course() { Title = "Networking", Hours = 2 };
                Course c4 = new Course() { Title = "AI", Hours = 5 };
                Course c5 = new Course() { Title = "Math", Hours = 3 };

                db.Courses.AddRange(c1, c2, c3, c4, c5);

                db.SaveChanges();
            }
        }
    }
}