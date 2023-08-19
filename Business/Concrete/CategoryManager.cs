using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using Business.BusinessAspects.Autofac;
using Business.Constants.Messages;
using Business.ValidationRules.FluentValidation;
using Core.Aspect.Autofac.Caching;
using Core.Aspect.Autofac.Performance;
using Core.Aspect.Autofac.Transaction;
using Core.Aspect.Autofac.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;

namespace Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }


        [SecuredOperation("category.add,admin")]
        [ValidationAspect(typeof(CategoryValidator), Priority = 1)]
        [CacheRemoveAspect("ICategoryService.Get")]
        public IResult Add(Category category)
        {

            _categoryDal.Add(category);
            return new SuccessResult(CategoryMessages.Added);
        }


        [SecuredOperation("category.add,admin")]
        [ValidationAspect(typeof(CategoryValidator))]
        [CacheRemoveAspect("ICategoryService.Get")]
        public IResult AddAsync(Category category)
        {
            _categoryDal.AddAsync(category);
            return new SuccessResult(CategoryMessages.Added);
        }


        [TransactionScopeAspect]
        public IResult TransactionalOperation(Category category)
        {

            Add(category);
            if (category.CategoryName.StartsWith("CTG"))
            {
                throw new Exception(CategoryMessages.CategoryNameInvalid);
            }
            return new SuccessResult(CategoryMessages.Added);
        }


        [SecuredOperation("category.add,admin")]
        [ValidationAspect(typeof(CategoryValidator))]
        [CacheRemoveAspect("ICategoryService.Get")]
        public IResult Update(Category category)
        {
            _categoryDal.Update(category);
            return new SuccessResult(CategoryMessages.Updated);
        }


        [SecuredOperation("category.add,admin")]
        [ValidationAspect(typeof(CategoryValidator))]
        [CacheRemoveAspect("ICategoryService.Get")]
        public IResult UpdateAsync(Category category)
        {
            _categoryDal.UpdateAsync(category);
            return new SuccessResult(CategoryMessages.Updated);
        }


        [SecuredOperation("category.del,admin")]
        [CacheRemoveAspect("ICategoryService.Get")]
        public IResult Delete(Category category)
        {
            _categoryDal.Delete(category);
            return new SuccessResult(CategoryMessages.Deleted);
        }


        [SecuredOperation("category.del,admin")]
        [CacheRemoveAspect("ICategoryService.Get")]
        public IResult DeleteAsync(Category category)
        {
            _categoryDal.DeleteAsync(category);
            return new SuccessResult(CategoryMessages.Deleted);
        }

        [CacheAspect]
        [SecuredOperation("category.list,admin")]
        public IDataResult<Category> GetById(int entity)
        {
            var _getById = _categoryDal.GetById(entity);

            if (_getById == null)
            {
                return new ErrorDataResult<Category>(CategoryMessages.RecordNotFound);
            }
            return new SuccessDataResult<Category>(_getById, CategoryMessages.CategoryListed);
        }

        [CacheAspect]
        [SecuredOperation("category.list,admin")]
        public IDataResult<Category> GetByIdAsync(int entity)
        {
            var _getByIdAsync = _categoryDal.GetByIdAsync(entity).Result;

            if (_getByIdAsync == null)
            {
                return new ErrorDataResult<Category>(CategoryMessages.RecordNotFound);
            }
            return new SuccessDataResult<Category>(_getByIdAsync, CategoryMessages.CategoryListed);
        }

        [CacheAspect]
        [SecuredOperation("category.list,admin")]
        public IDataResult<Category> Get(Expression<Func<Category, bool>> filter)
        {
            if (DateTime.Now.Hour == 07)
            {
                return new ErrorDataResult<Category>(CategoryMessages.MaintenanceTime);
            }

            var _get = _categoryDal.Get(filter);

            if (_get == null)
            {
                return new ErrorDataResult<Category>(CategoryMessages.RecordNotFound);
            }
            return new SuccessDataResult<Category>(_get, CategoryMessages.CategoryListed);
        }

        [CacheAspect]
        [SecuredOperation("category.list,admin")]
        public IDataResult<Category> GetAsync(Expression<Func<Category, bool>> filter)
        {
            if (DateTime.Now.Hour == 07)
            {
                return new ErrorDataResult<Category>(CategoryMessages.MaintenanceTime);
            }

            var _getAsync = _categoryDal.GetAsync(filter).Result;

            if (_getAsync == null)
            {
                return new ErrorDataResult<Category>(CategoryMessages.RecordNotFound);
            }
            return new SuccessDataResult<Category>(_getAsync, CategoryMessages.CategoryListed);
        }

        [PerformanceAspect(5)]
        [CacheAspect(duration: 10)]
        [SecuredOperation("category.list,admin")]
        public IDataResult<List<Category>> GetAll(Expression<Func<Category, bool>> filter = null)
        {
            var _getAll = _categoryDal.GetAll(filter);

            if (_getAll == null)
            {
                return new ErrorDataResult<List<Category>>(CategoryMessages.RecordNotFound);
            }
            return new SuccessDataResult<List<Category>>(_getAll, CategoryMessages.CategoriesListed);
        }

        [PerformanceAspect(5)]
        [CacheAspect(duration: 10)]
        [SecuredOperation("category.list,admin")]
        public IDataResult<List<Category>> GetAllAsync(Expression<Func<Category, bool>> filter = null)
        {
            var _getAllAsync = _categoryDal.GetAllAsync(filter).Result;

            if (_getAllAsync == null)
            {
                return new ErrorDataResult<List<Category>>(CategoryMessages.RecordNotFound);
            }
            return new SuccessDataResult<List<Category>>(_getAllAsync, CategoryMessages.CategoriesListed);
        }
        
        
    }
}
