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
        public List<Clocking> Clockings { get; set; }
    }
}
