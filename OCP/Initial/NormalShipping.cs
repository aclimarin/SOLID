namespace OCP.Initial;

public class NormalShipping
{
    public void Calculate(double weight)
    {
        var shippingValue = weight * 3;
        Console.WriteLine($"The Normal Shipping Value is {shippingValue}");
    }
}