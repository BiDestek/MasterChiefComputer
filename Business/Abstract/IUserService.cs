using Core.Entities.Concrete;
using Entities.DTOs;
using System.Linq.Expressions;
using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract;

public interface IUserService
{
    IResult Add(User user);
    IResult Update(User user);
    IResult Delete(User user);

    IResult TransactionalOperationFirstName(User user);
    IResult TransactionalOperationLastName(User user);

    IDataResult<User> GetByMail(string email);
    
    IDataResult<UserDto> GetByUserId(int entity);

    IDataResult<List<OperationClaim>> GetClaims(User user);
  
    IDataResult<List<UserDto>> GetAllUsersDetail();
    
    IDataResult<List<UserDto>> GetAllUsersDetailWithFilter(Expression<Func<UserDto, bool>> filter = null);
 
    IDataResult<List<UserDto>> GetAllUsersDetailByFirstNameOrLastNameOrEmailWhereConstain(string constain);

}