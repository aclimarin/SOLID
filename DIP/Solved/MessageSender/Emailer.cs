namespace DIP.Solved;

public class Emailer: IMessageSender
{
    public void Send(ICustomer customer, string message)
    {
        Console.WriteLine($"Simulating seding e-mail to { customer.Email }");
        Console.WriteLine(message);
    }
}