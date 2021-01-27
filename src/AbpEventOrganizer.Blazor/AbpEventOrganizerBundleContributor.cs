using Volo.Abp.Bundling;

namespace AbpEventOrganizer.Blazor
{
    public class AbpEventOrganizerBundleContributor : IBundleContributor
    {
        public void AddScripts(BundleContext context)
        {
        }

        public void AddStyles(BundleContext context)
        {
            context.Add("main.css", true);
        }
    }
}