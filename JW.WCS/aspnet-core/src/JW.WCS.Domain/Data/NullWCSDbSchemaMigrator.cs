using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace JW.WCS.Data;

/* This is used if database provider does't define
 * IWCSDbSchemaMigrator implementation.
 */
public class NullWCSDbSchemaMigrator : IWCSDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
