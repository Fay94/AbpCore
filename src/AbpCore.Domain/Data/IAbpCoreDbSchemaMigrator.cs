using System.Threading.Tasks;

namespace AbpCore.Data
{
    public interface IAbpCoreDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
