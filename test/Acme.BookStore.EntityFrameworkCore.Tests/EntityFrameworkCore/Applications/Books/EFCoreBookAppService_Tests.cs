using Acme.BookStore.Books;
using Xunit;

namespace Acme.BookStore.EntityFrameworkCore.Applications.Books;

[Collection(BookStoreTestConsts.CollectionDefinitionName)]
public class EfCoreBookAppService_Tests : BookAppService_Tests<BookStoreEntityFrameworkCoreTestModule>
{

}
//Should_Get_List_Of_Books test simply uses BookAppService.GetListAsync method to get and check the list of books. We can safely check
//the book "1984" by its name, because we know that this books is available in the database since we've added it in the seed data