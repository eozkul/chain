using Chain.Data.Request.requestDto;
using MediatR;
namespace Chain.Data.Request.request
{
    public class GetAllProductRequest : IRequest<List<ProductRequestDto>>
    {
    }
}