using System.Threading.Tasks;

namespace Mpn.Data
{
    public interface IMpnDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
