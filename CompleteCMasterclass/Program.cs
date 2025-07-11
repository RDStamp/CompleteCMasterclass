namespace CompleteCMasterclass;

internal class Program
{
    static void Main(string[] args)
    {
        var emailTask = new EmailTask
        {
            Recipient = "someone@example.com",
            Message = "Hello, this is a test email."
        };

        var reportTask = new ReportTask
        {
            ReportName = "Monthly Sales Report"
        };

        var emailProcessor = new TaskProcessor<EmailTask, string>(emailTask);
        var reportProcessor = new TaskProcessor<ReportTask, string>(reportTask);

        var emailResult = emailProcessor.Execute;
        var reportResult = reportProcessor.Execute;

        Console.WriteLine(emailResult);
        Console.WriteLine(reportResult);
    }
}