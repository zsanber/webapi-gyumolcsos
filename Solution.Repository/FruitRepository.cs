using Microsoft.EntityFrameworkCore;
using Solution.Core.Conext;
using Solution.Core.Interfaces.IRepositories;
using Solution.Core.Models.Entities;

namespace Solution.Repository
{
    public class FruitRepository : BaseRepository<Fruit>, IFruitRepository
    {
        public FruitRepository(AppDbContext context) : base(context)
        {
        }

        public override  async Task<List<Fruit>> GetAllAsync()
        {
            return await _context.Set<Fruit>()
                                                     .Include(x => x.NutritionInfo)
                                                     .AsNoTracking()
                                                     .ToListAsync();
        }
    }
}
