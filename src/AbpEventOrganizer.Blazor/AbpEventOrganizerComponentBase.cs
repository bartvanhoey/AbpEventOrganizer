using AbpEventOrganizer.Localization;
using Volo.Abp.AspNetCore.Components;

namespace AbpEventOrganizer.Blazor
{
    public abstract class AbpEventOrganizerComponentBase : AbpComponentBase
    {
        protected AbpEventOrganizerComponentBase()
        {
            LocalizationResource = typeof(AbpEventOrganizerResource);
        }
    }
}
