namespace OCP.Initial;

public class ExpressShipping
{
    public void Calculate(double weight)
    {
        var shippingValue = weight * 7;
        Console.WriteLine($"The Express Shipping Value is {shippingValue}");
    }
}
