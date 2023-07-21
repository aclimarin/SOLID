namespace LSP.Initial;
public class CEO: Employee
{
    public override void CalculatePerHourRate(int rank)
    {
        var baseAmount = 150;
        Salary = baseAmount * rank;
    }

    public override void AssignManager(Employee manager)
    {
        throw new Exception("The CEO has no manager!");
    }

    public void GeneratePerformanceReview()
    {
        /*...*/
    }

    public void PromoteSomeone()
    {
        /*...*/
    }
}