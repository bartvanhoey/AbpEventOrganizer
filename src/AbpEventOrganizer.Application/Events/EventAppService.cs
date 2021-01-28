using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AbpEventOrganizer.Application.Contracts.Events;
using AbpEventOrganizer.Domain.Events;
using AbpEventOrganizer.Users;
using Microsoft.AspNetCore.Authorization;
using Volo.Abp;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.Users;

namespace AbpEventOrganizer.Application.Events
{
  public class EventAppService : AbpEventOrganizerAppService, IEventAppService
  {
    private readonly IRepository<Event, Guid> _eventRepository;
    private readonly IRepository<AppUser, Guid> _userRepository;

    public EventAppService(IRepository<Event, Guid> eventRepository, IRepository<AppUser, Guid> appuserRepository)
    {
      _eventRepository = eventRepository;
      _userRepository = appuserRepository;
    }

    [Authorize]
    public async Task<Guid> CreateAsync(EventCreationDto input)
    {
      var eventEntity = ObjectMapper.Map<EventCreationDto, Event>(input);
      await _eventRepository.InsertAsync(eventEntity, autoSave: false);
      return eventEntity.Id;
    }

    public async Task DeleteAsync(Guid id)
    {
      var @event = await _eventRepository.GetAsync(id);

      if (CurrentUser.Id != @event.CreatorId)
      {
        throw new UserFriendlyException("You don't have the necessary permission to delete this event!");
      }
      await _eventRepository.DeleteAsync(id, autoSave: false);
    }

    // public async Task<EventDetailDto> GetAsync(Guid id)
    // {
    //   var @event = await _eventRepository.GetAsync(id);
    //   var attendeeIds = @event.Attendees.Select(a => a.UserId).ToList();
    //   var attendees = (await AsyncExecuter.ToListAsync(_userRepository.Where(u => attendeeIds.Contains(u.Id)))).ToDictionary(x => x.Id);
    //   var result = ObjectMapper.Map<Event, EventDetailDto>(@event);

    //   foreach (var attendeeDto in result.Attendees)
    //   {
    //     attendeeDto.UserName = attendees[attendeeDto.UserId].UserName;
    //   }

    //   return result;
    // }

    // public async Task<List<EventDto>> GetUpcomingAsync()
    // {
    //   var events = await AsyncExecuter.ToListAsync(_eventRepository.Where(x => x.StartTime > Clock.Now).OrderBy(x => x.StartTime));
    //   return ObjectMapper.Map<List<Event>, List<EventDto>>(events);
    // }


    // [Authorize]
    // public async Task RegisterAsync(Guid id)
    // {
    //   var @event = await _eventRepository.GetAsync(id);
    //   if (@event.Attendees.Any(a => a.UserId == CurrentUser.Id)) return;
    //   @event.Attendees.Add(new EventAttendee { UserId = CurrentUser.GetId(), CreationTime = Clock.Now });
    //   await _eventRepository.UpdateAsync(@event, autoSave: false);
    // }

    // [Authorize]
    // public async Task UnRegisterAsync(Guid id)
    // {
    //   var @event = await _eventRepository.GetAsync(id);
    //   var removedItems = @event.Attendees.RemoveAll(x => x.UserId == CurrentUser.Id);
    //   if (removedItems.Any())
    //     await _eventRepository.UpdateAsync(@event, autoSave: false);
    // }
  }
}