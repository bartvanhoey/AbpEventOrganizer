using Volo.Abp.Modularity;

namespace AbpEventOrganizer
{
    [DependsOn(
        typeof(AbpEventOrganizerApplicationModule),
        typeof(AbpEventOrganizerDomainTestModule)
        )]
    public class AbpEventOrganizerApplicationTestModule : AbpModule
    {

    }
}