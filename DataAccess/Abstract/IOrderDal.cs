using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Abstract;

public interface IOrderDal : IEntityRepository<Order>, IAsyncEntityRepository<Order>
{
    Order GetById(int entity);
    Task<Order> GetByIdAsync(int entity);

    List<OrderDto> GetOrderDetails();
    Task<List<OrderDto>> GetOrderDetailsAsync();
}