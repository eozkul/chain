using Chain.Data.Request.requestDto;
using Chain.Data.Services.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain.Data.Services.Concretes
{
    internal class CategoryService : ICategoryService
    {
        public Task<bool> CreateCategory(NewCategoryRequestDto data, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
