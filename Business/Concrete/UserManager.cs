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
using Core.Entities.Concrete;
using Core.Utilities.ForBusiness;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Concrete
{
    public class UserManager : IUserService
    {
        IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public IResult Add(User user)
        {
            IResult result = BusinessRules.Run(CheckIfUserEmailExists(user.Email));

            if (result != null)
            {
                return result;
            }

            _userDal.Add(user);
            return new SuccessResult(UserMessages.Added);
        }

        
        [TransactionScopeAspect]
        public IResult TransactionalOperationFirstName(User user)
        {
            Add(user);
            if (user.FirstName.Length > 20)
            {
                throw new Exception(UserMessages.UserFirsNameLimitValueExceeded);
            }
            return new SuccessResult(UserMessages.Added);
        }

        [TransactionScopeAspect]
        public IResult TransactionalOperationLastName(User user)
        {
            Add(user);
            if (user.LastName.Length > 30)
            {
                throw new Exception(UserMessages.UserLastNameLimitValueExceeded);
            }
            return new SuccessResult(UserMessages.Added);
        }

        public IResult Update(User user)
        {
            _userDal.Update(user);
            return new Result(true, UserMessages.Updated);
        }

        public IResult Delete(User user)
        {
            
            _userDal.Delete(user);
            return new Result(true, UserMessages.Deleted);
        }

        public IDataResult<List<OperationClaim>> GetClaims(User user)
        {
            var _getClaims = _userDal.GetClaims(user);

            if (_getClaims == null)
            {
                return new ErrorDataResult<List<OperationClaim>>(UserMessages.RecordNotFound);
            }
            return new SuccessDataResult<List<OperationClaim>>(_getClaims, UserMessages.UserClaimsListed);
        }

        public IDataResult<User> GetByMail(string email)
        {
            var _getByMail = _userDal.Get(u => u.Email == email);

            if (_getByMail == null)
            {
                return new ErrorDataResult<User>(UserMessages.RecordNotFound);
            }
            return new SuccessDataResult<User>(_getByMail, UserMessages.UserEmailAlreadyExists);

        }

        public IDataResult<UserDto> GetByUserId(int entity)
        {
            var _getByUserId = _userDal.GetByUserId(entity);

            if (_getByUserId == null)
            {
                return new ErrorDataResult<UserDto>(UserMessages.RecordNotFound);
            }
            return new SuccessDataResult<UserDto>(_getByUserId, UserMessages.UserListed);
        }

        public IDataResult<List<UserDto>> GetAllUsersDetail()
        {
            var _getAllUsersDetail = _userDal.GetAllUsersDetail();

            if (_getAllUsersDetail == null)
            {
                return new ErrorDataResult<List<UserDto>>(UserMessages.RecordNotFound);
            }
            return new SuccessDataResult<List<UserDto>>(_getAllUsersDetail, UserMessages.UserDetailsListed);
        }

        public IDataResult<List<UserDto>> GetAllUsersDetailWithFilter(Expression<Func<UserDto, bool>> filter = null)
        {
            var _getAllUsersDetailWithFilter = _userDal.GetAllUsersDetailWithFilter(filter);

            if (_getAllUsersDetailWithFilter == null)
            {
                return new ErrorDataResult<List<UserDto>>(UserMessages.RecordNotFound);
            }
            return new SuccessDataResult<List<UserDto>>(_getAllUsersDetailWithFilter, UserMessages.UsersListed);
        }

        public IDataResult<List<UserDto>> GetAllUsersDetailByFirstNameOrLastNameOrEmailWhereConstain(string constain)
        {
            var _getAllUsersDetailByFirstNameOrLastNameOrEmailWhereConstain = _userDal.GetAllUsersDetailByFirstNameOrLastNameOrEmailWhereConstain(constain);

            if (_getAllUsersDetailByFirstNameOrLastNameOrEmailWhereConstain == null)
            {
                return new ErrorDataResult<List<UserDto>>(UserMessages.RecordNotFound);
            }
            return new SuccessDataResult<List<UserDto>>(_getAllUsersDetailByFirstNameOrLastNameOrEmailWhereConstain, UserMessages.UserDetailsListed);
        }

        private IResult CheckIfUserEmailExists(string email)
        {
            var result = _userDal.GetAll(u => u.Email == email);
            if (result != null)
            {
                return new ErrorResult(UserMessages.UserEmailAlreadyExists);
            }
            return new SuccessResult();

        }


    }
}
