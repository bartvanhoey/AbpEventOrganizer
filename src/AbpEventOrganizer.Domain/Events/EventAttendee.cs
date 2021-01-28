using System;
using Volo.Abp.Auditing;
using Volo.Abp.Domain.Entities;

namespace AbpEventOrganizer.Domain.Events
{
    public class EventAttendee :  Entity<Guid>, IHasCreationTime
    {
        public Guid UserId { get; set; }
        public DateTime CreationTime { get; set; }
    }
}