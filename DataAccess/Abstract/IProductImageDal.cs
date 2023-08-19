using Core.DataAccess;
using Entities.Concrete;

namespace DataAccess.Abstract;

public interface IProductImageDal : IEntityRepository<ProductImage>, IAsyncEntityRepository<ProductImage>
{
    ProductImage GetById(int entity);
    Task<ProductImage> GetByIdAsync(int entity);

}