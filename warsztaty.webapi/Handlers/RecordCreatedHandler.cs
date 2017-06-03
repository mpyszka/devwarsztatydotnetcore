using System;
using System.Threading.Tasks;
using warsztaty.messages.Events;

namespace warsztaty.webapi.Handlers
{
    public class RecordCreatedHandler : IEventHandler<RecordCreated>
    {
        public async Task HandleAsync(RecordCreated @event)
        {
            Console.WriteLine($"Record: '{@event.Key}' was created");
            await Task.CompletedTask;
        }
    }
}