namespace LSP.Solved;
public class Manager: Employee, IManager
{
    public override void CalculatePerHourRate(int rank)
    {
        var baseAmount = 19.75;
        Salary = baseAmount + (rank * 4);
    }

    public void GeneratePerformanceReview()
    {
        /*...*/
    }
}