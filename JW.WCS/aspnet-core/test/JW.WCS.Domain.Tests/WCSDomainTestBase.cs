using Volo.Abp.Modularity;

namespace JW.WCS;

/* Inherit from this class for your domain layer tests. */
public abstract class WCSDomainTestBase<TStartupModule> : WCSTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
