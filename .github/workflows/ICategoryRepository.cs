using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APISQL.Repositories.Interface
{
    public interface ICategoryRepository
    {
        Task<Category> CreateAsync(Category category);
        Task<IEnumerable<Category>> GetAllAsync();
        Task<Category?> GetById(Guid id);
    }
}