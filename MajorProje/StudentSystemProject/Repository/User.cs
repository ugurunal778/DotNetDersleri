//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Repository
{
    using System;
    using System.Collections.Generic;
    
    public partial class User
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Surname { get; set; }
        public string Adress { get; set; }
        public string EMail { get; set; }
        public string BloodType { get; set; }
        public System.DateTime RegisterDate { get; set; }
        public bool IsActive { get; set; }
        public long TCKN { get; set; }
        public int PersonId { get; set; }
    }
}
