using Solution.Core.Interfaces.IRepositories;
using Solution.Core.Interfaces.IServices;
using Solution.Core.Models;
using Solution.Core.Models.Entities;

namespace Solution.Services
{
    public class NutritionInfoService : INutritionInfoService
    {
        private readonly INutritionInfoRepository _NutritionInfoRepository;

        public NutritionInfoService(INutritionInfoRepository NutritionInfoRepository)
        {
            _NutritionInfoRepository = NutritionInfoRepository;
        }

        public async Task<ServiceResponse<List<NutritionInfo>>> GetAllAsync()
        {
            ServiceResponse<List<NutritionInfo>> response = null;

            try
            {
                response = new ServiceResponse<List<NutritionInfo>>();

                response.Object = await _NutritionInfoRepository.GetAllAsync();
            }
            catch (Exception ex)
            {
                response = new ServiceResponse<List<NutritionInfo>>(true, ex.Message, null);
            }

            return response;
        }
    }
}
