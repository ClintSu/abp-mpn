using Volo.Abp.Modularity;

namespace Mpn
{
    [DependsOn(
        typeof(MpnApplicationModule),
        typeof(MpnDomainTestModule)
        )]
    public class MpnApplicationTestModule : AbpModule
    {

    }
}