using System;
using Course.ContentContext;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello");
            var course = new CourseOnline();
            course.Level = ContentContext.Enums.EcontentLevel.Beginner;
        }
    }
}
