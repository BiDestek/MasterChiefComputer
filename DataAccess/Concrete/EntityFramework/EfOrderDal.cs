using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfOrderDal : EfEntityRepositoryBase<Order, MasterChiefContext>, IOrderDal
    {
    
        public List<OrderDto> GetOrderDetails()
        {
            using (MasterChiefContext context = new MasterChiefContext())
            {
                var result = from o in context.Orders
                             join od in context.OrderDetails
                             on o.OrderId equals od.OrderId
                             join c in context.Customers
                             on o.CustomerId equals c.CustomerId
                             join p in context.Products
                             on od.ProductId equals p.ProductId
                             join ct in context.Categories
                             on p.CategoryId equals ct.CategoryId
                             join s in context.Suppliers
                             on p.SupplierId equals s.SupplierId

                             select new OrderDto
                             {
                                 OrderId = o.OrderId,
                                 ProductId = od.ProductId,
                                 ProductName=p.ProductName,
                                 UnitPrice = p.UnitPrice,
                                 OrderDate = o.OrderDate,
                                 CustomerName = c.CustomerName,
                                 CustomerId = c.CustomerId,
                                 CustomerCity = c.CustomerCity,
                                 Discount = od.Discount,
                                 Quantity = od.Quantity,
                                 CategoryId = p.CategoryId,
                                 CategoryName = ct.CategoryName,
                                 Description = ct.Description,
                                 CompanyName = s.CompanyName,
                                 ContactName=s.ContactName,
                                 ContactTitle = s.ContactTitle,
                                 Address = s.Address,
                                 SupplierCity= s.SupplierCity,
                                 Phone = s.Phone




                             };

                return result.ToList();
            }
        }
        public Task<List<OrderDto>> GetOrderDetailsAsync()
        {
            MasterChiefContext context = new MasterChiefContext();

            var result = from o in context.Orders
                            join od in context.OrderDetails 
                            on o.OrderId equals od.OrderId
                            join c in context.Customers
                            on o.CustomerId equals c.CustomerId
                            join p in context.Products
                            on od.ProductId equals p.ProductId
                            join ct in context.Categories
                            on p.CategoryId equals ct.CategoryId
                            join s in context.Suppliers 
                            on p.SupplierId equals s.SupplierId

                         select new OrderDto
                            {
                                OrderId = o.OrderId,
                                ProductId = od.ProductId,
                                ProductName = p.ProductName,
                                UnitPrice = p.UnitPrice,
                                OrderDate = o.OrderDate,
                                CustomerName = c.CustomerName,
                                CustomerId = c.CustomerId,
                                CustomerCity = c.CustomerCity,
                                Discount = od.Discount,
                                Quantity = od.Quantity,
                                CategoryId = p.CategoryId,
                                CategoryName = ct.CategoryName,
                                Description = ct.Description,
                                CompanyName = s.CompanyName,
                                ContactName = s.ContactName,
                                ContactTitle = s.ContactTitle,
                                Address = s.Address,
                                SupplierCity = s.SupplierCity,
                                Phone = s.Phone
                            };
            return result.ToListAsync();
        }

        public Order GetById(int entity)
        {
            using (MasterChiefContext context = new MasterChiefContext())
            {
                return context.Set<Order>().SingleOrDefault(o => o.OrderId == entity);
            }
        }

        public Task<Order> GetByIdAsync(int entity)
        {
            MasterChiefContext context = new MasterChiefContext();
            {
                return context.Set<Order>().SingleOrDefaultAsync(o => o.OrderId == entity);
            }
        }
    }
}
