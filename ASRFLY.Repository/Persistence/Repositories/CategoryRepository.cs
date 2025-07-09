using ASRFLY.Domain.Entities.CategoryEntity;
using ASRFLY.Domain.Interfaces.Repositories;
using ASRFLY.Infrastructure.EntityFrameworkCore.Contexts;

namespace ASRFLY.Infrastructure.Persistence.Repositories
{
    public class CategoryRepository: BaseRepository<Category>, ICategoryRepository
    {
        private readonly AppDbContext _context;
        public CategoryRepository(AppDbContext context) : base(context)
        {
            _context = context;
        }
    }
}
