using System;
using System.Collections.Generic;
using System.Text;
using Mpn.Localization;
using Volo.Abp.Application.Services;

namespace Mpn
{
    /* Inherit your application services from this class.
     */
    public abstract class MpnAppService : ApplicationService
    {
        protected MpnAppService()
        {
            LocalizationResource = typeof(MpnResource);
        }
    }
}
