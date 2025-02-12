using Sarah.TrainingHub.Books;
using Xunit;

namespace Sarah.TrainingHub.EntityFrameworkCore.Applications.Books;

[Collection(StoreTestConsts.CollectionDefinitionName)]
public class EfCoreBookAppService_Tests : SubjectAppService_Tests<StoreEntityFrameworkCoreTestModule>
{

}