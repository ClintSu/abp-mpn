using Mpn.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace Mpn.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(MpnEntityFrameworkCoreDbMigrationsModule),
        typeof(MpnApplicationContractsModule)
        )]
    public class MpnDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
