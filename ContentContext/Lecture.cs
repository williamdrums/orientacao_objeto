using Course.ContentContext.Enums;

namespace Course.ContentContext
{
    //Aulas 
    public class Lecture
    {
        public int Order { get; set; }
        public string Title { get; set; }

        public int DurationInMinutes { get; set; }

        public EcontentLevel Level { get; set; }
    }
}