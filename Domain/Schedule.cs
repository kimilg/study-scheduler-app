using System;
using System.Collections.Generic;

namespace Domain
{
    public class Schedule
    {
        public Guid Id { get; set; }
        public DateTime Date { get; set; }
        public ICollection<ScheduleWork> Works { get; set; }
    }
}