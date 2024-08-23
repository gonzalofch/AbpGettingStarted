using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Acme.Bookstore.Authors;

public interface IAuthorAppService :IApplicationService
{
    Task<AuthorDto> GetAsync(Guid id);
    Task<PagedResultDto<AuthorDto>> GetListAsync(GetAuthorListDto input);
    Task<AuthorDto> CreateAsync(CreateAuthorDto input);
    Task UpdateAsync(Guid id,UpdateAuthorDto input);
    Task DeleteAsync(Guid id);
}