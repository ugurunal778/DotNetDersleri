using Repository;
using System.Collections.Generic;
using System.Linq;

namespace Service
{
    public partial class NewUserInfoService
    {
        private KeyValuePair<bool,string> SameUserNameValidation(string userName)
        {
            var result = new KeyValuePair<bool, string>(true, "validasyona takılmıştır.");
            List<NewUserInfo> newUserInfoResult = NewUserInfoRepository.GetByUserName(userName);
            if (newUserInfoResult.Any())
                result = new KeyValuePair<bool, string>(false, "UserName Kullanılmaktadır.");

            return result;
        }

        private KeyValuePair<bool,string> UpdateValidation(int id, string userName)
        {
            var result = new KeyValuePair<bool, string>(true, "Update Başarılı");
            List<NewUserInfo> newUserInfoResult = NewUserInfoRepository.GetUserInfoExistForId(id);
            var newUSerInfoNameResult = newUserInfoResult.Any(x => x.UserName == userName);

            if (newUSerInfoNameResult)
                result = new KeyValuePair<bool, string>(false, "Bu İsim Kullanılmaktadır.");

            return result;
        }
    }
}
