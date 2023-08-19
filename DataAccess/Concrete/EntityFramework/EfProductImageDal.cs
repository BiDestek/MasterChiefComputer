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
    public class EfProductImageDal : EfEntityRepositoryBase<ProductImage, MasterChiefContext>, IProductImageDal
    {
        public ProductImage GetById(int entity)
        {
            using (MasterChiefContext context = new MasterChiefContext())
            {
                return context.Set<ProductImage>().SingleOrDefault(p => p.ImageId == entity);
            }
        }

        public Task<ProductImage> GetByIdAsync(int entity)
        {
            MasterChiefContext context = new MasterChiefContext();
            {
                return context.Set<ProductImage>().SingleOrDefaultAsync(p => p.ImageId == entity);
            }
        }
    }
}
