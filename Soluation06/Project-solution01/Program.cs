namespace Project_solution01
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //#region array numbers
            //int[] numbers = new int[5];
            //for (int i = 0; i < numbers.Length; i++)
            //{

            //    Console.WriteLine("Enter Any number");
            //    numbers[i] = Convert.ToInt32(Console.ReadLine());
            //}

            //foreach (int i in numbers)
            //{
            //    Console.WriteLine(i);
            //}

            //#endregion


            //#region ARRay string

            //string[] words = new string[5];

            //for (int i = 0; i < words.Length; i++)
            //{
            //    Console.WriteLine("Enter any word");
            //    words[i] = Console.ReadLine();
            //}

            //foreach (string w in words)
            //{
            //    Console.WriteLine(w);
            //}
            //#endregion
            //#region MyRegion

            //#endregion


            //#region Task1 array

            //int[] numbers = new int[5];

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine("Enter any number ");
            //    numbers[i] = Convert.ToInt32(Console.ReadLine());
            //}


            //Console.WriteLine("The numbers");

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}
            //#endregion

            //#region Task 2foreach


            //int[] numbers = { 10, 20, 30, 40, 50 };


            //foreach (int num in numbers)
            //{
            //    Console.WriteLine(num);
            //}
            //#endregion

            //#region تمرين3

            //int[] numbers = new int[5];


            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.Write("Enter number ");
            //    numbers[i] = Convert.ToInt32(Console.ReadLine());
            //}


            //Console.WriteLine("The numbers you entered are");

            //foreach (int num in numbers)
            //{
            //    Console.WriteLine(num);
            //}





            //    #endregion


            //    #region تمرين4

            //    int[] numbers = new int[5];
            //    int sum = 0;


            //    for (int i = 0; i < numbers.Length; i++)
            //    {
            //        Console.Write("Enter number");
            //        numbers[i] = Convert.ToInt32(Console.ReadLine());
            //    }


            //    for (int i = 0; i < numbers.Length; i++)
            //    {
            //        sum += numbers[i];
            //    }


            //    Console.WriteLine("Sum = " + sum);
            //}




            //    #endregion

            //#region تمرين 5

            //int[] x = new int[5];


            //    for (int i = 0; i<x.Length; i++)
            //    {
            //        Console.Write("Enter number");
            //        x[i] = Convert.ToInt32(Console.ReadLine());
            //    }


            //    int max = x[0];


            //    for (int i = 1; i<x.Length; i++)
            //    {
            //        if (x[i] > max)
            //        {
            //            max = x[i];
            //        }
            //    }



            //    Console.WriteLine("max= " + max);


            //        #endregion


            //#region تمرين 6

            //int[] x = new int[5];


            //for (int i = 0; i < x.Length; i++)
            //{
            //    Console.Write("Enter number");
            //    x[i] = Convert.ToInt32(Console.ReadLine());
            //}


            //int min = x[0];


            //for (int i = 1; i < x.Length; i++)
            //{
            //    if (x[i] < min)
            //    {
            //        min = x[i];
            //    }
            //}


            //Console.WriteLine("min= " + min);




            //#endregion

            //#region تمرين 7


            //int[] numbers = new int[10];


            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.Write("Enter number");
            //    numbers[i] = Convert.ToInt32(Console.ReadLine());
            //}


            //Console.WriteLine("Even numbers");

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 2 == 0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}

            //#endregion

            //#region تمرين8


            //int[] x = new int[5];
            //int sum = 0;


            //for (int i = 0; i < x.Length; i++)
            //{
            //    Console.Write("Enter number");
            //    x[i] = Convert.ToInt32(Console.ReadLine());
            //}


            //for (int i = 0; i < x.Length; i++)
            //{
            //    sum += x[i];
            //}


            //double average = (double)sum / x.Length;


            //Console.WriteLine("Average = " + average);



            //#endregion

            //#region تمرين9

            //int[] numbers = new int[5];


            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.Write("Enter number ");
            //    numbers[i] = Convert.ToInt32(Console.ReadLine());
            //}


            //Array.Reverse(numbers);


            //Console.WriteLine("Reversed array");

            //foreach (int num in numbers)
            //{
            //    Console.WriteLine(num);
            //}


            //#endregion

            #region تمرين10
            int[] numbers = { 10, 20, 30, 40, 50 };

            Console.Write("Enter number");
            int x = Convert.ToInt32(Console.ReadLine());

            bool found = false;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == x)
                {
                    Console.WriteLine("Number found at index " + i);
                    found = true;
                    break;
                }
            }

            if (!found)
            {
                Console.WriteLine("Number not found");
            }



            #endregion


        }


    }
            }

