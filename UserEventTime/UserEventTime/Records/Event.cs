using UserEventTime.Structs;

namespace UserEventTime.Records
{
    public record Event
    {
        public string Title { get; set; }
        public EventTime Time { get; set; }
        public DateTime CreatedAt { get; set; }

        public Event(string title, EventTime time, DateTime createdAt )
        {
            Title = title;
            Time = time;
            CreatedAt = createdAt;
        }
    }
}
