﻿using Dto;
using System.Collections.Generic;
using System.Linq;

namespace Repository
{
    public partial class UserRoleRepository : BaseRepository, IRepository<UserRole>, IUserRoleRepository
    {
        public IEnumerable<UserRole> GetAll()
        {
            return Model.UserRole.ToList();
        }
        public UserRole GetById(int id)
        {
            return Model.UserRole.FirstOrDefault(x => x.Id == id);
        }

        public List<UserRoleDto> GetRolesByUserId(int userId)
        {
            var query = from userRole in Model.UserRole
                        join user in Model.User on userRole.UserId equals user.Id
                        join role in Model.Role on userRole.RoleId equals role.Id
                        where userRole.UserId == userId
                        select new UserRoleDto
                        {
                            Id = userRole.Id,
                            RoleId = userRole.RoleId,
                            RoleName = role.RoleName,
                            UserId = user.Id,
                            PersonId = user.PersonId
                        };
            var data = query.ToList();
            return data;
        }
        public List<UserRoleDto> GetRoles()
        {
            var query = from userRole in Model.UserRole
                        join userInfo in Model.User on userRole.UserId equals userInfo.Id
                        join role in Model.Role on userRole.RoleId equals role.Id
                        select new UserRoleDto
                        {
                            Id = userRole.Id,
                            RoleId = userRole.RoleId,
                            RoleName = role.RoleName,
                            UserId = userInfo.Id,
                            PersonId = userInfo.PersonId
                        };
            var data = query.ToList();
            return data;
        }

        public bool Insert(UserRole entity)
        {
            Model.UserRole.Add(entity);
            Model.SaveChanges();
            return true;
        }

        public bool Remove(UserRole entity)
        {
            Model.UserRole.Remove(entity);
            Model.SaveChanges();
            return true;
        }

        public bool Update(UserRole entity)
        {
            Model.SaveChanges();
            return true;
        }
    }
}
