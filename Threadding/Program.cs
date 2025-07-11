namespace Threadding
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine($"Thread Blocking");
            ThreadBlocking.Execute();
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("");
            Console.WriteLine($"Thread Starting");
            ThreadStarting.Execute();
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("");
            Console.WriteLine($"Thread Ending");
            ThreadEnding.Execute();
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("");
            Console.WriteLine($"Batch Threadding");
            ThreadBatchStart.Execute();
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("");
            Console.WriteLine($"Thread Pooling");
            var pooling = new ThreadPooling();
            pooling.Execute();
        }

    }
}