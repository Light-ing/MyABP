using System;
using System.Collections.Generic;
using System.Text;
using JW.WCS.Localization;
using Volo.Abp.Application.Services;

namespace JW.WCS;

/* Inherit your application services from this class.
 */
public abstract class WCSAppService : ApplicationService
{
    protected WCSAppService()
    {
        LocalizationResource = typeof(WCSResource);
    }
}
