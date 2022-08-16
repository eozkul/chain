using Chain.Data.Request.requestDto;
using Chain.Data.Services.Abstractions;
using Microsoft.AspNetCore.Mvc;

namespace Chain.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderControllers:ControllerBase
    {
        private readonly IOrderService service;

        public OrderControllers(IOrderService service)
        {
            this.service = service;
        }
        [HttpPost("add")]
        public async Task<IActionResult> Add([FromBody] NewOrderRequestDto data, CancellationToken cancellationToken)
        {
            var result = await service.CreateOrder(data, cancellationToken);
            return Ok(result);
        }
    }
}
