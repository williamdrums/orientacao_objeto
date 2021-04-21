using System;
using System.Collections.Generic;
using Course.ContentContext;

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

            var articles = new List<Article>();
            articles.Add(new Article("Artigo sobre OOP", "orientacao-objeto"));
            articles.Add(new Article("Artigo sobre C#", "csharp"));
            articles.Add(new Article("Artigo sobre .NET", "dotnet"));

            foreach (var article in articles)
            {
                Console.WriteLine(article.Id);
                Console.WriteLine(article.Title);
                Console.WriteLine(article.Url);
            }


        }
    }
}
