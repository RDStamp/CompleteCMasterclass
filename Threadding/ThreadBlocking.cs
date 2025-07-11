namespace Threadding;

internal static class ThreadBlocking
{
    public static void Execute()
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
