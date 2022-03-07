using Solution.Core.Models;
using Solution.Core.Models.Entities;
using Solution.Core.Models.Requests;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Solution.Core.Interfaces.IServices
{
    public interface IFruitService
    {
        Task<ServiceResponse<List<Fruit>>> GetAllAsync();
        Task<ServiceResponse<Fruit>> GetAsync(int id);
        Task<ServiceResponse<List<Fruit>>> PageAsync(int page = 0);
        Task<ServiceResponse> DeleteAsync(int id);
        Task<ServiceResponse<Fruit>> CreateAsync(FruitRequest requestParam);
        Task<ServiceResponse<Fruit>> UpdateAsync(Fruit requestParam);
    }
}
