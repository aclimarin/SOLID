using LSP.Initial;

namespace Runners.Initial;

public class LSPInitialRunner : IRunner
{
    public void Run()
    {
        Employee manager = new Manager();
        manager.FirstName = "Maria";
        manager.LasName = "Santos";
        manager.CalculatePerHourRate(3);

        Employee employee = new Employee();
        employee.FirstName = "José";
        employee.LasName = "Silva";
        employee.AssignManager(manager);
        employee.CalculatePerHourRate(2);

        Console.WriteLine($"{employee.FirstName}'s assigned manager is {employee.Manager.FirstName}");
        Console.WriteLine($"{employee.FirstName}'s salary is {employee.Salary}/hour");
    }
}