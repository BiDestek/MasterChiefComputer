using Entities.Concrete;
using System.Linq.Expressions;
using Core.Utilities.Results;

namespace Business.Abstract;

public interface ICustomerService
{
    IResult Add(Customer customer);
    IResult AddAsync(Customer customer);
    IResult TransactionalOperation(Customer customer);

    IResult Update(Customer customer);
    IResult UpdateAsync(Customer customer);

    IResult Delete(Customer customer);
    IResult DeleteAsync(Customer customer);
    
    IDataResult<Customer> GetById(int entity);
    IDataResult<Customer> GetByIdAsync(int entity);

    IDataResult<Customer> Get(Expression<Func<Customer, bool>> filter);
    IDataResult<Customer> GetAsync(Expression<Func<Customer, bool>> filter);

    IDataResult<List<Customer>> GetAll(Expression<Func<Customer, bool>> filter = null);
    IDataResult<List<Customer>> GetAllAsync(Expression<Func<Customer, bool>> filter = null);
}