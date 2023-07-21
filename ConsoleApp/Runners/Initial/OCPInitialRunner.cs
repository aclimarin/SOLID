using OCP.Initial;

namespace Runners.Initial;

public class OCPInitialRunner : IRunner
{
    public void Run()
    {
        var weight = 50;
        Shipment normalShipping = new Shipment(ShippingType.Normal);
        normalShipping.Calculate(weight);
        
        Shipment expressShipping = new Shipment(ShippingType.Express);
        expressShipping.Calculate(weight);

        Shipment nextDay = new Shipment(ShippingType.NextDay);
        nextDay.Calculate(weight);
    }
}