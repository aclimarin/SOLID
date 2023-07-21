namespace DIP.Initial;

public class Emailer
{
    public void Send(Customer customer, string message)
    {
        Console.WriteLine($"Simulating seding e-mail to { customer.Email }");
        Console.WriteLine(message);
    }
}