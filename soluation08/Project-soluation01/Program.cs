using System.Diagnostics;
using System.IO;


namespace Project_soluation01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //File.Create("test01.txt");

            //File.WriteAllText("test01.txt", "Hello My FILE");
            //string[] lines =
            //{
            //    "Moza",
            //    "basma",
            //    "zahra",
            //};
            ////File.WriteAllLines("test01.txt", lines);

            //string[] lines2 =
            //{
            //    "Moza",
            //    "moham",
            //    "zahra",
            //};
            ////File.WriteAllLines("test01.txt", lines2);
            //File.AppendAllText("test01.txt", "\n this the new line");


            //Console.WriteLine("Hello, World!");
            ////
            ///


            try
            {


                File.Create("exam01.txt");

                File.Create("exam02.txt");
                File.Create("exam03.txt");

                Console.WriteLine("Press 1 to open exam01");
                Console.WriteLine("Press 2 to open exam02");
                Console.WriteLine("Press 3 to open exam03");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Process.Start("notepad.exe", "exam01.txt");
                        break;

                    case 2:
                        Process.Start("notepad.exe", "exam02.txt");
                        break;

                    case 3:
                        Process.Start("notepad.exe", "exam03.txt");
                        break;

                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
            }

            catch (FormatException)
            {
                Console.WriteLine("Please enter a number only");
            }

            catch (Exception ex)
            {
                Console.WriteLine("Error" + ex.Message);
            }
        }

    }
}
