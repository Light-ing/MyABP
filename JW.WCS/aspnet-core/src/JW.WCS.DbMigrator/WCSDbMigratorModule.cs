using JW.WCS.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace JW.WCS.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(WCSEntityFrameworkCoreModule),
    typeof(WCSApplicationContractsModule)
    )]
public class WCSDbMigratorModule : AbpModule
{
}
