using Volo.Abp.Modularity;

namespace JW.WCS;

[DependsOn(
    typeof(WCSApplicationModule),
    typeof(WCSDomainTestModule)
)]
public class WCSApplicationTestModule : AbpModule
{

}
