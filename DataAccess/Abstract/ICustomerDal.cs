using Core.DataAccess;
using Entities.Concrete;

namespace DataAccess.Abstract;

public interface ICustomerDal : IEntityRepository<Customer>, IAsyncEntityRepository<Customer>
{

    Customer GetById(int entity);
    Task<Customer> GetByIdAsync(int entity);

}