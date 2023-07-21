namespace SRP.Solved;

public class CourseRegister
{
    public void RegisterInCourse(Student student)
    {
        Console.WriteLine($"{ student.FirstName } { student.LastName } was registered in { student.Course.CourseName }");
    }
}