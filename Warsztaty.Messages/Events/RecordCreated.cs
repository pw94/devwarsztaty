namespace Warsztaty.Messages.Events
{
    public class RecordCreated : IEvent
    {
        public string Key { get; set; }

        protected RecordCreated ()
        {
        }

        public RecordCreated(string key)
        {
            Key = key;
        }
    }
}