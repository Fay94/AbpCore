using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace AbpCore.EntityFrameworkCore
{
    [DependsOn(
        typeof(AbpCoreEntityFrameworkCoreModule)
        )]
    public class AbpCoreEntityFrameworkCoreDbMigrationsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<AbpCoreMigrationsDbContext>();
        }
    }
}
