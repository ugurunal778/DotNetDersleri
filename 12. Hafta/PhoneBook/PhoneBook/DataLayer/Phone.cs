using System;

namespace PhoneBook.DataLayer
{
    public class Phone
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public string PhoneType { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime ModifiedOn { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}
