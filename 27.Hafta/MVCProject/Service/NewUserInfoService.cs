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
            var result = NewUserInfoRepository.GetAll();
            var newUserInfoDto = NewUserInfoToUserInfoDtoMapper.Map<List<NewUserInfoDto>>(result);
            return newUserInfoDto;
        }

        public NewUserInfoDto GetById(int id)
        {
            var result = NewUserInfoRepository.GetById(id);
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
            var deletedItem = NewUserInfoRepository.GetById(Id);
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
                var updatedModel = NewUserInfoRepository.GetById(newUserInfoDto.Id);
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
