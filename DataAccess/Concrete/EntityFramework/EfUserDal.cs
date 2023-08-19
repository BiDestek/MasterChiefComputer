using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Core.DataAccess.EntityFramework;
using Core.Entities.Concrete;
using DataAccess.Abstract;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfUserDal : EfEntityRepositoryBase<User, MasterChiefContext>, IUserDal
    {
        public List<OperationClaim> GetClaims(User user)
        {
            using (MasterChiefContext context = new MasterChiefContext())
            {
                var result = from oc in context.OperationClaims
                             join uoc in context.UserOperationClaims
                             on oc.OcId equals uoc.OcId
                             where uoc.UserId == user.UserId
                             select new OperationClaim { OcId = oc.OcId, Name = oc.Name };
                return result.ToList();

            }
        }
        
        public List<UserDto> GetAllUsersDetailWithFilter(Expression<Func<UserDto, bool>> filter = null)
        {
            using (MasterChiefContext context = new MasterChiefContext())
            {
                if (filter == null)
                {
                    var result = from oc in context.OperationClaims
                                 join uoc in context.UserOperationClaims
                                 on oc.OcId equals uoc.OcId
                                 join u in context.Users
                                 on uoc.UserId equals u.UserId

                                 select new UserDto
                                 {
                                     UserId = u.UserId,
                                     FirstName = u.FirstName,
                                     LastName = u.LastName,
                                     Email = u.Email,
                                     ClaimName = oc.Name,
                                     Status = u.Status
                                 };

                    return result.ToList();
                }
                else
                {
                    var result2 = from oc in context.OperationClaims
                                  join uoc in context.UserOperationClaims
                                  on oc.OcId equals uoc.OcId
                                  join u in context.Users
                                  on uoc.UserId equals u.UserId

                                  select new UserDto
                                  {
                                      UserId = u.UserId,
                                      FirstName = u.FirstName,
                                      LastName = u.LastName,
                                      Email = u.Email,
                                      ClaimName = oc.Name,
                                      Status = u.Status
                                  };



                    return result2.Where(filter).ToList();
                }
            }
        }

        
        public List<UserDto> GetAllUsersDetail()
        {
            using (MasterChiefContext context = new MasterChiefContext())
            {
                var result = from oc in context.OperationClaims
                             join uoc in context.UserOperationClaims
                             on oc.OcId equals uoc.OcId
                             join u in context.Users
                             on uoc.UserId equals u.UserId

                             select new UserDto
                             {
                                 UserId = u.UserId,
                                 FirstName = u.FirstName,
                                 LastName = u.LastName,
                                 Email = u.Email,
                                 ClaimName = oc.Name,
                                 Status = u.Status
                             };

                return result.ToList();
            }
        }

        

        public List<UserDto> GetAllUsersDetailByFirstNameOrLastNameOrEmailWhereConstain(string constain)
        {
            using (MasterChiefContext context = new MasterChiefContext())
            {
                var result = from oc in context.OperationClaims
                             join uoc in context.UserOperationClaims
                             on oc.OcId equals uoc.OcId
                             join u in context.Users
                             on uoc.UserId equals u.UserId
                             where u.FirstName.Contains(constain) | u.LastName.Contains(constain) | u.Email.Contains(constain)

                             select new UserDto
                             {
                                 UserId = u.UserId,
                                 FirstName = u.FirstName,
                                 LastName = u.LastName,
                                 Email = u.Email,
                                 ClaimName = oc.Name,
                                 Status = u.Status
                             };

                return result.ToList();
            }
        }



        public UserDto GetByUserId(int entity)
        {
            using (MasterChiefContext context = new MasterChiefContext())
            {

                var result = from oc in context.OperationClaims
                    join uoc in context.UserOperationClaims
                        on oc.OcId equals uoc.OcId
                    join u in context.Users
                        on uoc.UserId equals u.UserId
                    where u.UserId.Equals(entity)

                    select new UserDto
                    {
                        UserId = u.UserId,
                        FirstName = u.FirstName,
                        LastName = u.LastName,
                        Email = u.Email,
                        ClaimName = oc.Name,
                        Status = u.Status
                    };

                return result.FirstOrDefault();
            }

        }



    }

    
}

