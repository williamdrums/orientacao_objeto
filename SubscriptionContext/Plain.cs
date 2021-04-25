using Course.SharedContext;

namespace Course.SubscriptionContext
{
    public class Plain : Base
    {
        public string Title { get; set; }
        public decimal Price { get; set; }
    }
}