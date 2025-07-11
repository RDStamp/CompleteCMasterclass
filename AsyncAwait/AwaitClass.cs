namespace AsyncAwait;

internal class AwaitClass : IAwaitClass
{
    public async Task Execute(int id, int timer, CancellationToken token)
    {
        Console.WriteLine($"Executing task {id} with timer {timer} seconds.");
        await Task.Delay(timer * 1000, token);
        Console.WriteLine($"Task {id} with timer {timer} seconds complete.");
    }
}
