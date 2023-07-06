using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APISQL.Repositories.Interface;

namespace APISQL.Repositories.Implementation
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public CategoryRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Category> CreateAsync(Category category)
        {
            await _dbContext.Categories.AddAsync(category);
            await _dbContext.SaveChangesAsync();
            return category;
        }

        public async Task<IEnumerable<Category>> GetAllAsync()
        {
            return await _dbContext.Categories.ToListAsync();
        }

        public async Task<Category?> GetById(Guid id)
        {
            return await _dbContext.Categories.FirstOrDefaultAsync(x => x.Id == id);
        }
    }
}