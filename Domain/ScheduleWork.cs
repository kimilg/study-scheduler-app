using System;

namespace Domain
{
    public class ScheduleWork
    {
        public Guid ScheduleId { get; set; }
        public Schedule Schedule { get; set; }
        public Guid WorkId { get; set; }
        public Work Work { get; set; }
        public int Score { get; set; }
        public bool Finish { get; set; }
    }
}