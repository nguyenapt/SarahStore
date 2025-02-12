using Volo.Abp.Modularity;

namespace Sarah.TrainingHub;

[DependsOn(
    typeof(StoreApplicationModule),
    typeof(StoreDomainTestModule)
)]
public class StoreApplicationTestModule : AbpModule
{

}
