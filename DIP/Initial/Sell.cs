namespace DIP.Initial;

public class Sell
{
    public Customer Customer { get; set; }
    public IList<Product> Products { get; set; } = new List<Product>();
    public double Total { get { return CalculateTotal(); } }

    private double CalculateTotal() {

        return Products.Sum(p => p.Price);
    }

    public void AddProduct(Product product)
    {
        Products.Add(product);

        Logger logger = new Logger();
        logger.log($"{product.Name} was added");
    }

    public void SendSellInformations()
    {
        Emailer messageSender = new Emailer();
        messageSender.Send(Customer, $"Total: { Total }");
    }
}