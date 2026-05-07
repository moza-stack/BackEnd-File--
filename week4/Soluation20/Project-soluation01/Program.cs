


#region virtual


namespace Project_soluation01

{
    internal class Program
    {

        class Parent
        {

            public void ShowMessage()
            {
                Console.WriteLine("Message from Parent");
            }


            public virtual void PrintName()
            {
                Console.WriteLine("Parent Name");
            }


            public virtual void PrintAge()
            {
                Console.WriteLine("Parent Age");
            }
        }

        class Child : Parent
        {

            public override void PrintName()
            {
                Console.WriteLine("Child Name");
            }

            // Override virtual function 2
            public override void PrintAge()
            {
                Console.WriteLine("Child Age");
            }
        }



        static void Main(string[] args)
        {
            Child obj = new Child();


            obj.ShowMessage();
            obj.PrintName();
            obj.PrintAge();
#endregion

        }
    }
}
