using Core.DataAccess;
using Entities.Concrete;

namespace DataAccess.Abstract;

public interface IOrderDetailDal : IEntityRepository<OrderDetail>, IAsyncEntityRepository<OrderDetail>
{
    OrderDetail GetByOrderDetailId(int entity);
    Task<OrderDetail> GetByOrderDetailIdAsync(int entity);
    OrderDetail GetByOrderId(int entity);
    Task<OrderDetail> GetByOrderIdAsync(int entity);
    OrderDetail GetByProductId(int entity);
    Task<OrderDetail> GetByProductIdAsync(int entity);

}