namespace Course.ContentContext
{
    public class CareerItem
    {
        public int Ordem { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public CourseOnline CourseOnline { get; set; }
    }
}