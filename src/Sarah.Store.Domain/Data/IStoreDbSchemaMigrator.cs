using System.Threading.Tasks;

namespace Sarah.Store.Data;

public interface IStoreDbSchemaMigrator
{
    Task MigrateAsync();
}
