using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace AbpCore.Data
{
    /* This is used if database provider does't define
     * IAbpCoreDbSchemaMigrator implementation.
     */
    public class NullAbpCoreDbSchemaMigrator : IAbpCoreDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}