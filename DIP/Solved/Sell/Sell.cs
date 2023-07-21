namespace DIP.Solved;

public class Sell: ISell
{

    private ILogger _logger;
    private IMessageSender _messageSender;

    public ICustomer Customer { get; set; }
    public IList<IProduct> Products { get; set; } = new List<IProduct>();
    public double Total { get { return CalculateTotal(); } }

    public Sell(ILogger logger, IMessageSender messageSender)
    {
        _logger = logger;
        _messageSender = messageSender;
    }

    private double CalculateTotal() {

        return Products.Sum(p => p.Price);
    }

    public void AddProduct(IProduct product)
    {
        Products.Add(product);

        Logger logger = new Logger();
        logger.log($"{product.Name} was added");
    }

    public void SendSellInformations()
    {        
        _messageSender.Send(Customer, $"Total: { Total }");
    }
}