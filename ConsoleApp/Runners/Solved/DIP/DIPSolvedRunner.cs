using DIP.Solved;

namespace Runners.Solved;

public class DIPSolvedRunner : IRunner
{
    public void Run()
    {
        ICustomer customer = Factory.CreateCustomer();
        customer.Name = "Maria";
        customer.Email = "maria@email.com";
        customer.PhoneNumber = "99999-8246";

        IProduct notebook = Factory.CreateProduct();
        notebook.Name = "Notebook";
        notebook.Price = 1;

        IProduct pen = Factory.CreateProduct();
        pen.Name = "Pen";
        pen.Price = 5;

        ISell sell = Factory.CreateSell();
        sell.Customer = customer;
    }
}