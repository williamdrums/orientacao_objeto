namespace Course.NotificationContext
{

    public sealed class NotificationContext
    {
        public NotificationContext()
        {

        }
        public NotificationContext(string property, string message)
        {
            Property = property;
            this.message = message;
        }

        public string Property { get; set; }

        public string message { get; set; }
    }
}