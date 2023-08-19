using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCategoryDal : EfEntityRepositoryBase<Category, MasterChiefContext>, ICategoryDal
    {
        public Category GetById(int entity)
        {
            using (MasterChiefContext context = new MasterChiefContext())
            {
                return context.Set<Category>().SingleOrDefault(c => c.CategoryId == entity);
            }
        }

        public Task<Category> GetByIdAsync(int entity)
        {
            MasterChiefContext context = new MasterChiefContext();
            {
                return context.Set<Category>().SingleOrDefaultAsync(c => c.CategoryId == entity);
            }
        }
    }
}
