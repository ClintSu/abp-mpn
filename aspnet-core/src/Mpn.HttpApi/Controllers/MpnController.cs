using Mpn.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Mpn.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class MpnController : AbpController
    {
        protected MpnController()
        {
            LocalizationResource = typeof(MpnResource);
        }
    }
}