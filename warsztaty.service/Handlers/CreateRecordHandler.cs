using System;
using System.Threading.Tasks;
using RawRabbit;
using warsztaty.messages.Commands;
using warsztaty.messages.Events;

namespace warsztaty.service.Handlers
{
    public class CreateRecordHandler : ICommandHandler<CreateRecord>
    {
        private readonly IBusClient _busClient;

        public CreateRecordHandler(IBusClient busClient)
        {
            _busClient = busClient;
        }

        public async Task HandleAsync(CreateRecord command)
        {
            Console.WriteLine($"Received create record '{command.Key}'");
            if (string.IsNullOrWhiteSpace(command.Key))
            {
                await _busClient.PublishAsync(new CreateRecordFailed(command.Key, "Key cannot be empty"));
                return;
            }

            await _busClient.PublishAsync(new RecordCreated(command.Key));
        }
    }
}