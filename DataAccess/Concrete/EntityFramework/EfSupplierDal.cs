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
    public class EfSupplierDal : EfEntityRepositoryBase<Supplier, MasterChiefContext>, ISupplierDal
    {
        public Supplier GetById(int entity)
        {
            using (MasterChiefContext context = new MasterChiefContext())
            {
                return context.Set<Supplier>().SingleOrDefault(s => s.SupplierId == entity);
            }
        }

        public Task<Supplier> GetByIdAsync(int entity)
        {
            MasterChiefContext context = new MasterChiefContext();
            {
                return context.Set<Supplier>().SingleOrDefaultAsync(s => s.SupplierId == entity);
            }
        }
    }
}
