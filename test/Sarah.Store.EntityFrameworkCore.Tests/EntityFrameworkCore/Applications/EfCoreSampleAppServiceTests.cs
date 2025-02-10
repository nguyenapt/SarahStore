using Sarah.Store.Samples;
using Xunit;

namespace Sarah.Store.EntityFrameworkCore.Applications;

[Collection(StoreTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<StoreEntityFrameworkCoreTestModule>
{

}
