using System;
using System.Collections.Generic;
using System.Text;
using AbpEventOrganizer.Localization;
using Volo.Abp.Application.Services;

namespace AbpEventOrganizer
{
    /* Inherit your application services from this class.
     */
    public abstract class AbpEventOrganizerAppService : ApplicationService
    {
        protected AbpEventOrganizerAppService()
        {
            LocalizationResource = typeof(AbpEventOrganizerResource);
        }
    }
}
