using Core.DataAccess;
using Entities.Concrete;

namespace DataAccess.Abstract;

public interface ICategoryDal : IEntityRepository<Category>, IAsyncEntityRepository<Category>
{

    Category GetById(int entity);
    Task<Category> GetByIdAsync(int entity);

}