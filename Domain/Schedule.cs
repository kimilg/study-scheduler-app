using System;
using System.Collections.Generic;

namespace Domain
{
    public class Schedule
    {
        public string Id { get; set; }
        public DateTime Date { get; set; }
        public ICollection<Work> Works { get; set; }
    }
}