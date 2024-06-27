namespace InheritanceLesson;

public class FileLogger : ILogger
{
    public void WriteLog()
    {
        Console.WriteLine("Veritabanına loglandı.");
    }
}