namespace AsyncAwait;

internal interface IAwaitClass
{
    Task Execute(int id, int timer, CancellationToken token);
}
