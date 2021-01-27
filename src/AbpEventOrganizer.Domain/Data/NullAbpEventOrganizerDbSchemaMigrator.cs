using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace AbpEventOrganizer.Data
{
    /* This is used if database provider does't define
     * IAbpEventOrganizerDbSchemaMigrator implementation.
     */
    public class NullAbpEventOrganizerDbSchemaMigrator : IAbpEventOrganizerDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}