namespace DIP.Solved;

public class Logger: ILogger
{
    public void log(string message)
    {
        Console.WriteLine($"LOG: { message }");
    }
}