using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface ISupplierService
    {
        IResult Add(Supplier supplier);
        IResult AddAsync(Supplier supplier);
        IResult TransactionalOperation(Supplier supplier);

        IResult Update(Supplier supplier);
        IResult UpdateAsync(Supplier supplier);

        IResult Delete(Supplier supplier);
        IResult DeleteAsync(Supplier supplier);

        IDataResult<Supplier> GetById(int entity);
        IDataResult<Supplier> GetByIdAsync(int entity);

        IDataResult<Supplier> Get(Expression<Func<Supplier, bool>> filter);
        IDataResult<Supplier> GetAsync(Expression<Func<Supplier, bool>> filter);

        IDataResult<List<Supplier>> GetAll(Expression<Func<Supplier, bool>> filter = null);
        IDataResult<List<Supplier>> GetAllAsync(Expression<Func<Supplier, bool>> filter = null);
    }
}
