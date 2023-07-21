namespace OCP.Solved;

public class NormalShipping: IShipping
{
    public void Calculate(double weight)
    {
        var shippingValue = weight * 3;
        Console.WriteLine($"The Normal Shipping Value is {shippingValue}");
    }
}