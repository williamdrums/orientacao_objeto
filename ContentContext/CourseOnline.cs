using System.Collections.Generic;
using Course.ContentContext.Enums;

namespace Course.ContentContext
{
    public class CourseOnline : Content
    {
         public CourseOnline(string title, string url)
        : base(title, url)
        {
            Modules = new List<Module>();
        }
        public string Tag { get; set; }

        public IList<Module> Modules { get; set; }

        public int DurationInMinutes { get; set; }

        public EcontentLevel Level { get; set; }
    }
}