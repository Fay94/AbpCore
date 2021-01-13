using Microsoft.EntityFrameworkCore;
using Volo.Abp;

namespace AbpCore.EntityFrameworkCore
{
    public static class AbpCoreDbContextModelCreatingExtensions
    {
        public static void ConfigureAbpCore(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            /* Configure your own tables/entities inside here */

            //builder.Entity<YourEntity>(b =>
            //{
            //    b.ToTable(AbpCoreConsts.DbTablePrefix + "YourEntities", AbpCoreConsts.DbSchema);
            //    b.ConfigureByConvention(); //auto configure for the base class props
            //    //...
            //});
        }
    }
}