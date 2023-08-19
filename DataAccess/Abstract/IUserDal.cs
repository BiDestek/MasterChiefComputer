using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Core.DataAccess;
using Core.Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Abstract
{
    public interface IUserDal : IEntityRepository<User>, IAsyncEntityRepository<User>
    {
        List<OperationClaim> GetClaims(User user);
      
        List<UserDto> GetAllUsersDetail();
       
        List<UserDto> GetAllUsersDetailWithFilter(Expression<Func<UserDto, bool>> filter = null);
       
        List<UserDto> GetAllUsersDetailByFirstNameOrLastNameOrEmailWhereConstain(string constain);
       
        UserDto GetByUserId(int entity);
     }
}
