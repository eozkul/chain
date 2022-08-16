using Chain.Data.Request.requestDto;
using MediatR;
namespace Chain.Data.Request.request
{
    public class NewOrderRequest : IRequest<bool>
    {
        public NewOrderRequest(NewOrderRequestDto data)
        {
            Data = data;
        }
        public NewOrderRequestDto Data { get; }
    }
}
