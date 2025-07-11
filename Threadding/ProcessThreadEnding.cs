namespace Threadding;

internal class ProcessThreadEnding
{
    public void Execute(int id, int time)
    {
        var taskCompletion = new TaskCompletionSource<bool>();

        var thread = new Thread(() =>
        {
            Console.WriteLine($"S ====> Task Source thread {Thread.CurrentThread.ManagedThreadId} is running");
            Thread.Sleep(9000);
            taskCompletion.TrySetResult(true);
            Console.WriteLine($"E ======> Task Source thread {Thread.CurrentThread.ManagedThreadId} is done");
        });

        thread.Start();

        var task = taskCompletion.Task.Result;

        if (task)
        {
            Console.WriteLine($"Task Source thread {thread.ManagedThreadId} completed successfully.");
            return;
        }

        Console.WriteLine($"Task Source thread {thread.ManagedThreadId} failed to complete successfully.");
        return;
    }
}
