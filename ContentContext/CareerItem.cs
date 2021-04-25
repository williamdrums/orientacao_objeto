using Course.NotificationContext;
using Course.SharedContext;

namespace Course.ContentContext
{
    public class CareerItem : Base
    {
        public CareerItem(int ordem, string title, string description, CourseOnline courseOnline)
        {

            if(courseOnline ==  null)
            AddNotification(new Notification("Course","Curso invalido"));

            Ordem = ordem;
            Title = title;
            Description = description;
            CourseOnline = courseOnline;
        }

        public int Ordem { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public CourseOnline CourseOnline { get; set; }
    }
}