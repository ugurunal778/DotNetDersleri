using DTO;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public partial class UserInfoService
    {
        private KeyValuePair<bool, string> SameUserNameValidation(string userName)
        {
            var result = new KeyValuePair<bool, string>(true, "Validasyona takılmamıştır.");
            List<UserInfo> userInfoResult = UserInfoRepository.GetByUserName(userName);
            if (userInfoResult.Any())
                result = new KeyValuePair<bool, string>(false, "Aynı Username'den bulunmaktadır.");

            return result;

        }

        private KeyValuePair<bool, string> UpdateValidation(int id, string userName)
        {
            var result = new KeyValuePair<bool, string>(true, "Update Başarılı.");
            List<UserInfo> userInfoResult = UserInfoRepository.GetUserInfoExistForId(id);
            var userInfoNameResult = userInfoResult.Any(x => x.UserName == userName);

            if (userInfoNameResult)
                result = new KeyValuePair<bool, string>(false, "bu isim kullanılmaktadır.");

            return result;
        }
    }
}
