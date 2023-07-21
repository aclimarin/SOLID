namespace DIP.Solved;

public interface ISell
{
    ICustomer Customer { get; set; }
    IList<IProduct> Products { get; set; }
    double Total { get; }

    void AddProduct(IProduct product);

    void SendSellInformations();
}