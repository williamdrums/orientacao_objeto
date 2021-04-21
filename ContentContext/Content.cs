using System;

namespace Course.ContentContext
{
    public class Content
    {
        public Content()
        {
            //Guid globally unique identifier(Representa um identificador globalmente exclusivo)
            Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }

        public string Title { get; set; }

        public string Url { get; set; }
    }
}