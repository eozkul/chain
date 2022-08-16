using Chain.Data.Abstractions;
using Chain.Data.Request.request;
using Chain.Data.Request.requestDto;
using Chain.Entities;
using MediatR;
namespace Chain.Data.Queries
{
    public class GetProductListQuery : IRequestHandler<GetAllProductRequest, List<ProductRequestDto>>
    {
        private readonly IUnitOfWork unitOfWork;

        public GetProductListQuery(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
        public Task<List<ProductRequestDto>> Handle(GetAllProductRequest request, CancellationToken cancellationToken)
        {
            var repository = unitOfWork.GetRepository<Product>();
            return repository.GetAll<ProductRequestDto>(f => f.IsActive,cancellationToken);
        }
    }
}
