using Volo.Abp.Modularity;

namespace Sarah.Store;

[DependsOn(
    typeof(StoreDomainModule),
    typeof(StoreTestBaseModule)
)]
public class StoreDomainTestModule : AbpModule
{

}
