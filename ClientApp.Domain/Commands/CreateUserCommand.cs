using ClientApp.Domain.Commands.Contracts;
using Flunt.Notifications;
using Flunt.Validations;

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
            AddNotifications(
                new Contract()
                    .Requires()
                    .HasMinLen(FirstName, 3, "FirstName", "Nome, deve conter no mínimo 3 caracteres")
                    .HasMaxLen(LastName, 40, "LastName", "Sobrenome, deve conter no máximo 40 caracteres")
                    .IsEmail(Email, "Email.Address", "Email inválido!")
                    .IsNotNullOrEmpty(CPF, "CPF.Number", "CPF nulo ou vazio")
            );
        }
    }
}