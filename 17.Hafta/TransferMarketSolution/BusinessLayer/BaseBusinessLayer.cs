using AutoMapper;
using DataLayer;
using DataTransferObjectLayer;

namespace BusinessLayer
{
    public class BaseBusinessLayer
    {
        internal MapperConfiguration ClubtoClubDtoConfig
        {
            get
            {
                var config = new MapperConfiguration(cfg =>
                     cfg.CreateMap<Club, ClubDto>()
                 );
                return config;
            }
        }
        internal MapperConfiguration ClubDtotoClubConfig
        {
            get
            {
                var config = new MapperConfiguration(cfg =>
                     cfg.CreateMap<ClubDto, Club>()
                 );
                return config;
            }
        }
        private IClubRepository _clubRepository;
        internal IClubRepository ClubRepository
        {
            get
            {
                if (_clubRepository is null)
                    _clubRepository = new ClubRepository();
                return _clubRepository;
            }
        }
    }
}
