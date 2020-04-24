using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace Mpn.EntityFrameworkCore
{
    [DependsOn(
        typeof(MpnEntityFrameworkCoreModule)
        )]
    public class MpnEntityFrameworkCoreDbMigrationsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<MpnMigrationsDbContext>();
        }
    }
}
