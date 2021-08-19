using System;

namespace Domain
{
    public class ScheduleWork
    {
        public Schedule Schedule { get; set; }
        public string ScheduleId { get; set; }
        public Work Work { get; set; }
        public Guid WorkId { get; set; }
        public int Score { get; set; }
        public bool Finish { get; set; }
    }
}