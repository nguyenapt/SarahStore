using Sarah.Store.Books;
using Xunit;

namespace Sarah.Store.EntityFrameworkCore.Applications.Books;

[Collection(StoreTestConsts.CollectionDefinitionName)]
public class EfCoreBookAppService_Tests : SubjectAppService_Tests<StoreEntityFrameworkCoreTestModule>
{

}