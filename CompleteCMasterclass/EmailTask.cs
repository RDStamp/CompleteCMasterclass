namespace CompleteCMasterclass;

internal class EmailTask : ITask<string>
{
    public string Recipient { get; set; } = string.Empty;
    public string Message { get; set; } = string.Empty;
    public string Perform()
    {
        return $"Email sent to {Recipient} with message: {Message}";
    }
}
