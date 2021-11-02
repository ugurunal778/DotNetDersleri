using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dto;
namespace Repository
{
    public interface IAnnonceRepository
    {
        List<AnnonceDto> GetAnnonceByRoleId(int annonceId);
    }
}
