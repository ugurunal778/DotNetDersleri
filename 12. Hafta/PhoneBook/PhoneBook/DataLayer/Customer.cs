using System;

namespace PhoneBook.DataLayer
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime ModifiedOn { get; set; }
        public DateTime CreatedOn { get; set; }

        public string FullName
        {
            get
            {
                return Name + " " + Surname;
            }
        }
    }
}
