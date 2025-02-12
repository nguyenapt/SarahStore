using Volo.Abp.Modularity;

namespace Sarah.TrainingHub;

[DependsOn(
    typeof(StoreDomainModule),
    typeof(StoreTestBaseModule)
)]
public class StoreDomainTestModule : AbpModule
{

}
