using ClientApp.Domain.Commands.Contracts;

namespace ClientApp.Domain.Commands
{
    public class CommandResult : ICommandResult
    {
        public bool Success { get; set; }
        public string Message { get; set; }
        public object Data { get; set; }
        public CommandResult() { }

        public CommandResult(bool success, string message)
        {
            Success = success;
            Message = message;
        }

        public CommandResult(bool success, string message, object data)
        {
            Success = success;
            Message = message;
            Data = data;
        }

    }
}