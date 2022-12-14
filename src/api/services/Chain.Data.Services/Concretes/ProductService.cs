using Chain.Data.Request.request;
using Chain.Data.Request.requestDto;
using Chain.Data.Services.Abstractions;
using MediatR;
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
