using Solution.Core.Interfaces.IRepositories;
using Solution.Core.Interfaces.IServices;
using Solution.Core.Models;
using Solution.Core.Models.Entities;
using Solution.Core.Models.Requests;

namespace Solution.Services
{
    public class FruitService : IFruitService
    {
        private readonly IFruitRepository _FruitRepository;

        public FruitService(IFruitRepository FruitRepository)
        {
            _FruitRepository = FruitRepository;
        }

        public async Task<ServiceResponse<Fruit>> CreateAsync(FruitRequest requestParam)
        {
            ServiceResponse<Fruit> response = null;

            try
            {
                response = new ServiceResponse<Fruit>();

                Fruit Fruit = new Fruit(requestParam);
                response.Object = await _FruitRepository.CreateAsync(Fruit);
            }
            catch (Exception ex)
            {
                response = new ServiceResponse<Fruit>(true, ex.Message, null);
            }

            return response;
        }

        public async Task<ServiceResponse> DeleteAsync(int id)
        {
            ServiceResponse response = null;

            try
            {
                response = new ServiceResponse();

               await _FruitRepository.DeleteAsync(id);
            }
            catch (Exception ex)
            {
                response = new ServiceResponse(true, ex.Message);
            }

            return response;
        }

        public async Task<ServiceResponse<List<Fruit>>> GetAllAsync()
        {
            ServiceResponse<List<Fruit>> response = null;

            try
            {
                response = new ServiceResponse<List<Fruit>>();

                response.Object = await _FruitRepository.GetAllAsync();
            }
            catch (Exception ex)
            {
                response = new ServiceResponse<List<Fruit>>(true, ex.Message, null);
            }

            return response;
        }

        public async Task<ServiceResponse<Fruit>> GetAsync(int id)
        {
            ServiceResponse<Fruit> response = null;

            try
            {
                response = new ServiceResponse<Fruit>();

                response.Object = await _FruitRepository.GetAsync(id);
            }
            catch (Exception ex)
            {
                response = new ServiceResponse<Fruit>(true, ex.Message, null);
            }

            return response;
        }

        public async Task<ServiceResponse<List<Fruit>>> PageAsync(int page = 0)
        {
            ServiceResponse<List<Fruit>> response = null;

            try
            {
                response = new ServiceResponse<List<Fruit>>();

                response.Object = await _FruitRepository.PageAsync(page);
            }
            catch (Exception ex)
            {
                response = new ServiceResponse<List<Fruit>>(true, ex.Message, null);
            }

            return response;
        }

        public async Task<ServiceResponse<Fruit>> UpdateAsync(Fruit requestParam)
        {
            ServiceResponse<Fruit> response = null;

            try
            {
                response = new ServiceResponse<Fruit>();

                response.Object = await _FruitRepository.UpdateAsync(requestParam);
            }
            catch (Exception ex)
            {
                response = new ServiceResponse<Fruit>(true, ex.Message, null);
            }

            return response;
        }
    }
}