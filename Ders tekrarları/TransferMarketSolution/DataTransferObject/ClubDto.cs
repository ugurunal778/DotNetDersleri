using System;

namespace DataTransferObject
{
    public class ClubDto
    {
        public int Id{ get; set; }
        public string Name { get; set; }
        public DateTime EstablishDate { get; set; }
        public string ColorOfJoursey { get; set; }
        public string JerseyUrl { get; set; }
        public int? StadiumID { get; set; }
        public int? ManagerId { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public DateTime? CreatedON { get; set; }
    }
}
