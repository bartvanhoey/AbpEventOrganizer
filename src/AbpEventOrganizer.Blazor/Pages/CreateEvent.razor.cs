using System.Threading.Tasks;
using AbpEventOrganizer.Application.Contracts.Events;
using Microsoft.AspNetCore.Components;

namespace AbpEventOrganizer.Blazor.Pages
{
  public partial class CreateEvent
  {
    private EventCreationDto Event { get; set; } = new EventCreationDto();

    [Inject] public IEventAppService EventAppService { get; set; }
    [Inject] public NavigationManager NavigationManager { get; set; }

    private async Task CreateAsync()
    {
      var eventId = await EventAppService.CreateAsync(Event);
      NavigationManager.NavigateTo($"events/{eventId}", false);
    }




  }
}