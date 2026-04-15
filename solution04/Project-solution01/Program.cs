namespace Project_solution01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task 1 – Positive, Negative, or Zero
            Console.WriteLine("Please Enter Number");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num > 0)
            {
                Console.WriteLine("Positive");
            }
            else if (num < 0)
            {
                Console.WriteLine("Negative");
            }
            else
            {
                Console.WriteLine("Zero");
            }
            //Task 2 – Even or Odd

            Console.WriteLine("Please Enter an integer number");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num % 2 == 0)
            {
                Console.WriteLine("Even Number");
            }
            else
            {
                Console.WriteLine("Odd Number");
            }

            //Task 3 – Student Grade System
            Console.Write("Enter student score (0-100)");
            int score = Convert.ToInt32(Console.ReadLine());

            if (score >= 90 && score <= 100)
            {
                Console.WriteLine("Excellent");
            }
            else if (score >= 75 && score <= 89)
            {
                Console.WriteLine("Very Good");
            }
            else if (score >= 60 && score <= 74)
            {
                Console.WriteLine("Good");
            }
            else if (score >= 50 && score <= 59)
            {
                Console.WriteLine("Pass");
            }
            else if (score >= 0 && score < 50)
            {
                Console.WriteLine("Fail");
            }
            else
            {
                Console.WriteLine("Invalid score. Please enter a value between 0 and 100");


            }

            //Task 4 – Simple Login System

            Console.Write("Enter username");
            string username = Console.ReadLine();

            Console.Write("Enter password");
            string password = Console.ReadLine();

            if (username == "admin" && password == "1234")
            {
                Console.WriteLine("Login Successful");
            }
            else
            {
                Console.WriteLine("Invalid Username or Password");
            }
            //Task 5 – Simple ATM System

            int balance = 1000;

            Console.Write("Enter withdrawal amount");
            int amount = Convert.ToInt32(Console.ReadLine());

            if (amount <= 0)
            {
                Console.WriteLine("Invalid Amount");
            }
            else if (amount > balance)
            {
                Console.WriteLine("Insufficient Balance");
            }
            else
            {
                balance -= amount;
                Console.WriteLine("Withdrawal Successful");
                Console.WriteLine("Remaining Balance" + balance);
            }






        }
    }
}
