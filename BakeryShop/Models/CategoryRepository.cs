namespace BakeryShop.Models
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly ApplicationDbContext dbContext;

        public CategoryRepository(ApplicationDbContext _dbContext)
        {
            dbContext = _dbContext;
        }
        public IEnumerable<Category> AllCategories
        {
            get
            {
                return dbContext.Categories.OrderBy(p => p.CategoryName);
            }    
        }
    }
}
