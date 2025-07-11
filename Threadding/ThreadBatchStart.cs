namespace Threadding;

internal class ThreadBatchStart
{
    public static void Execute()
    {
        var rand = new Random();

        Enumerable.Range(1, 200).ToList().ForEach(id =>
        {
            Console.WriteLine($"Manual thread {id} Start");
            var sleeper = rand.Next(1, 10) * 1000; // Random sleep time between 1 and 10 seconds
            new Thread(() =>
            {
                Console.WriteLine($"S ====> Manual thread {id} is running");
                Thread.Sleep(sleeper);
                Console.WriteLine($"E ======> Manual thread {id} is done");
            }).Start();
            Console.WriteLine($"Manual thread {id} End");
            Console.WriteLine("");
        });
    }
}
