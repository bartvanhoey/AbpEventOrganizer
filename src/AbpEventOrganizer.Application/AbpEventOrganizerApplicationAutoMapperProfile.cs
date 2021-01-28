using AbpEventOrganizer.Application.Contracts.Events;
using AbpEventOrganizer.Domain.Events;
using AutoMapper;

namespace AbpEventOrganizer
{
  public class AbpEventOrganizerApplicationAutoMapperProfile : Profile
  {
    public AbpEventOrganizerApplicationAutoMapperProfile()
    {
      /* You can configure your AutoMapper mapping configuration here.
       * Alternatively, you can split your mapping configurations
       * into multiple profile classes for a better organization. */
      CreateMap<EventCreationDto, Event>();
      CreateMap<Event, EventDto>();

      CreateMap<Event,EventDetailDto>();
      CreateMap<EventAttendee,EventAttendeeDto>();

    }
  }
}
