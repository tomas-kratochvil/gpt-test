using Demolice.Data;
using Demolice.Demo02_NextEditSuggestions;
using Demolice.Demo03_CopilotChat;
using Demolice.Demo04_AgentMode;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<AppDbContext>();
builder.Services.AddSingleton<BrokenService>();
builder.Services.AddScoped<IProductService, ProductService>();
builder.Services.AddHostedService<DbInit>();

var app = builder.Build();

app.UseHttpsRedirection();
app.MapStaticAssets();

var api = app.MapGroup(string.Empty);
api.AddBrokenService();
api.AddApis();

app.Run();