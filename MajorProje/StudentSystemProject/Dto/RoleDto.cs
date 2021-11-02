using System.Runtime.Serialization;

namespace Dto
{
    public class RoleDto
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Firstname { get; set; }
        [DataMember]
        public string Surname { get; set; }
        [DataMember]
        public long TCKN { get; set; }
    }
}
