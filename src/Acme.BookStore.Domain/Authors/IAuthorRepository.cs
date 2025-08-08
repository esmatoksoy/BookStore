using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;

namespace Acme.BookStore.Authors;
//IRepository<Author, Guid> interface, so all the standard repository methods
//will also be available for the IAuthorRepository.
public interface IAuthorRepository : IRepository<Author, Guid>
{
    Task<Author> FindByNameAsync(string name);//was used in AuthorManager to query an author by name

    Task<List<Author>> GetListAsync(//will be used in the application layer to get a
                                    //listed,sorted and filtered list of authos to show on the UI
        int skipCount,
        int maxResultCount,
        string sorting,
        string filter = null
    );
}
