using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace Mpn.HttpApi.Client.ConsoleTestApp
{
    [DependsOn(
        typeof(MpnHttpApiClientModule),
        typeof(AbpHttpClientIdentityModelModule)
        )]
    public class MpnConsoleApiClientModule : AbpModule
    {
        
    }
}
