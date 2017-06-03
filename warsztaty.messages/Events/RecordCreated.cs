namespace warsztaty.messages.Events
{
    public class RecordCreated : IEvent
    {
        public string Key { get; }

        public RecordCreated()
        {
        }

        public RecordCreated(string key)
        {
            Key = key;
        }
    }
}