using Demolice.Demo01_Completions;

namespace Demolice.Demo02_NextEditSuggestions;

public interface IProductService
{
    List<ProductDto> Get(string category);
}