using SRP.Initial;

namespace Runners.Initial;

public class SRPInitialRunner : IRunner
{
    public void Run()
    {
        Course course = new Course()
        {
            CourseName = "Programming",
            DurantionInMonths = 3,
        };
        
        Student student = new Student()
        {
            FirstName = "Maria",
            LastName = "Silva",
            RegistrationNumber = 123456,
            Course = course
        };

        student.RegisterInCourse();
    }
}