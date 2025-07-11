namespace Threadding;

internal static class ProcessThreadStart
{
    public static void Execute (int id, int time)
    {
        Console.WriteLine($"Manual thread {id} Start");
        new Thread(() =>
        {
            Console.WriteLine($"S ====> Manual thread {id} is running");
            Thread.Sleep(time);
            Console.WriteLine($"E ======> Manual thread {id} is done");
        }).Start();
        Console.WriteLine($"Manual thread {id} End");
        Console.WriteLine("");
    }
}
