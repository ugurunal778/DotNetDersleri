using System.Collections.Generic;

namespace DataLayer
{
    public interface IClubRepository
    {
        Club GetById(int id);
        IList<Club> GetAll();
        IList<Club> GetClubByNameContains(string clubName);
        bool ExistClubBySameName(string clubName);
        KeyValuePair<bool, string> Create(Club clubModel);
        KeyValuePair<bool, string> Update(Club clubModel);
        KeyValuePair<bool, string> Delete(int id);
        bool HasManagerAnotherClub(int managerId);
        List<Club> GetStadiumUsedClubs(int stadiumId);
    }
}
