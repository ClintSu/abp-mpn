using Mpn.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Mpn.Web.Pages
{
    /* Inherit your PageModel classes from this class.
     */
    public abstract class MpnPageModel : AbpPageModel
    {
        protected MpnPageModel()
        {
            LocalizationResourceType = typeof(MpnResource);
        }
    }
}