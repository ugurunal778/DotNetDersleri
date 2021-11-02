using System;
using System.Collections.Generic;
using System.Linq;

namespace DataLayer
{
    public class ClubRepository : BaseRepository, IClubRepository
    {
        public Club GetByID(int id)
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
        public bool ExistClubBySameName(string clubName)
        {
            var result = TransferMarketModel.Club.Any(x => x.Name == clubName);
            return result;
        }
        public KeyValuePair<bool, string> Create(Club clubModel)
        {
            var result = new KeyValuePair<bool, string>(true, "islem Basarili.");
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
            var result = new KeyValuePair<bool, string>(true, "islem Basarili. ");
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
        public KeyValuePair<bool, string> Delete(int id)
        {
            var result = new KeyValuePair<bool, string>(true, "Islem Basarili. ");
            try
            {
                var club = TransferMarketModel.Club.FirstOrDefault(x => x.Id == id);
                if (club is null)
                {
                    result = new KeyValuePair<bool, string>(false, "Silmek Istediginiz " + id + "'li club bulunamamaktadir.");
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
        public bool HasManagerAnotherclub(int managerID)
        {
            var result = TransferMarketModel.Club.Any(x => x.ManagerId == managerID);
            return result;
        }
        public List<Club> GetStadiumUsedClubs(int stadiumID)
        {
            var result = TransferMarketModel.Club.Where(x => x.StadiumId == stadiumID).ToList();
            return result;
        }
    }
}
