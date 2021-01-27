using Microsoft.EntityFrameworkCore;
using Volo.Abp;

namespace AbpEventOrganizer.EntityFrameworkCore
{
    public static class AbpEventOrganizerDbContextModelCreatingExtensions
    {
        public static void ConfigureAbpEventOrganizer(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            /* Configure your own tables/entities inside here */

            //builder.Entity<YourEntity>(b =>
            //{
            //    b.ToTable(AbpEventOrganizerConsts.DbTablePrefix + "YourEntities", AbpEventOrganizerConsts.DbSchema);
            //    b.ConfigureByConvention(); //auto configure for the base class props
            //    //...
            //});
        }
    }
}