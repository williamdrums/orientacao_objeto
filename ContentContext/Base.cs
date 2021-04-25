using System;
using Course.NotificationContext;

namespace Course.ContentContext
{
    public abstract class Base : Notifiable
    {
        public Base()
        {
             //Guid globally unique identifier(Representa um identificador globalmente exclusivo)
            Id = Guid.NewGuid();
        }
       public Guid Id { get; set; }
    }
}