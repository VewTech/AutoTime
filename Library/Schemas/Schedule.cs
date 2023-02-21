namespace Library.Schemas
{
    public class Schedule
    {
        public Schedule(string name)
        {
            IdSchedule = Guid.NewGuid();
            Name = name;
        }

        public Guid IdSchedule { get; set; }
        public string Name { get; set; }
        public List<ClockingAction> Clockings { get; set; } = new List<ClockingAction>();
    }

    public class ClockingAction
    {
        public Guid IdClocking { get; set; }
        public TimeOnly ScheduledTime { get; set; }
        public int Action { get; set; }
    }
}
