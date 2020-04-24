using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Mpn.Data
{
    /* This is used if database provider does't define
     * IMpnDbSchemaMigrator implementation.
     */
    public class NullMpnDbSchemaMigrator : IMpnDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}