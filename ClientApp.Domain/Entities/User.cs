using ClientApp.Domain.ValueObjects;

namespace ClientApp.Domain.Entities
{
    public class User : BaseEntity
    {
        public Name Name { get; set; }
        public Email Email { get; set; }
        public CPF CPF { get; set; }
        public bool Active { get; set; }

        public User() { }

        public User(Name name, CPF cpf, Email email)
        {
            Name = name;
            CPF = cpf;
            Email = email;
        }

        public void UpdateName(Name name)
        {
            AddNotifications(name.Notifications);
            Name = name;
        }
    }
}