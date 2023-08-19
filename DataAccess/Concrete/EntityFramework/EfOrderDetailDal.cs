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
    public class EfOrderDetailDal : EfEntityRepositoryBase<OrderDetail, MasterChiefContext>, IOrderDetailDal
    {
        public OrderDetail GetByOrderId(int entity)
        {
            using (MasterChiefContext context = new MasterChiefContext())
            {
                return context.Set<OrderDetail>().SingleOrDefault(od => od.OrderId == entity);
            }
        }

        public Task<OrderDetail> GetByOrderIdAsync(int entity)
        {
            MasterChiefContext context = new MasterChiefContext();
            {
                return context.Set<OrderDetail>().SingleOrDefaultAsync(od => od.OrderId == entity);
            }
        }

        public OrderDetail GetByOrderDetailId(int entity)
        {
            using (MasterChiefContext context = new MasterChiefContext())
            {
                return context.Set<OrderDetail>().SingleOrDefault(od => od.OrderId == entity);
            }
        }

        public Task<OrderDetail> GetByOrderDetailIdAsync(int entity)
        {
            MasterChiefContext context = new MasterChiefContext();
            {
                return context.Set<OrderDetail>().SingleOrDefaultAsync(od => od.OrderId == entity);
            }
        }

        public OrderDetail GetByProductId(int entity)
        {
            using (MasterChiefContext context = new MasterChiefContext())
            {
                return context.Set<OrderDetail>().SingleOrDefault(od => od.ProductId == entity);
            }
        }

        public Task<OrderDetail> GetByProductIdAsync(int entity)
        {
            MasterChiefContext context = new MasterChiefContext();
            {
                return context.Set<OrderDetail>().SingleOrDefaultAsync(od => od.ProductId == entity);
            }
        }
    }
}
