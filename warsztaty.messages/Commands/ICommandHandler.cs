using System.Threading.Tasks;

namespace warsztaty.messages.Commands
{
    public interface ICommandHandler<T> where T:ICommand
    {
        Task HandleAsync(T command);
    }
}