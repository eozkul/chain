using Chain.Data.Request.request;
using Chain.Data.Request.requestDto;
using Chain.Data.Services.Abstractions;
using MediatR;
namespace Chain.Data.Services.Concretes
{
    internal class OrderService : IOrderService
    {
        private readonly IMediator mediator;

        public OrderService(IMediator mediator)
        {
            this.mediator = mediator;
        }
        public Task<bool> CreateOrder(NewOrderRequestDto data, CancellationToken cancellationToken)
        {
            return mediator.Send(new NewOrderRequest(data), cancellationToken);
        }
    }
}
