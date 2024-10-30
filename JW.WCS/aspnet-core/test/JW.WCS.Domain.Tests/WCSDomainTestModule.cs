using Volo.Abp.Modularity;

namespace JW.WCS;

[DependsOn(
    typeof(WCSDomainModule),
    typeof(WCSTestBaseModule)
)]
public class WCSDomainTestModule : AbpModule
{

}
