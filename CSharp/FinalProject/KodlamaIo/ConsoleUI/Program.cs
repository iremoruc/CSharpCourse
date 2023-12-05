using Business.Abstract;
using Business.Concrete;
using DataAccess.EntityFramework;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ICourseService _courseService = new CourseManager();
            var courses = _courseService.GetCoursesWithNames();

            

            courses!.ForEach(x =>
            {
                Console.WriteLine($"{x.CategoryId}  {x.Category!.CategoryName} {x.InstructorId} {x.InstructorId}");
            });       
        }
    }
}