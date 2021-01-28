using System;
using Volo.Abp.Application.Dtos;

namespace AbpEventOrganizer.Application.Contracts.Events
{
  public class EventAttendeeDto :  EntityDto<Guid>
  {
    public Guid UserId { get; set; }
    public string UserName { get; set; }
    public DateTime CreationTime { get; set; }
  }
}