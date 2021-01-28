using AbpEventOrganizer.Domain.Events;
using Microsoft.EntityFrameworkCore;
using Volo.Abp;
using Volo.Abp.EntityFrameworkCore.Modeling;

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
                builder.Entity<Event>(b =>
                {
                    b.ToTable(AbpEventOrganizerConsts.DbTablePrefix + "Events", AbpEventOrganizerConsts.DbSchema);
                    b.ConfigureByConvention();
                
                    //b.Property(x => x.Name).IsRequired().HasMaxLength(EventConsts.MaxNameLength);
                    // b.HasIndex(x => x.Name);
                });

        }
    }
}