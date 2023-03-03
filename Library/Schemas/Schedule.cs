using System.ComponentModel.DataAnnotations;

namespace Library.Schemas
{
    public class Schedule
    {
        public Schedule()
        {
            IdSchedule = Guid.NewGuid();
        }

        public Schedule(string name)
        {
            IdSchedule = Guid.NewGuid();
            Name = name;
        }

        public Guid IdSchedule { get; set; }

        [Required]
        public string Name { get; set; }
        public List<ClockingAction> Clockings { get; set; } = new List<ClockingAction>();

        [Range(1, int.MaxValue)]
        public int MinutesVariation { get; set; } = 1;
    }

    public class ClockingAction
    {
        public Guid IdClocking { get; set; }
        public TimeOnly ScheduledTime { get; set; }
        public int Action { get; set; }
    }
}
