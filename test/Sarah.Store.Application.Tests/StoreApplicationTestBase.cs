using Volo.Abp.Modularity;

namespace Sarah.Store;

public abstract class StoreApplicationTestBase<TStartupModule> : StoreTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
