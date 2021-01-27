using AbpEventOrganizer.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace AbpEventOrganizer.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(AbpEventOrganizerEntityFrameworkCoreDbMigrationsModule),
        typeof(AbpEventOrganizerApplicationContractsModule)
        )]
    public class AbpEventOrganizerDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
