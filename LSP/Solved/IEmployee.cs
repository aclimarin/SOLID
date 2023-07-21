namespace LSP.Solved;

public interface IEmployee
{
    public string FirstName { get; set; }
    public string LasName { get; set; }
    public double Salary { get; set; }

    void CalculatePerHourRate(int rank);
}