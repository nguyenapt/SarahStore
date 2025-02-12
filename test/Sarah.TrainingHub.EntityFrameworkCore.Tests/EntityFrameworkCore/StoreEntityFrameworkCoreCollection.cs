using Xunit;

namespace Sarah.TrainingHub.EntityFrameworkCore;

[CollectionDefinition(StoreTestConsts.CollectionDefinitionName)]
public class StoreEntityFrameworkCoreCollection : ICollectionFixture<StoreEntityFrameworkCoreFixture>
{

}
