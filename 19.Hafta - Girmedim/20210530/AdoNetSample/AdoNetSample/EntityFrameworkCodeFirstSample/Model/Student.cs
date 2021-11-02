using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityFrameworkCodeFirstSample.Model
{
    public class Student
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string StudentName { get; set; }
        public DateTime? DateOfBirth { get; set; }

        public Grade Grade { get; set; }
    }
}
