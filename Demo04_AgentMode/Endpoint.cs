using Demolice.Demo04_AgentMode.Products;

namespace Demolice.Demo04_AgentMode;

public static class Endpoint
{
    public static void AddApis(this RouteGroupBuilder route)
    {
        route.AddProducts();
    }
}