namespace DIP.Solved;

public interface IMessageSender
{
    void Send(ICustomer customer, string message);
}