using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using AbpEventOrganizer.Data;
using Volo.Abp.DependencyInjection;

namespace AbpEventOrganizer.EntityFrameworkCore
{
    public class EntityFrameworkCoreAbpEventOrganizerDbSchemaMigrator
        : IAbpEventOrganizerDbSchemaMigrator, ITransientDependency
    {
        private readonly IServiceProvider _serviceProvider;

        public EntityFrameworkCoreAbpEventOrganizerDbSchemaMigrator(
            IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task MigrateAsync()
        {
            /* We intentionally resolving the AbpEventOrganizerMigrationsDbContext
             * from IServiceProvider (instead of directly injecting it)
             * to properly get the connection string of the current tenant in the
             * current scope.
             */

            await _serviceProvider
                .GetRequiredService<AbpEventOrganizerMigrationsDbContext>()
                .Database
                .MigrateAsync();
        }
    }
}