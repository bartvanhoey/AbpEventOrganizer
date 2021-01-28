using System;
using System.Collections;
using System.Collections.Generic;
using Volo.Abp.Domain.Entities.Auditing;

namespace AbpEventOrganizer.Domain.Events
{
    public class Event :  FullAuditedAggregateRoot<Guid>        
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public bool IsFree { get; set; }
        public DateTime StartTime { get; set; }
        public ICollection<EventAttendee> Attendees { get; set; }

        public Event()
        {
            Attendees = new List<EventAttendee>();
        }
    }
}