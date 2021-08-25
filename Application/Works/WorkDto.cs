using System;
using System.Collections.Generic;

namespace Application.Works
{
    public class WorkDto
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public ICollection<ScheduleDto> Schedules { get; set; }
    }
}