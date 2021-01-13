using AbpCore.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace AbpCore.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(AbpCoreEntityFrameworkCoreDbMigrationsModule),
        typeof(AbpCoreApplicationContractsModule)
        )]
    public class AbpCoreDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
