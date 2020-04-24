using Microsoft.AspNetCore.Mvc.Localization;
using Microsoft.AspNetCore.Mvc.Razor.Internal;
using Mpn.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Mpn.Web.Pages
{
    /* Inherit your UI Pages from this class. To do that, add this line to your Pages (.cshtml files under the Page folder):
     * @inherits Mpn.Web.Pages.MpnPage
     */
    public abstract class MpnPage : AbpPage
    {
        [RazorInject]
        public IHtmlLocalizer<MpnResource> L { get; set; }
    }
}
