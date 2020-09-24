using System;
using Flunt.Notifications;

namespace ClientApp.Domain.Entities
{
    public abstract class BaseEntity : Notifiable
    {
        public Guid Id { get; private set; }
        public DateTime? CreatedAt { get; set; }

        public BaseEntity()
        {
            Id = Guid.NewGuid();
        }
    }
}
