using Microsoft.AspNetCore.Mvc;

namespace Chain.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController:ControllerBase
    {
        private readonly ICategoryService service;

        public CategoryController(ICategoryService service)
        {
            this.service = service;
        }
    }
}
