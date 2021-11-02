using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Dto
{
    [DataContract]
    public class UserDto
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Firstname { get; set; }
        [DataMember]
        public string Surname { get; set; }
        [DataMember]
        public long TCKN { get; set; }
        [DataMember]
        public int PersonId { get; set; }
        [DataMember]
        public string Adress { get; set; }
        [DataMember]
        public string EMail { get; set; }
        [DataMember]
        public string BloodType { get; set; }
        [DataMember]
        public DateTime RegisterDate { get; set; }
        [DataMember]
        public bool IsActive { get; set; }
    }
}
