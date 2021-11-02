using AutoMapper;
using DataLayer;
using DataTransferObjectLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public partial class ClubBusinessLayer : BaseBusinessLayer, IClubBusinessLayer
    {
        public KeyValuePair<bool, string> Create(ClubDto clubDto)
        {
            KeyValuePair<bool, string> validationResult = GetCreateValidationResult(clubDto);

            if (validationResult.Key)
            {
                var club = new Mapper(ClubDtotoClubConfig).Map<Club>(clubDto);
                var result = ClubRepository.Create(club);
                return result;
            }
            else
            {
                return validationResult;
            }
        }



        public KeyValuePair<bool, string> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IList<ClubDto> GetAll()
        {
            throw new NotImplementedException();
        }

        public ClubDto GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IList<ClubDto> GetClubByNameContains(string clubName)
        {
            throw new NotImplementedException();
        }

        public KeyValuePair<bool, string> Update(ClubDto clubDto)
        {
            throw new NotImplementedException();
        }
    }
}
