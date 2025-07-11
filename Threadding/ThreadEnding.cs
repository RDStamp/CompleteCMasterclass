namespace Threadding;

internal class ThreadEnding
{
    public static void Execute()
    {
        // Forced Sequential
        Console.WriteLine($"Forced Sequential");
        var processThreadEnding1 = new ProcessThreadEnding();
        var processThreadEnding2 = new ProcessThreadEnding();
        var processThreadEnding3 = new ProcessThreadEnding();
        var processThreadEnding4 = new ProcessThreadEnding();

        processThreadEnding1.Execute(1, 9000);
        processThreadEnding1.Execute(2, 5000);
        processThreadEnding1.Execute(3, 1000);
        processThreadEnding1.Execute(4, 10000);

        // Async
        Console.WriteLine($"Async");
        var taskCompletion1 = new TaskCompletionSource<bool>();
        var taskCompletion2 = new TaskCompletionSource<bool>();
        var taskCompletion3 = new TaskCompletionSource<bool>();
        var taskCompletion4 = new TaskCompletionSource<bool>();

        var thread1 = new Thread(() =>
        {
            Console.WriteLine($"S ====> Task Source thread {Thread.CurrentThread.ManagedThreadId} is running");
            Thread.Sleep(2000);
            taskCompletion1.TrySetResult(true);
            Console.WriteLine($"E ======> Task Source thread {Thread.CurrentThread.ManagedThreadId} is done");
        });

        var thread2 = new Thread(() =>
        {
            Console.WriteLine($"S ====> Task Source thread {Thread.CurrentThread.ManagedThreadId} is running");
            Thread.Sleep(6000);
            taskCompletion2.TrySetResult(true);
            Console.WriteLine($"E ======> Task Source thread {Thread.CurrentThread.ManagedThreadId} is done");
        });

        var thread3 = new Thread(() =>
        {
            Console.WriteLine($"S ====> Task Source thread {Thread.CurrentThread.ManagedThreadId} is running");
            Thread.Sleep(7000);
            taskCompletion3.TrySetResult(true);
            Console.WriteLine($"E ======> Task Source thread {Thread.CurrentThread.ManagedThreadId} is done");
        });


        var thread4 = new Thread(() =>
        {
            Console.WriteLine($"S ====> Task Source thread {Thread.CurrentThread.ManagedThreadId} is running");
            Thread.Sleep(1000);
            taskCompletion3.TrySetResult(true);
            Console.WriteLine($"E ======> Task Source thread {Thread.CurrentThread.ManagedThreadId} is done");
        });

        thread1.Start();
        thread2.Start();
        thread3.Start();
        thread4.Start();

        var task1 = taskCompletion1.Task.Result;
        var task2 = taskCompletion2.Task.Result;
        var task3 = taskCompletion3.Task.Result;
        var task4 = taskCompletion4.Task.Result;

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

        if (task4)
        {
            Console.WriteLine($"Task Source thread {thread4.ManagedThreadId} completed successfully.");
        }


    }
}