using Entities.Concrete;
using System.Linq.Expressions;
using Core.Utilities.Results;

namespace Business.Abstract;

public interface IOrderDetailService
{
    IResult Add(OrderDetail orderDetail);
    IResult AddAsync(OrderDetail orderDetail);
    IResult TransactionalOperation(OrderDetail orderDetail);

    IResult Update(OrderDetail orderDetail);
    IResult UpdateAsync(OrderDetail orderDetail);

    IResult Delete(OrderDetail orderDetail);
    IResult DeleteAsync(OrderDetail orderDetail);

    IDataResult<OrderDetail> GetByOrderDetailId(int entity);
    IDataResult<OrderDetail> GetByOrderDetailIdAsync(int entity);

    IDataResult<OrderDetail> GetByOrderId(int entity);
    IDataResult<OrderDetail> GetByOrderIdAsync(int entity);

    IDataResult<OrderDetail> GetByProductId(int entity);
    IDataResult<OrderDetail> GetByProductIdAsync(int entity);

    IDataResult<OrderDetail> Get(Expression<Func<OrderDetail, bool>> filter);
    IDataResult<OrderDetail> GetAsync(Expression<Func<OrderDetail, bool>> filter);

    IDataResult<List<OrderDetail>> GetAll(Expression<Func<OrderDetail, bool>> filter = null);
    IDataResult<List<OrderDetail>> GetAllAsync(Expression<Func<OrderDetail, bool>> filter = null);

    IDataResult<List<OrderDetail>> GetByUnitPrice(decimal min, decimal max);
    IDataResult<List<OrderDetail>> GetByUnitPriceAsync(decimal min, decimal max);
}