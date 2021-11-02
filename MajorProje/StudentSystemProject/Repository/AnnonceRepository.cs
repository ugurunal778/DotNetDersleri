using Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class AnnonceRepository : BaseRepository, IRepository<Annonce>, IAnnonceRepository
    {
        public IEnumerable<Annonce> GetAll()
        {
            return Model.Annonce.ToList();
        }

        public List<AnnonceDto> GetAnnonceByRoleId(int annonceId)  //userrole'ler role olarak değiştirilecek
        {
            var query = from userRole in Model.UserRole
                        join annonce in Model.Annonce on userRole.UserId equals annonce.Id
                        join role in Model.Role on userRole.RoleId equals role.Id
                        where userRole.UserId == annonceId
                        select new UserRoleDto
                        {
                            Id = userRole.Id,
                            RoleId = userRole.RoleId,
                            RoleName = role.RoleName,
                            UserId = annonce.Id,
                        };
            var data = query.ToList();
            return data;
        }
        public List<AnnonceDto> GetAnnonces()
        {
            var query = from userRole in Model.UserRole
                        join annonce in Model.Annonce on userRole.UserId equals annonce.Id
                        join role in Model.Role on userRole.RoleId equals role.Id
                        select new UserRoleDto
                        {
                            Id = userRole.Id,
                            RoleId = userRole.RoleId,
                            RoleName = role.RoleName,
                            UserId = annonce.Id,
                        };
            var data = query.ToList();
            return data;
        }

        public Annonce GetById(int id)
        {
            return Model.Annonce.FirstOrDefault(x => x.Id == id);
        }

        public bool Insert(Annonce entity)
        {
            Model.Annonce.Add(entity);
            Model.SaveChanges();
            return true;
        }

        public bool Remove(Annonce entity)
        {
            Model.Annonce.Remove(entity);
            Model.SaveChanges();
            return true;
        }

        public bool Update(Annonce entity)
        {
            Model.SaveChanges();
            return true;
        }
    }
}
