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
    public class EfCustomerDal : EfEntityRepositoryBase<Customer, MasterChiefContext>, ICustomerDal
    {
        public Customer GetById(int entity)
        {
            using (MasterChiefContext context = new MasterChiefContext())
            {
                return context.Set<Customer>().SingleOrDefault(c => c.CustomerId == entity);
            }
        }

        public Task<Customer> GetByIdAsync(int entity)
        {
            MasterChiefContext context = new MasterChiefContext();
            {
                return context.Set<Customer>().SingleOrDefaultAsync(c => c.CustomerId == entity);
            }
        }
    }
}
