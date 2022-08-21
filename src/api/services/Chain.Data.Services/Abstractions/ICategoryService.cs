using Chain.Data.Request.requestDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain.Data.Services.Abstractions
{
    public interface ICategoryService
    {
        Task<bool> CreateCategory(NewCategoryRequestDto data, CancellationToken cancellationToken);
            
            
    }
}
