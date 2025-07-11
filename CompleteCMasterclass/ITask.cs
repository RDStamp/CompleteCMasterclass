namespace CompleteCMasterclass;

internal interface ITask<TResult>
{
    internal TResult Perform();
}
