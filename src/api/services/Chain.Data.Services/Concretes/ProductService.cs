using Chain.Data.Services.Abstractions;
using MediatR;
using Spread.Data.Request.request;
using Spread.Data.Request.requestDto;
namespace Chain.Data.Services.Concretes
{
    internal class ProductService : IProductService
    {
        private readonly IMediator mediator;

        public ProductService(IMediator mediator)
        {
            this.mediator = mediator;
        }

        public Task<List<ProductRequestDto>> GetAll(CancellationToken cancellationToken)
        {
            return mediator.Send(new GetAllProductRequest(), cancellationToken);
        }
    }
}
