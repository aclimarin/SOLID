namespace OCP.Solved;

public class Shipment
{
    private IShipping shipping;
    public Shipment(IShipping s)
    {
        shipping = s;
    }

    public void Calculate(double weight)
    {
        shipping.Calculate(weight);
    }
}