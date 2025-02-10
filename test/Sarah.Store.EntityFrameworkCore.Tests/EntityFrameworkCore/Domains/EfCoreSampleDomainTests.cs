using Sarah.Store.Samples;
using Xunit;

namespace Sarah.Store.EntityFrameworkCore.Domains;

[Collection(StoreTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<StoreEntityFrameworkCoreTestModule>
{

}
