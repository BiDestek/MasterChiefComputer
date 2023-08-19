using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.DataAccess;
using Entities.Concrete;

namespace DataAccess.Abstract
{
    public interface ISupplierDal : IEntityRepository<Supplier>, IAsyncEntityRepository<Supplier>
    {

        Supplier GetById(int entity);
        Task<Supplier> GetByIdAsync(int entity);

    }
}
