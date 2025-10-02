namespace Demolice.Demo03_CopilotChat;

public static class Endpoint
{
    public static void AddBrokenService(this RouteGroupBuilder route)
    {
        route.MapGet("/broken", (BrokenService brokenService) =>
        {
            return Results.Ok(brokenService.GetCode());
        });
    }
}