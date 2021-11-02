using System;
using System.Runtime.Serialization;

namespace DTO
{
    [DataContract]
    public class CompositeType
    {
        [DataMember]
        public bool BoolValue { get; set; }
        [DataMember]
        public string StringValue { get; set; }
    }
}
