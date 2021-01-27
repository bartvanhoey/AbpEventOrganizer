using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace AbpEventOrganizer.Blazor
{
    [Dependency(ReplaceServices = true)]
    public class AbpEventOrganizerBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "AbpEventOrganizer";
    }
}
