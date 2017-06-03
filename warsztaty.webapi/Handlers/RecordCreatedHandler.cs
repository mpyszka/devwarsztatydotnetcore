using System;
using System.Threading.Tasks;
using warsztaty.messages.Events;
using warsztaty.webapi.Storage;

namespace warsztaty.webapi.Handlers
{
    public class RecordCreatedHandler : IEventHandler<RecordCreated>
    {
        private readonly IStorage _storage;

        public RecordCreatedHandler(IStorage storage)
        {
            _storage = storage;
        }

        public async Task HandleAsync(RecordCreated @event)
        {
            Console.WriteLine($"Record: '{@event.Key}' was created");
            _storage.Add(@event.Key);
            await Task.CompletedTask;
        }
    }
}