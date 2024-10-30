using Volo.Abp.Modularity;

namespace JW.WCS;

public abstract class WCSApplicationTestBase<TStartupModule> : WCSTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
