using Solution.Core.Models;
using Solution.Core.Models.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Solution.Core.Interfaces.IServices
{
    public interface INutritionInfoService
    {
        Task<ServiceResponse<List<NutritionInfo>>> GetAllAsync();
    }
}
