using Volo.Abp.Application.Dtos;

namespace Acme.Bookstore.Authors;

public class GetAuthorListDto : PagedAndSortedResultRequestDto
{
    public string? Filter { get; set; }
}