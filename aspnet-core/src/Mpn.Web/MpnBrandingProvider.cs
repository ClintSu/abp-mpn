using Volo.Abp.AspNetCore.Mvc.UI.Theme.Shared.Components;
using Volo.Abp.DependencyInjection;

namespace Mpn.Web
{
    [Dependency(ReplaceServices = true)]
    public class MpnBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "Mpn";
    }
}
