namespace OCP.Solved;

public class NextDayShipping: IShipping
{
    public void Calculate(double weight)
    {
        var shippingValue = weight * 20;
        Console.WriteLine($"The 24/hour Shipping Value is {shippingValue}");
    }
} 