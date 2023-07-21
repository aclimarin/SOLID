using SRP.Solved;

namespace Runners.Solved;

public class SRPSolvedRunner : IRunner
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
            StudentId = 1,
            FirstName = "Maria",
            LastName = "Silva",
            Registration = 123456,
            Course = course
        };

        CourseRegister courseRegister = new CourseRegister();
        courseRegister.RegisterInCourse(student);
    }
}