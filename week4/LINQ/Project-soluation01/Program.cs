using System;
using System.Collections.Generic;

class Student
{
    public string ?Name { get; set; }
    public int Age { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        List<Student> stds = new List<Student>()
        {
            new Student { Name = "ebtesam", Age = 27 },
            new Student { Name = "MOZA", Age = 27 },
            new Student { Name = "fatahia", Age = 50 },
            new Student { Name = "malak", Age = 90 },
            new Student { Name = "ahlam", Age = 60 }
        };


        /////Method Syntax/////
        var result = stds.Where(x => x.Age > 75);
        foreach (var s in result)
        { Console.WriteLine(s.Name); }
        //******************************************************///

        //////************أهم أوامر LINQ *****************///
        //-------------1-Where --------------------/
        var result0 = stds.Where(hamada => hamada.Age > 75);
        var result2 = stds.Where(x => x.Age > 50).Select(x => x.Name);
        foreach (var s in result0)
        { Console.WriteLine(s.Name); }

        //-------------------2-select-------------------/
        var result1 = stds.Select(x => x.Name);
        foreach (var s in result1)
        { Console.WriteLine(s); }

        //-------------------3-OrderBy ترتيب تصاعدي--------------------/
        var result3 = stds.OrderBy(x => x.Age);

        //-------------------4-OrderByDescending-------------------/
        var result4 = stds.OrderByDescending(x => x.Age);

        //-------------------5-FirstOrDefault----------------------/
        var student = stds.FirstOrDefault(x => x.Age == 1);

        //----------------------6-Count-------------------------/
        int total = stds.Count(); //لحساب العناصر
        int total1 = stds.Count(x => x.Age > 50); //أو بشرط

        //-------------------7-Any----------------------------/
        bool found = stds.Any(x => x.Age > 60);

    }
}