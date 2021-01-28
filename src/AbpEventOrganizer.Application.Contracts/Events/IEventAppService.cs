using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace AbpEventOrganizer.Application.Contracts.Events
{
  public interface IEventAppService : IApplicationService
  {
    Task<Guid> CreateAsync(EventCreationDto input);

    Task<List<EventDto>> GetUpcomingAsync();

    Task<EventDetailDto> GetAsync(Guid id);

    Task RegisterAsync(Guid id);

    Task UnRegisterAsync(Guid id);

    Task DeleteAsync(Guid id);
  }
}