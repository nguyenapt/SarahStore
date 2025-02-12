using Sarah.TrainingHub.Samples;
using Xunit;

namespace Sarah.TrainingHub.EntityFrameworkCore.Applications;

[Collection(StoreTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<StoreEntityFrameworkCoreTestModule>
{

}
