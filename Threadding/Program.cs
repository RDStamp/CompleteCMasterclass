namespace Threadding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World 1!");
            Thread.Sleep(1000); 
            Console.WriteLine("Hello, World 2!");
            Thread.Sleep(1000); 
            Console.WriteLine("Hello, World 3!");
            Thread.Sleep(1000); 
            Console.WriteLine("Hello, World 4!");
        }
    }
}
