using AbpEventOrganizer.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace AbpEventOrganizer.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class AbpEventOrganizerController : AbpController
    {
        protected AbpEventOrganizerController()
        {
            LocalizationResource = typeof(AbpEventOrganizerResource);
        }
    }
}