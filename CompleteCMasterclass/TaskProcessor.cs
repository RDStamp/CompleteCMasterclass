namespace CompleteCMasterclass;

internal class TaskProcessor<TTask, TResult>(TTask task) where TTask : ITask<TResult>
{
    private TTask _task { get; set; } = task;

    public TResult Execute {get => _task.Perform(); }   

}