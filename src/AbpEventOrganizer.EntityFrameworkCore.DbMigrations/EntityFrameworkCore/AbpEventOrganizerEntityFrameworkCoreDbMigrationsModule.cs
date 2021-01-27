using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace AbpEventOrganizer.EntityFrameworkCore
{
    [DependsOn(
        typeof(AbpEventOrganizerEntityFrameworkCoreModule)
        )]
    public class AbpEventOrganizerEntityFrameworkCoreDbMigrationsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<AbpEventOrganizerMigrationsDbContext>();
        }
    }
}
