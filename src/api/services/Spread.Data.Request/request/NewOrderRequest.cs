using MediatR;
using Spread.Data.Request.requestDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spread.Data.Request.request
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
