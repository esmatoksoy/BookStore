using System;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Acme.BookStore.Authors;

public interface IAuthorAppService : IApplicationService
{
    Task<AuthorDto> GetAsync(Guid id);

    Task<PagedResultDto<AuthorDto>> GetListAsync(GetAuthorListDto input);

    Task<AuthorDto> CreateAsync(CreateAuthorDto input);

    Task UpdateAsync(Guid id, UpdateAuthorDto input);

    Task DeleteAsync(Guid id);
}
//Defined standard methods to perform CRUD operations on the Author entity.

//PagedResultDto is a pre-defined DTO class in the ABP.It has an Items collection and
//a TotalCount property to return a paged result.

//Preferred to return an AuthorDto (for the newly created author) from the CreateAsync method,
//while it is not used by this application - just to show a different usage.