using DataTransferObject;
using DataLayer;
using AutoMapper;

namespace BusinessLayer
{
    public class BaseBusinessLayer
    {
        internal MapperConfiguration ClubToClubDtoConfig
        {
            get
            {
                var config = new MapperConfiguration(cfg =>
                    cfg.CreateMap<Club, ClubDto>()
                );
                return config;
            }
        }
        internal MapperConfiguration clubDtoToConfig
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
