using JW.WCS.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace JW.WCS.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class WCSController : AbpControllerBase
{
    protected WCSController()
    {
        LocalizationResource = typeof(WCSResource);
    }
}
