using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Dto
{
    [DataContract]
    public class LessonDto
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string LessonName { get; set; }
        [DataMember]
        public int LessonCredit { get; set; }
        [DataMember]
        public int UserIdInstructer { get; set; }
        [DataMember]
        public int UserIdStudent { get; set; }
        [DataMember]
        public int LessonNote { get; set; }
        [DataMember]
        public int LessonDiscontinuity { get; set; }
    }
}
