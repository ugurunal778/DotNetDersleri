using System.Collections.Generic;
using DataTransferObject;

namespace BusinessLayer
{
    partial class ClubBusinessLayer
    {
        private KeyValuePair<bool, string> GetCreateValidationResult(ClubDto clubdto)
        {
            var result = new KeyValuePair<bool, string>(true, "islem basarali.");
            
            //ayni isimde birden fazla kulup olmaz
            var hasExistsClubvalidationResult = GetCreateValidationResultHasSameClubNameValidation(clubdto.Name);
            if (hasExistsClubvalidationResult.Key == false)
                return hasExistsClubvalidationResult;

            //ayni menajer birden fazla kulupte olamaz
            var hasManagerAnotherClubValidationResult = GetCreateValidationResultHasManagerAnotherClubValidation(clubdto.ManagerId.Value);
            if (hasManagerAnotherClubValidationResult.Key == false)
                return hasManagerAnotherClubValidationResult;

            //ayni stadyumu 3'ten fazla kulup kullanamaz
            var hasUsedStadiumValidationResult = GetCreateValidationResultHasClubSameStadiumMaxValidation(clubdto.StadiumID.Value);
            if (hasUsedStadiumValidationResult.Key == false)
                return hasUsedStadiumValidationResult;

            return result;
        }
        private KeyValuePair<bool, string> GetCreateValidationResultHasSameClubNameValidation(string clubName)
        {
            var validationResult = new KeyValuePair<bool, string>(true, "validasyon gecmistir.");
            var result = ClubRepository.ExistClubBySameName(clubName);
            if (result)
            {
                validationResult = new KeyValuePair<bool, string>(false, "Ayni isimli farkli kulup bulunmaktadir.");
            }
            return validationResult;
        }
        private KeyValuePair<bool, string> GetCreateValidationResultHasManagerAnotherClubValidation(int managerId)
        {
            var validationResult = new KeyValuePair<bool, string>(true, "Valdasyondan Geçmiştir");
            var result = ClubRepository.HasManagerAnotherclub(managerId);
            if (result)
            {
                validationResult = new KeyValuePair<bool, string>(false, "Aynı menajer farklı bir takımı yönetmektedir");
            }
            return validationResult;
        }
        private KeyValuePair<bool, string> GetCreateValidationResultHasClubSameStadiumMaxValidation(int stadiumId)
        {
            var valudationResult = new KeyValuePair<bool, string>(true, "Validasyon Gecmistir.");
            var usedClubs = ClubRepository.GetStadiumUsedClubs(stadiumId);
            if (usedClubs != null)
            {
                if (usedClubs.Count > 2)
                {
                    string usedClubName = "";
                    foreach (var item in usedClubs)
                    {
                        usedClubName += item.Name + "";
                    }
                    valudationResult = new KeyValuePair<bool, string>(false, "Ayni stadyum max 3 farkli takim tarafindan kullabilabilmektedir. Kuluplerin Isimleri: " + usedClubName);
                }
            }
            return valudationResult;
        }
    }
}