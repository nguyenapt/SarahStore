using Xunit;

namespace Sarah.Store.EntityFrameworkCore;

[CollectionDefinition(StoreTestConsts.CollectionDefinitionName)]
public class StoreEntityFrameworkCoreCollection : ICollectionFixture<StoreEntityFrameworkCoreFixture>
{

}
