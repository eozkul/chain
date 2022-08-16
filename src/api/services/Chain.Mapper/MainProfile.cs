using AutoMapper;
using Chain.Data.Request.request;
using Chain.Data.Request.requestDto;
using Chain.Entities;
namespace Chain.Mapper
{
    internal class MainProfile:Profile
    {
        public MainProfile()
        {
            CreateMap<NewOrderRequestDto,Order>();
            CreateMap<Order, NewOrderRequestDto>();
            CreateMap<GetAllProductRequest, Product>();
            CreateMap<Product,GetAllProductRequest>();

        }
    }
}
