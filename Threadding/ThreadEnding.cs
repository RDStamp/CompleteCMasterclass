namespace Threadding;

internal class ThreadEnding
{
    public static void Execute()
    {
        var taskCompletion1 = new TaskCompletionSource<bool>();
        var taskCompletion2 = new TaskCompletionSource<bool>();
        var taskCompletion3 = new TaskCompletionSource<bool>();

        var thread1 = new Thread(() =>
        {
            Console.WriteLine($"S ====> Task Source thread {Thread.CurrentThread.ManagedThreadId} is running");
            Thread.Sleep(9000);
            taskCompletion1.TrySetResult(true);
            Console.WriteLine($"E ======> Task Source thread {Thread.CurrentThread.ManagedThreadId} is done");
        });

        var thread2 = new Thread(() =>
        {
            Console.WriteLine($"S ====> Task Source thread {Thread.CurrentThread.ManagedThreadId} is running");
            Thread.Sleep(5000);
            taskCompletion2.TrySetResult(true);
            Console.WriteLine($"E ======> Task Source thread {Thread.CurrentThread.ManagedThreadId} is done");
        });

        var thread3 = new Thread(() =>
        {
            Console.WriteLine($"S ====> Task Source thread {Thread.CurrentThread.ManagedThreadId} is running");
            Thread.Sleep(1000);
            taskCompletion3.TrySetResult(true);
            Console.WriteLine($"E ======> Task Source thread {Thread.CurrentThread.ManagedThreadId} is done");
        });

        thread1.Start();
        thread2.Start();
        thread3.Start();

        var task1 = taskCompletion1.Task.Result;
        var task2 = taskCompletion2.Task.Result;
        var task3 = taskCompletion3.Task.Result;

        if (task1)
        {
            Console.WriteLine($"Task Source thread {thread1.ManagedThreadId} completed successfully.");
        }

        if (task2)
        {
            Console.WriteLine($"Task Source thread {thread2.ManagedThreadId} completed successfully.");
        }

        if (task3)
        {
            Console.WriteLine($"Task Source thread {thread3.ManagedThreadId} completed successfully.");
        }


    }
}