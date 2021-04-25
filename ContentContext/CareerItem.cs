namespace Course.ContentContext
{
    public class CareerItem
    {
        public CareerItem(int ordem, string title, string description, CourseOnline courseOnline)
        {

            if(courseOnline ==  null)
            throw new System.Exception("O curso não pode ser nullo");
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