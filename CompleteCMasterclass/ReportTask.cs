namespace CompleteCMasterclass;

internal class ReportTask : ITask<string>
{
    public string ReportName { get; set; } = string.Empty;

    public string Perform()
    {
        return $"Report '{ReportName}'";
    }
}
