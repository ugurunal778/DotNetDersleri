namespace PhoneBook.DataLayer
{
    public partial class Customer
    {
        public string FullName
        {
            get
            {
                return Name + " " + Surname;
            }
        }
    }
}
