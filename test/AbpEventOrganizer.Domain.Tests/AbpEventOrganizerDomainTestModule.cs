using AbpEventOrganizer.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace AbpEventOrganizer
{
    [DependsOn(
        typeof(AbpEventOrganizerEntityFrameworkCoreTestModule)
        )]
    public class AbpEventOrganizerDomainTestModule : AbpModule
    {

    }
}