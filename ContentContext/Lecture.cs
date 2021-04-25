using Course.ContentContext.Enums;

namespace Course.ContentContext
{
    //Aulas 
    public class Lecture : Base
    {
        public int Order { get; set; }
        public string Title { get; set; }

        public int DurationInMinutes { get; set; }

        public EcontentLevel Level { get; set; }
    }
}