using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace AbpEventOrganizer
{
    [Dependency(ReplaceServices = true)]
    public class AbpEventOrganizerBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "AbpEventOrganizer";
    }
}
