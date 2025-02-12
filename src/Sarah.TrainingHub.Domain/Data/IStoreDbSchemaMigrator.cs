using System.Threading.Tasks;

namespace Sarah.TrainingHub.Data;

public interface IStoreDbSchemaMigrator
{
    Task MigrateAsync();
}
