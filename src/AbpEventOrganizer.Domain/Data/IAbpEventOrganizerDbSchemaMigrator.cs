using System.Threading.Tasks;

namespace AbpEventOrganizer.Data
{
    public interface IAbpEventOrganizerDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
