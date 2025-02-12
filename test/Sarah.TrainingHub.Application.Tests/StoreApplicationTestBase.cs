using Volo.Abp.Modularity;

namespace Sarah.TrainingHub;

public abstract class StoreApplicationTestBase<TStartupModule> : StoreTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
