using System;
using System.Collections.Generic;

namespace Domain
{
    public class Work
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public ICollection<ScheduleWork> Schedules { get; set; }
    }
}