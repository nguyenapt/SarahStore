using Sarah.TrainingHub.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace Sarah.TrainingHub.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(StoreEntityFrameworkCoreModule),
    typeof(StoreApplicationContractsModule)
)]
public class StoreDbMigratorModule : AbpModule
{
}
