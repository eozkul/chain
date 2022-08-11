using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Chain.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService service;

        public ProductController(IProductService service)
        {
            this.service = service;
        }
        [HttpGet("list")]
        public async Task<IActionResult> GetProducts(CancellationToken cancellationToken)
        {
            var result = await service.GetAll(cancellationToken);
            return Ok(result);
        }
    }
}
