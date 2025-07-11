namespace Threadding;

internal class ThreadPooling
{
    public void Execute()
    {
        var rand = new Random();

        Enumerable.Range(1, 200).ToList().ForEach(id =>
        {
            var sleeper = rand.Next(1, 10) * 1000; // Random sleep time between 1 and 10 seconds
            Console.WriteLine($"ThreadPool thread {id}: {Thread.CurrentThread.ManagedThreadId} is running for {sleeper} seconds");
            ThreadPool.QueueUserWorkItem((o) =>
            {
                Console.WriteLine($"S ====> ThreadPool thread {Thread.CurrentThread.ManagedThreadId} is running");
                Thread.Sleep(sleeper);
                Console.WriteLine($"E ======> ThreadPool thread {Thread.CurrentThread.ManagedThreadId} is done");
            });
        });
    }
}
