using Entities.Concrete;
using System.Linq.Expressions;
using Core.Utilities.Results;
using Entities.DTOs;

namespace Business.Abstract;

public interface IOrderService
{
    IResult Add(Order order);
    IResult AddAsync(Order order);
    IResult TransactionalOperation(Order order);

    IResult Update(Order order);
    IResult UpdateAsync(Order order);

    IResult Delete(Order order);
    IResult DeleteAsync(Order order);

    IDataResult<Order> GetById(int entity);
    IDataResult<Order> GetByIdAsync(int entity);

    IDataResult<Order> Get(Expression<Func<Order, bool>> filter);
    IDataResult<Order> GetAsync(Expression<Func<Order, bool>> filter);

    IDataResult<List<Order>> GetAll(Expression<Func<Order, bool>> filter = null);
    IDataResult<List<Order>> GetAllAsync(Expression<Func<Order, bool>> filter = null);

    IDataResult<List<OrderDto>> GetOrderDetails();
    IDataResult<List<OrderDto>> GetOrderDetailsAsync();
}