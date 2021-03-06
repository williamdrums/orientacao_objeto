using System;
using System.Collections.Generic;
using System.Linq;
using Course.ContentContext;
using Course.SubscriptionContext;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello");
            // var course = new CourseOnline();
            // course.Level = ContentContext.Enums.EcontentLevel.Beginner;

            // var career = new Career();
            // career.Items.Add(new CareerItem());
            //  Console.WriteLine(career.TotalCourses);

            // var articles = new List<Article>();
            // articles.Add(new Article("Artigo sobre OOP", "orientacao-objeto"));
            // articles.Add(new Article("Artigo sobre C#", "csharp"));
            // articles.Add(new Article("Artigo sobre .NET", "dotnet"));


            var courses = new List<CourseOnline>();
            var courseOOP = new CourseOnline("Fundamentos OOP", "fundamentos-oop");
            var courseCsharp = new CourseOnline("Fundamentos C#", "fundamentos-csharp");
            var courseAspNet = new CourseOnline("Fundamentos ASP.NET", "fundamentos-aspnet");

            courses.Add(courseOOP);
            courses.Add(courseCsharp);
            courses.Add(courseAspNet);

            var careers = new List<Career>();
            var careerDotNet = new Career("Especialista .NET", "especialista-dotnet");
            var careerItem2 = new CareerItem(2, "Aprenda OOP", "", null);
            var careerItem1 = new CareerItem(1, "Comece aqui", "", courseCsharp);
            var careerItem3 = new CareerItem(3, "Aprenda .NET", "", courseAspNet);

            careerDotNet.Items.Add(careerItem2);
            careerDotNet.Items.Add(careerItem3);
            careerDotNet.Items.Add(careerItem1);
            careers.Add(careerDotNet);




            foreach (var career in careers)
            {
                Console.WriteLine(career.Title);

                foreach (var item in career.Items.OrderBy(x => x.Ordem))
                {
                    Console.WriteLine($"{item.Ordem} - {item.Title}");
                    Console.WriteLine(item.CourseOnline?.Title);
                    Console.WriteLine(item.CourseOnline?.Level);

                    foreach (var notification in item.Notifications)
                    {
                        Console.WriteLine($"{notification.Property} - {notification.Message}");
                    }
                }
            }

            var payPalSubscription = new PayPalSubscription();
            var student = new Student();

            student.CreateSubscription(payPalSubscription);


            // foreach (var article in articles)
            // {
            //     Console.WriteLine(article.Id);
            //     Console.WriteLine(article.Title);
            //     Console.WriteLine(article.Url);
            // }
        }
    }
}
