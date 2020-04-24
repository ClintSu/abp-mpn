using Mpn.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Mpn
{
    [DependsOn(
        typeof(MpnEntityFrameworkCoreTestModule)
        )]
    public class MpnDomainTestModule : AbpModule
    {

    }
}