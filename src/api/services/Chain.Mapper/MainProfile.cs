using AutoMapper;
using Chain.Entities;
using Spread.Data.Request.requestDto;

namespace Chain.Mapper
{
    internal class MainProfile:Profile
    {
        public MainProfile()
        {
            CreateMap<NewOrderRequestDto,Order>();
        }
    }
}
