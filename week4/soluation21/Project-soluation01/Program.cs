namespace Project_soluation01
{
    internal class Program
    {
        #region interface

        
        interface bird
        {
            string Name { get; }
            public void Fly();
        }
        class hodhod : bird
        {
            public string Name { get; set; }
            public void Fly()
            {
                Console.WriteLine("Hello");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello");
#endregion


        }
    }
}
