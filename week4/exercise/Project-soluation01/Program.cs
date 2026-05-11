namespace Project_soluation01
{
    #region async

    
    internal class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Hello before method");
            string num = await GetNumber();
            Console.WriteLine(num);
            Console.WriteLine("Hello after method");
        }

        static async Task<string> GetNumber()
        {
            await Task.Delay(2000);
            return "Hello from async method";

#endregion
        }
    }
}
