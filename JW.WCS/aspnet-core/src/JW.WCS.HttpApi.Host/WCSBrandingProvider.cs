using Microsoft.Extensions.Localization;
using JW.WCS.Localization;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace JW.WCS;

[Dependency(ReplaceServices = true)]
public class WCSBrandingProvider : DefaultBrandingProvider
{
    private IStringLocalizer<WCSResource> _localizer;

    public WCSBrandingProvider(IStringLocalizer<WCSResource> localizer)
    {
        _localizer = localizer;
    }

    public override string AppName => _localizer["AppName"];
}
