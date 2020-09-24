using ClientApp.Domain.Commands.Contracts;
using Flunt.Notifications;

namespace ClientApp.Domain.Commands
{
    public class CreateUserCommand : Notifiable, ICommand
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CPF { get; set; }
        public string Email { get; set; }

        public void Validate()
        {
            throw new System.NotImplementedException();
        }
    }
}