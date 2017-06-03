using System;
using System.Threading.Tasks;
using Warsztaty.Api.Storage;
using Warsztaty.Messages.Events;

namespace Warsztaty.Api.Handlers
{
    public class RecordCreatedHandler : IEventHandler<RecordCreated>
    {
        private readonly IStorage storage;
        public RecordCreatedHandler(IStorage storage)
        {
            this.storage = storage;
        }

        public async Task HandleAsync(RecordCreated @event)
        {
            Console.WriteLine($"Record: '{@event.Key}' was created.");
            storage.Add(@event.Key);
            await Task.CompletedTask;
        }
    }
}