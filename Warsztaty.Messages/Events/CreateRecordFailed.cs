namespace Warsztaty.Messages.Events
{
    public class CreateRecordFailed : IEvent
    {
        public string Key { get; set; }
        public string Reason { get; set; }

        protected CreateRecordFailed ()
        {
        }

        public CreateRecordFailed(string key, string reason)
        {
            Key = key;
            Reason = reason;
        }
    }
}