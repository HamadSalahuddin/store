using Store.Data.Infrastructure;
using Store.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Data.Repositoires
{
    public class CategoryRepository: RepositoryBase<Category>, ICategoryRepository
    {
        public CategoryRepository(IDbFactory dbFactory)
            : base(dbFactory) { }

        public Category GetCategoryByName(string categoryName)
        {
            return this.DbContext.Categories
                .FirstOrDefault(category => category.Name.ToLower() == categoryName.ToLower());
        }

        public override void Update(Category entity)
        {
            entity.DateUpdated = DateTime.Now;
            base.Update(entity);
        }
    }

    public interface ICategoryRepository : IRepository<Category>
    {
        Category GetCategoryByName(string categoryName);
    }
}
