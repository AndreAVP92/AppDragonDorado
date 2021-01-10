using AppDD.Core.Entities;
using AppDD.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDD.Infrastructure.Repositories
{
    public class CategoryMongoRepository : ICategoryRepository
    {
        public async Task<IEnumerable<Category>> GetCategories()
        {
            var categories = Enumerable.Range(1, 10).Select(x => new Category
            {
                Id = x,
                Description = $"Categoría MONGO {x}",
                Status = true
            });

            await Task.Delay(10);
            return categories;
        }
    }
}
