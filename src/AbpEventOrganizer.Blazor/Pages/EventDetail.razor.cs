using System;
using System.Linq;
using System.Threading.Tasks;
using AbpEventOrganizer.Application.Contracts.Events;
using Microsoft.AspNetCore.Components;

namespace AbpEventOrganizer.Blazor.Pages
{
  public partial class EventDetail
  {
    [Parameter] public string Id { get; set; }

    private EventDetailDto Event { get; set; }
    private bool IsRegistered { get; set; }

    [Inject] protected IEventAppService _eventAppService { get; set; }
    [Inject] protected NavigationManager NavigationManager { get; set; }


    protected override async Task OnInitializedAsync()
    {
      await GetEventAsync();
    }

    private async Task GetEventAsync()
    {
      Event = await _eventAppService.GetAsync(Guid.Parse(Id));
      IsRegistered = Event.Attendees.Any(a => a.UserId == CurrentUser.Id) && CurrentUser.IsAuthenticated == true;
    }


    private async Task Register()
    {
        await _eventAppService.RegisterAsync(Guid.Parse(Id));
        await GetEventAsync();
    }

    private async Task UnRegister()
    {
        await _eventAppService.UnRegisterAsync(Guid.Parse(Id));
        await GetEventAsync();
    }

    private async Task Delet()
    {
        await _eventAppService.DeleteAsync(Guid.Parse(Id));
        NavigationManager.NavigateTo("/");
    }

  }
}