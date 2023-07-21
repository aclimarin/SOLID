namespace DIP.Solved;

public class TextMessange: IMessageSender
{
    public void Send(ICustomer customer, string message)
    {
        Console.WriteLine($"Simulating seding text message to { customer.PhoneNumber }");
        Console.WriteLine(message);
    }
}