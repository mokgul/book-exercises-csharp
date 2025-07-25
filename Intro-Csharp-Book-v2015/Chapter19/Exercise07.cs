namespace Chapter19;

public static class Exercise07
{
    public static void CheckSchedule()
    {
        var scheduler = new EventScheduler();

        scheduler.AddEvent(
            new DateTime(2025, 7, 25, 9, 0, 0),
            new DateTime(2025, 7, 25, 11, 0, 0),
            "Tech Conference"
        );

        scheduler.AddEvent(
            new DateTime(2025, 7, 25, 11, 30, 0),
            new DateTime(2025, 7, 25, 13, 0, 0),
            "Team Meeting"
        );

        Console.WriteLine("Schedule:");
        scheduler.PrintSchedule();

        var checkStart = new DateTime(2025, 7, 25, 10, 0, 0);
        var checkEnd = new DateTime(2025, 7, 25, 11, 30, 0);
        Console.WriteLine($"\nIs available from {checkStart} to {checkEnd}? {scheduler.IsAvailable(checkStart, checkEnd)}");
    }
    
    public class Event
    {
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public string Name { get; set; }

        public Event(DateTime start, DateTime end, string name)
        {
            Start = start;
            End = end;
            Name = name;
        }

        public override string ToString()
        {
            return $"{Start} - {End}: {Name}";
        }
    }

    public class EventScheduler
    {
        private List<Event> events;

        public EventScheduler()
        {
            events = new List<Event>();
        }

        public bool IsAvailable(DateTime start, DateTime end)
        {
            foreach (var e in events)
            {
                if (start < e.End && end > e.Start)
                {
                    // Overlap
                    return false;
                }
            }
            return true;
        }

        public bool AddEvent(DateTime start, DateTime end, string name)
        {
            if (IsAvailable(start, end))
            {
                events.Add(new Event(start, end, name));
                return true;
            }
            return false;
        }

        public void PrintSchedule()
        {
            events.Sort((a, b) => a.Start.CompareTo(b.Start));
            foreach (var e in events)
            {
                Console.WriteLine(e);
            }
        }
    }
}