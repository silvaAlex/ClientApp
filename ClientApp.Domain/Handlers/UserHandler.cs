using ClientApp.Domain.Commands;
using ClientApp.Domain.Commands.Contracts;
using ClientApp.Domain.Entities;
using ClientApp.Domain.Handlers.Contracts;
using ClientApp.Domain.Repositories;
using ClientApp.Domain.ValueObjects;
using Flunt.Notifications;

namespace ClientApp.Domain.Handlers
{
    public class UserHandler : Notifiable, IHandler<CreateUserCommand>
    {
        readonly IUserRepository _repository;

        public UserHandler(IUserRepository repository)
        {
            _repository = repository;
        }

        public ICommandResult Handle(CreateUserCommand command)
        {
            if (_repository.CPFExists(command.CPF))
            {
                AddNotification("CPF", "Este CPF já está em uso!");
                return null;
            }

            var name = new Name(command.FirstName, command.LastName);
            var cpf = new CPF(command.CPF);
            var email = new Email(command.Email);

            User user = new User(name, cpf, email);

            command.Validate();

            if (command.Invalid)
                return new CommandResult(false, "Erro ao criar o usuario", command.Notifications);

            _repository.Create(user);

            return new CommandResult(true, "Usuario criado com sucesso", user);
        }
    }
}