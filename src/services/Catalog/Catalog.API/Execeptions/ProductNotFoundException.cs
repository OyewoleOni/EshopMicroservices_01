

namespace Catalog.API.Execeptions;

public class ProductNotFoundException : NotFoundException
{
    public ProductNotFoundException(Guid Id) : base("Product", Id) 
    {
    }
}
