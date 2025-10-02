using Demolice.Data;
using Demolice.Demo01_Completions;
using Microsoft.EntityFrameworkCore;

namespace Demolice.Demo02_NextEditSuggestions;

public class ProductService(AppDbContext db) : IProductService
{
    public List<ProductDto> Get(string category) // + priceFrom
    {
        var produtcs = GetInternal(category);
            return produtcs.Select(x => new ProductDto()
            {

            }).ToList();
    }

    private List<Product> GetInternal(string category)
    {
        var query = db
                        .Products.AsNoTracking();

            if (!string.IsNullOrEmpty(category))
            {
                query = query.Where(x => x.Category == category);
            }

            return query.ToList();
    }
}