using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using JW.WCS.Data;
using Volo.Abp.DependencyInjection;

namespace JW.WCS.EntityFrameworkCore;

public class EntityFrameworkCoreWCSDbSchemaMigrator
    : IWCSDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreWCSDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolve the WCSDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<WCSDbContext>()
            .Database
            .MigrateAsync();
    }
}
