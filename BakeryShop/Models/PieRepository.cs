using Microsoft.EntityFrameworkCore;

namespace BakeryShop.Models
{
    public class PieRepository : IPieRepository
    {
        private readonly ApplicationDbContext dbContext;

        public PieRepository(ApplicationDbContext _dbContext)
        {
            dbContext = _dbContext;
        }
        public IEnumerable<Pie> AllPies
        {
            get
            {
                return dbContext.pies.Include(x => x.Category);
            }
        }

        public IEnumerable<Pie> PiesOfTheWeek
        {
            get
            {
                return dbContext.pies.Include(x => x.Category).Where(p => p.IsPieOfTheWeek);
            }
        }

        public Pie? GetPieById(int pieId)
        {
            return dbContext.pies.FirstOrDefault(p=>p.PieId==pieId);    
        }
    }
}
