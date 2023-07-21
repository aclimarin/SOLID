namespace LSP.Initial;
public class Employee
{
    public string FirstName { get; set; }
    public string LasName { get; set; }
    public Employee Manager { get; set; } = null;
    public double Salary { get; set; }

    public virtual void AssignManager(Employee manager)
    {
        Manager = manager;
    }

    public virtual void CalculatePerHourRate(int rank)
    {
        var baseAmount = 12.50;
        Salary = baseAmount + (rank * 2);
    }
}