using POS.Domain.Entities;
using POS.Infrastructure.Commons.Bases.Request;
using POS.Infrastructure.Commons.Bases.Response;

namespace POS.Infrastructure.Persistence.Interfaces
{
    public interface ICategoryRepository : IGenericRepository<Category>
    {
        Task<BaseEntityResponse<Category>> ListCategories(BaseFiltersRequest filters);
    }
}
