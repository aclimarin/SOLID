using OCP.Solved;

namespace Runners.Solved;

public class OCPSolvedRunner : IRunner
{
    public void Run()
    {
        var weight = 50;
        Shipment normalShipping = new Shipment(new NormalShipping());
        normalShipping.Calculate(weight);

        Shipment expressShipping = new Shipment(new ExpressShipping());
        expressShipping.Calculate(weight);

        Shipment nextDayShipping = new Shipment(new NextDayShipping());
        nextDayShipping.Calculate(weight);
    }
}