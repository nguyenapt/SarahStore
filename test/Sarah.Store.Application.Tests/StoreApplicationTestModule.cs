using Volo.Abp.Modularity;

namespace Sarah.Store;

[DependsOn(
    typeof(StoreApplicationModule),
    typeof(StoreDomainTestModule)
)]
public class StoreApplicationTestModule : AbpModule
{

}
