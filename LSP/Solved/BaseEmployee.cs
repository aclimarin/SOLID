namespace LSP.Solved;

public abstract class BaseEmployee : IEmployee
{
    public string FirstName { get; set; }
    public string LasName { get; set; }
    public double Salary { get; set; }

    
    /// <summary>
    /// Rank must be bigger than 5 /
    /// Salary will aways be bigger than 15/hour
    /// </summary>
    public virtual void CalculatePerHourRate(int rank)
    {
        //Preconditions are stronger than the subclass
        if (rank <= 5)
            throw new Exception("Rank must be bigger than 5!");

        var baseAmount = 12.50;
        Salary = baseAmount + (rank * 2);
    }
}