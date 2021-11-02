using DataTransferObjectLayer;
using System.Collections.Generic;

namespace BusinessLayer
{
    partial class ClubBusinessLayer
    {
        private KeyValuePair<bool, string> GetCreateValidationResult(ClubDto clubDto)
        {
            var result = new KeyValuePair<bool, string>(true, "İşlem Başarılı");
            // Aynı İsimde Birden Fazla Klup Olamaz
            var hasExistsClubValidationResult = GetCreateValidationResultHasSameClubNameValidation(clubDto.Name);
            if (hasExistsClubValidationResult.Key == false)
                return hasExistsClubValidationResult;
            //Aynı manajer birden fazla klüpte çalışamaz,
            var hasManagerAnotherClubValidationResult = GetCreateValidationResultHasManagerAnotherClubValidation(clubDto.ManagerId.Value);
            if (hasManagerAnotherClubValidationResult.Key == false)
                return hasManagerAnotherClubValidationResult;
            //Aynı Stadyumu kullanan 3 ten fazla klup olamaz
            var hasUsedStadiumValidationResult = GetCreateValidationResultHasClubSameStadiumMaxValidation(clubDto.StadiumId.Value);
            if (hasUsedStadiumValidationResult.Key == false)
                return hasUsedStadiumValidationResult;


            return result;
        }
        private KeyValuePair<bool, string> GetCreateValidationResultHasSameClubNameValidation(string clubName)
        {
            var validationResult = new KeyValuePair<bool, string>(true, "Valdasyondan Geçmiştir");
            var result = ClubRepository.ExistClubBySameName(clubName);
            if (result)
            {
                validationResult = new KeyValuePair<bool, string>(false, "Aynı isimli farklı bir klup bulunmatakdır");
            }
            return validationResult;
        }
        private KeyValuePair<bool, string> GetCreateValidationResultHasManagerAnotherClubValidation(int managerId)
        {
            var validationResult = new KeyValuePair<bool, string>(true, "Valdasyondan Geçmiştir");
            var result = ClubRepository.HasManagerAnotherClub(managerId);
            if (result)
            {
                validationResult = new KeyValuePair<bool, string>(false, "Aynı menajer farklı bir takımı yönetmektedir");
            }
            return validationResult;
        }
        private KeyValuePair<bool, string> GetCreateValidationResultHasClubSameStadiumMaxValidation(int stadiumId)
        {
            var validationResult = new KeyValuePair<bool, string>(true, "Valdasyondan Geçmiştir");
            var usedClubs = ClubRepository.GetStadiumUsedClubs(stadiumId);
            if (usedClubs != null)
            {
                if (usedClubs.Count > 2)
                {
                    string usedClubsName = "";
                    foreach (var item in usedClubs)
                    {
                        usedClubsName += item.Name + "";
                    }
                    validationResult = new KeyValuePair<bool, string>(false, "Aynı stadyum max 3 farklı takım tarafından kullanılabilmektedir.Klüplerin isimleri: " + usedClubsName);
                }
            }
            return validationResult;

        }
    }
}
