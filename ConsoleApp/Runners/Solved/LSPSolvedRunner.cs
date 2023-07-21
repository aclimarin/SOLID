using LSP.Solved;

namespace Runners.Solved;

public class LSPSolvedRunner : IRunner
{
    public void Run()
    {
        Employee manager = new Manager();
        manager.FirstName = "Maria";
        manager.LasName = "Santos";
        manager.CalculatePerHourRate(3);

        BaseEmployee employee = new CEO();
        employee.FirstName = "José";
        employee.LasName = "Silva";
        //    employee.AssignManager(manager);
        employee.CalculatePerHourRate(4);


        Console.WriteLine($"{employee.FirstName}'s salary is {employee.Salary}/hour");
    }
}