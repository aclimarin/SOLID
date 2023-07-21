namespace DIP.Solved;

public static class Factory
{
    public static ICustomer CreateCustomer()
    {
        return new Customer();
    }

    public static ISell CreateSell()
    {
        return new Sell(CreateLogger(), CreateMessageSender());
    }

    public static IProduct CreateProduct()
    {
        return new Product();
    }

    public static IMessageSender CreateMessageSender()
    {
        return new TextMessange();
    }
    public static ILogger CreateLogger()
    {
        return new Logger();
    }
}