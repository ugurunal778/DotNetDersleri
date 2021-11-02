using DTO;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public partial class NewUserInfoService
    {
        private KeyValuePair<bool, string> SameUserNameValidation(string userName)
        {
            var result = new KeyValuePair<bool, string>(true, "Validasyona takılmamıştır.");
            List<NewUserInfo> newUserInfoResult = NewUserInfoRepository.GetByUserName(userName);
            if (newUserInfoResult.Any())
                result = new KeyValuePair<bool, string>(false, "Aynı Username'den bulunmaktadır.");

            return result;

        }

        private KeyValuePair<bool, string> UpdateValidation(int id, string userName)
        {
            var result = new KeyValuePair<bool, string>(true, "Update Başarılı.");
            List<NewUserInfo> newUserInfoResult = NewUserInfoRepository.GetUserInfoExistForId(id);
            var newUserInfoNameResult = newUserInfoResult.Any(x => x.UserName == userName);

            if (newUserInfoNameResult)
                result = new KeyValuePair<bool, string>(false, "bu isim kullanılmaktadır.");

            return result;
        }
    }
}
