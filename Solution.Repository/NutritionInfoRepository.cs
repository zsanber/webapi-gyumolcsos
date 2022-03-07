using Solution.Core.Conext;
using Solution.Core.Interfaces.IRepositories;
using Solution.Core.Models.Entities;

namespace Solution.Repository
{
    public class NutritionInfoRepository : BaseRepository<NutritionInfo>, INutritionInfoRepository
    {
        public NutritionInfoRepository(AppDbContext context) : base(context)
        {
        }
    }
}
