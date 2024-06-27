namespace InheritanceLesson;

public class SmsLogger : ILogger
{
    public void WriteLog()
    {
        Console.WriteLine("Sms gönderildi.");
    }
}