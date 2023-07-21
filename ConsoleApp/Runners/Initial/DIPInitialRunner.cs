using DIP.Initial;

namespace Runners.Initial;

public class DIPInitialRunner : IRunner
{
    public void Run()
    {
        Customer customer = new Customer()
        {
            Name = "Maria",
            Email = "maria@email.com",
            PhoneNumber = "99999-8246"
        };

        Product notebook = new Product()
        {
            Name = "Notebook",
            Price = 15
        };

        Product pen = new Product()
        {
            Name = "Pen",
            Price = 5
        };

        Sell sell = new Sell()
        {
            Customer = customer
        };

        sell.AddProduct(notebook);
        sell.AddProduct(pen);
        sell.SendSellInformations();
    }
}