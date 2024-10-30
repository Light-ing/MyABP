using System.Threading.Tasks;

namespace JW.WCS.Data;

public interface IWCSDbSchemaMigrator
{
    Task MigrateAsync();
}
