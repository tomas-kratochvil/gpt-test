using Demolice.Demo02_NextEditSuggestions;
using Microsoft.AspNetCore.Mvc;

namespace Demolice.Demo04_AgentMode.Products;

public static class ProductsEndpoint
{
    public static void AddProducts(this RouteGroupBuilder route)
    {
        var api = route.MapGroup("products");

        api.MapGet("", (IProductService products, [FromQuery]string category) =>
        {
            var data = products.Get(category);

            return Results.Ok(new
            {
                Items = data,
            });
        });
    }
}