using System;
using System.Collections.Generic;
using System.Linq;

namespace DataLayer
{
    public class ClubRepository : BaseRepository, IClubRepository
    {
        public KeyValuePair<bool, string> Delete(int id)
        {
            var result = new KeyValuePair<bool, string>(true, "İşlem Başarılı");
            try
            {
                var club = TransferMarketModel.Club.FirstOrDefault(x => x.Id == id);
                if (club is null)
                {
                    result = new KeyValuePair<bool, string>(false, "Silmek istediğiniz" + id + " li club bulunmamaktadır");
                }
                else
                {
                    TransferMarketModel.Club.Remove(club);
                    TransferMarketModel.SaveChanges();
                }

            }
            catch (Exception ex)
            {
                result = new KeyValuePair<bool, string>(false, ex.Message);
            }
            return result;
        }
        public Club GetById(int id)
        {
            var club = TransferMarketModel.Club.FirstOrDefault(x => x.Id == id);
            return club;
        }
        public IList<Club> GetAll()
        {
            var clubList = TransferMarketModel.Club.ToList();
            return clubList;
        }
        public IList<Club> GetClubByNameContains(string clubName)
        {
            var clubList = TransferMarketModel.Club.Where(x => x.Name.Contains(clubName)).ToList();
            return clubList;
        }
        public KeyValuePair<bool, string> Create(Club clubModel)
        {
            var result = new KeyValuePair<bool, string>(true, "İşlem Başarılı");
            try
            {
                TransferMarketModel.Club.Add(clubModel);
                TransferMarketModel.SaveChanges();
            }
            catch (Exception ex)
            {
                result = new KeyValuePair<bool, string>(false, ex.Message);
            }
            return result;

        }
        public KeyValuePair<bool, string> Update(Club clubModel)
        {
            var result = new KeyValuePair<bool, string>(true, "İşlem Başarılı");
            try
            {
                TransferMarketModel.SaveChanges();
            }
            catch (Exception ex)
            {
                result = new KeyValuePair<bool, string>(false, ex.Message);
            }
            return result;
        }
        public bool ExistClubBySameName(string clubName)
        {
            var result = TransferMarketModel.Club.Any(x => x.Name == clubName);
            return result;
        }
        public bool HasManagerAnotherClub(int managerId)
        {
            var result = TransferMarketModel.Club.Any(x => x.ManagerId == managerId);
            return result;
        }
        public List<Club> GetStadiumUsedClubs(int stadiumId)
        {
            var result = TransferMarketModel.Club.Where(x => x.StadiumId == stadiumId).ToList();
            return result;
        }
    }
}
