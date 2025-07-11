namespace AsyncAwait
{
    internal class Program
    {
        static void Main()
        {
            var awaitClass = new AwaitClass();
            CancellationTokenSource cts = new CancellationTokenSource();

            try
            {
                Console.WriteLine("Starting asynchronous task 1");
                var task1 = awaitClass.Execute(1, 9, cts.Token);
                Console.WriteLine("");

                Console.WriteLine("Starting asynchronous task 2");
                var task2 = awaitClass.Execute(2, 4, cts.Token);
                Console.WriteLine("");

                Console.WriteLine("Starting asynchronous task 3");
                var task3 = awaitClass.Execute(3, 6, cts.Token);
                Console.WriteLine("");

                Task.WaitAll(task1, task2, task3);
                Console.WriteLine("All tasks completed successfully.");
            }
            catch (OperationCanceledException)
            {
                Console.WriteLine("Operation was canceled.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }
    }
}