using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Dto
{
    [DataContract]
    public class AnnonceDto
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public int RoleId { get; set; }
        [DataMember]
        public string AnnonceHeader { get; set; }
        [DataMember]
        public string AnnonceDetails { get; set; }
        [DataMember]
        public string RoleName { get; set; }
        [DataMember]
        public string UserId { get; set; }
    }
}
