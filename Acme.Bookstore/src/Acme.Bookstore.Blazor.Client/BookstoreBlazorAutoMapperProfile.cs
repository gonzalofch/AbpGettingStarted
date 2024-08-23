using Acme.Bookstore.Books;
using AutoMapper;

namespace Acme.Bookstore.Blazor.Client;

public class BookstoreBlazorAutoMapperProfile : Profile
{
    public BookstoreBlazorAutoMapperProfile()
    {
        //Define your AutoMapper configuration here for the Blazor project.
        CreateMap<BookDto, CreateUpdateBookDto>();
    }
}
