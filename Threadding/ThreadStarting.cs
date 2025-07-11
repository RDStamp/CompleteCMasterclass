namespace Threadding;

internal static class ThreadStarting
{
    public static void Execute()
    {
        // Forced Sequential
        Console.WriteLine($"Forced Sequential Start");
        ProcessThreadStart.Execute(11, 5000);
        ProcessThreadStart.Execute(12, 8000);
        ProcessThreadStart.Execute(13, 2000);
        ProcessThreadStart.Execute(14, 10000);


        // Async
        Console.WriteLine($"Async");
        Console.WriteLine("Manual thread 1 Start");
        new Thread(() =>
        {
            Console.WriteLine("S ====> Manual thread 1 is running");
            Thread.Sleep(5000);
            Console.WriteLine("E ======> Manual thread 1 is done");
        }).Start();
        Console.WriteLine("Manual thread 1 End");
        Console.WriteLine("");

        Console.WriteLine("Manual thread 2 Start");
        new Thread(() =>
        {
            Console.WriteLine("S ====> Manual thread 2 is running");
            Thread.Sleep(8000);
            Console.WriteLine("E ======> Manual thread 2 is done");
        }).Start();
        Console.WriteLine("Manual thread 2 End");
        Console.WriteLine("");

        Console.WriteLine("Manual thread 3 Start");
        new Thread(() =>
        {
            Console.WriteLine("S ====> Manual thread 3 is running");
            Thread.Sleep(2000);
            Console.WriteLine("E ======> Manual thread 3 is done");
        }).Start();
        Console.WriteLine("Manual thread 3 End");
        Console.WriteLine("");

        Console.WriteLine("Manual thread 4 Start");
        new Thread(() =>
        {
            Console.WriteLine("S ====> Manual thread 4 is running");
            Thread.Sleep(9000);
            Console.WriteLine("E ======> Manual thread 4 is done");
        }).Start();
        Console.WriteLine("Manual thread 4 End");
        Console.WriteLine("");
    }
}
