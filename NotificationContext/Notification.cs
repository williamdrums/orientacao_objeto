namespace Course.NotificationContext
{

    public sealed class Notification
    {
        public Notification()
        {

        }
        public Notification(string property, string message)
        {
            Property = property;
            this.Message = message;
        }

        public string Property { get; set; }

        public string Message { get; set; }
    }
}