using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObjectLayer
{
    public class ClubDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime EstablishDate { get; set; }
        public string ColorOfJersey { get; set; }
        public string JerseyUrl { get; set; }
        public int? StadiumId { get; set; }
        public int? ManagerId { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? ModifiedOn { set; get; }
        public DateTime? CreatedOn { get; set; }
    }
}
