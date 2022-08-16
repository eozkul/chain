using Chain.Data.Request.requestDto;
namespace Chain.Data.Services.Abstractions
{
    public interface IOrderService
    {
        Task<bool> CreateOrder(NewOrderRequestDto data, CancellationToken cancellationToken);
    }
}
