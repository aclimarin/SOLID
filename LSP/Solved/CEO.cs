namespace LSP.Solved;
public class CEO: BaseEmployee, IManager
{
    /// <summary>
    /// Rank must be bigger than 3 /
    /// Salary will aways be bigger than 20/hour
    /// </summary>
    public override void CalculatePerHourRate(int rank)
    {
        //Preconditions of a base classe must be stronger than the subclass
        //Base classe will garantee that rank is bigger than 5
        //Therefore, the base class condition will satisfy the condition bellow
        if (rank <= 3)
            throw new Exception("Rank must be bigger than 3!");

        var baseAmount = 150;
        Salary = baseAmount * rank;

        //Postconditions of a base class must be weaker than the subclass
        //The base class garantee that Salary will aways be bigger than 15/hour
        //This post condition garantee the salary will aways be bigger than 20/hour
        //This wont brake because 20 > 15
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