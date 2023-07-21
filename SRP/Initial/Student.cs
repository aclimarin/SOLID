namespace SRP.Initial;

public class Student
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int RegistrationNumber { get; set; }
    public Course Course { get; set; }

    public void RegisterInCourse()
    {
        Console.WriteLine($"{ FirstName } { LastName } was registered in { Course.CourseName }");
    }

    public void SaveInFile()
    {
        Console.WriteLine($"Student saved in file!");
    }
}