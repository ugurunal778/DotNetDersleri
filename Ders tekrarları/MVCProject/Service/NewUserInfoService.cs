using DTO;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public partial class NewUserInfoService : BaseService, INewUserInfoService
    {
        public IList<NewUserInfoDto> GetAll()
        {
            var newUserInfos = NewUserInfoRepository.GetAll();
            var userRoleList = UserRoleRepository.GetAll();
            var roleNames = RoleRepository.GetAll();
            
            var newUserInfoDto = NewUserInfoToUserInfoDtoMapper.Map<List<NewUserInfoDto>>(newUserInfos); 
            
            foreach (var item in newUserInfoDto)
            {
                var listItem = userRoleList.Where(x => x.UserInfoID == item.Id);
                if (listItem != null)
                {
                    List<UserRoleDto> userRoleDtos = new List<UserRoleDto>();

                    foreach (var litem in listItem)
                    {
                        var userRoleDto = new UserRoleDto
                        {
                            RoleName = litem.RoleId.ToString(),
                            Id = litem.ID,
                            IsActive = litem.IsActive,
                            UserInfoId = litem.UserInfoID
                        };
                        userRoleDto.RoleName = roleNames.FirstOrDefault(x => x.Id == litem.RoleId).RoleName;

                        userRoleDtos.Add(userRoleDto);
                    }
                    item.Roles = userRoleDtos;
                }
            }

            foreach (var item in newUserInfoDto)
            {
                var listItem = roleNames.Where(x => x.Id == item.Id);

                if (listItem != null)
                {
                    List<RoleDto> userRoles = new List<RoleDto>();
                    foreach (var ritem in listItem)
                    {
                        var roleDto = new RoleDto
                        {
                            RoleName = ritem.RoleName,
                            Id = ritem.Id,
                            IsActive = ritem.IsActive
                        };
                        userRoles.Add(roleDto);
                    }
                    item.RoleNames = userRoles;
                }
            }
            return newUserInfoDto;
        }

        public NewUserInfoDto GetById(int id)
        {
            var result = NewUserInfoRepository.GetByID(id);
            var newUserInfoDto = NewUserInfoToUserInfoDtoMapper.Map<NewUserInfoDto>(result);
            return newUserInfoDto;
        }

        public ResponseBase<int> Insert(NewUserInfoDto newUserInfoDto)
        {
            var response = new ResponseBase<int>();
            response.Success(1);
            var validationResult = SameUserNameValidation(newUserInfoDto.UserName);

            if (validationResult.Key)
            {
                var newUserInfo = NewUserInfoDtoToUserInfoMapper.Map<NewUserInfo>(newUserInfoDto);
                NewUserInfoRepository.Insert(newUserInfo); 
            }
            else
            {
                response.Error();
            }
            return response;
        }

        public bool Remove(int Id)
        {
            var deletedItem = NewUserInfoRepository.GetByID(Id);
            var result = NewUserInfoRepository.Remove(deletedItem);
            return result;
        }

        public KeyValuePair<bool, string> Update(NewUserInfoDto newUserInfoDto)
        {
            var response = new ResponseBase<int>();
            response.Success(1);
            var validationResult = UpdateValidation(newUserInfoDto.Id, newUserInfoDto.UserName);

            if (validationResult.Key)
            {
                var updatedModel = NewUserInfoRepository.GetByID(newUserInfoDto.Id);
                updatedModel.FirstName = newUserInfoDto.FirstName;
                updatedModel.LastName = newUserInfoDto.LastName;
                updatedModel.Password = newUserInfoDto.Password;
                updatedModel.UserName = newUserInfoDto.UserName;
                updatedModel.Gender = newUserInfoDto.Gender;
                updatedModel.Age = newUserInfoDto.Age;
                updatedModel.E_Mail = newUserInfoDto.E_Mail;
                updatedModel.ModifiedDate = DateTime.Now;

                var result = NewUserInfoRepository.Update(updatedModel);
            }
            return validationResult;
        }
    }
}
