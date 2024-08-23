using Volo.Abp;

namespace Acme.Bookstore.Authors;

public class AuthorAlreadyExistsException :BusinessException
{
    public AuthorAlreadyExistsException(string name) : base(BookstoreDomainErrorCodes.AuthorAlreadyExists)
    {
        WithData("name", name);
    }
}