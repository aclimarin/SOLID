namespace OCP.Initial;

public class Shipment
{
    private ShippingType type;

    public Shipment(ShippingType t)
    {
        type = t;
    }

    public void Calculate(double weight)
    {
        if (type == ShippingType.Normal)
            new NormalShipping().Calculate(weight);
        else if (type == ShippingType.Express)
            new ExpressShipping().Calculate(weight);
        else if (type == ShippingType.NextDay)
            new NextDayShipping().Calculate(weight);
    }
}