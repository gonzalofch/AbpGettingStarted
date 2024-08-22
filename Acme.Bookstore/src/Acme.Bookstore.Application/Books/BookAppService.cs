using System;
using System.Threading.Tasks;
using Acme.BookStore.Books;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Acme.Bookstore.Books;

public class BookAppService :CrudAppService<Book,BookDto, Guid, PagedAndSortedResultRequestDto, CreateUpdateBookDto>, IBookAppService
{
    public BookAppService(IRepository<Book, Guid> repository) : base(repository)
    {
    }
    
}