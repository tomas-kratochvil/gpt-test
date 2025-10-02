using Demolice.Demo01_Completions;
using Demolice.Demo02_NextEditSuggestions;

namespace Demolice.Demo03_CopilotChat;

public class DummyProductService : IProductService
{
    public List<ProductDto> Get(string category)
    {
        // chceme nějaká náhodná demo data (in-memory)
        return [];
    }
}