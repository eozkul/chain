using Spread.Data.Request.requestDto;
namespace Chain.Data.Services.Abstractions
{
    public interface IProductService
    {
        Task<List<ProductRequestDto>> GetAll(CancellationToken cancellationToken);

    }
}
