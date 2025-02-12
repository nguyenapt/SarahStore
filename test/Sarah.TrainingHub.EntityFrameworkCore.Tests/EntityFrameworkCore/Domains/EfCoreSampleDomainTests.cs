using Sarah.TrainingHub.Samples;
using Xunit;

namespace Sarah.TrainingHub.EntityFrameworkCore.Domains;

[Collection(StoreTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<StoreEntityFrameworkCoreTestModule>
{

}
