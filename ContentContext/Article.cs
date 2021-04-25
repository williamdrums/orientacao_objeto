using System.Collections.Generic;

namespace Course.ContentContext
{
    public class Article : Content
    {

        public IList<NotificationContext> Notifications { get; set; }
        public Article(string title, string url)
        : base(title, url)
        {

        }
    }
}