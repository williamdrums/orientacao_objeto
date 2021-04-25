using System;
using Course.SharedContext;

namespace Course.SubscriptionContext
{
    public class Subscription : Base
    {
        public Plain Plain { get; set; }

        public DateTime? EndDate { get; set; }

        
        public bool IsInactive => EndDate <= DateTime.Now; //vai estar inativo se o fim da assinatura for menor que a data de hoje
    }
}