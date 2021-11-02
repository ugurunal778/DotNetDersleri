using System.Collections.Generic;
using DataTransferObject;

namespace BusinessLayer
{
    public interface IClubBusinessLayer
    {
        KeyValuePair<bool, string> Create(ClubDto clubDto);
        KeyValuePair<bool, string> Update(ClubDto clubDto);
        KeyValuePair<bool, string> Delete(int id);
        ClubDto GetById(int id);
        IList<ClubDto> GetAll();
        IList<ClubDto> GetClubByNameContains();
    }
}