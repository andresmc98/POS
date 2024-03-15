using POS.Domain.Entities;
using POS.Infrastructure.Persistence.Contexts;
using POS.Infrastructure.Persistence.Interfaces;

namespace POS.Infrastructure.Persistence.Repositories
{
    public class CategoryRepository : GenericRepository<Category>, ICategoryRepository
    {
        private readonly POSContext _context;

        public CategoryRepository(POSContext context)
        {
            _context = context; 
        }
    }
}
