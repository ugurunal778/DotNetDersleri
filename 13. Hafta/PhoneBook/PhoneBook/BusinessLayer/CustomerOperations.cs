using PhoneBook.DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhoneBook.BusinessLayer
{
    public class CustomerOperations
    {
        readonly xfvkxruc_phonebookEntities entity = new xfvkxruc_phonebookEntities();
        public KeyValuePair<bool, string> CustomerUpsertValidation(string name, string surname)
        {
            var result = new KeyValuePair<bool, string>(true, "İşlem Başarılı");
            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(surname))
            {
                result = new KeyValuePair<bool, string>(false, "İsim ve Soyisim Dolu Olmalıdır.");
            }
            else if (name.Length < 3)
            {
                result = new KeyValuePair<bool, string>(false, "İsim en az 3 haneli olmalıdır");

            }
            else if (surname.Length < 3)
            {
                result = new KeyValuePair<bool, string>(false, "Soyisim en az 3 haneli olmalıdır");
            }
            return result;
        }
        public KeyValuePair<bool, string> CustomerCreate(string name, string surname)
        {
            var result = new KeyValuePair<bool, string>(true, "İşlem Başarılı");
            try
            {
                Customer customer = new Customer();
                customer.CreatedOn = DateTime.Now;
                customer.ModifiedOn = DateTime.Now;
                customer.Name = name;
                customer.Surname = surname;
                entity.Customer.Add(customer);
                entity.SaveChanges();
            }
            catch (Exception ex)
            {
                result = new KeyValuePair<bool, string>(false, ex.Message);
            }
            return result;
        }
        public void SetPanelValue(Control.ControlCollection controls, Panel pnlActive)
        {
            foreach (var item in controls)
            {
                if (item is Panel pnl)
                {
                    pnl.Visible = false;
                }
            }
            pnlActive.Visible = true;

        }
        public KeyValuePair<bool, KeyValuePair<bool, string>> CustomerAny()
        {
            var result = new KeyValuePair<bool, KeyValuePair<bool, string>>();
            try
            {
                var customerAny = entity.Customer.Any();
                result = new KeyValuePair<bool, KeyValuePair<bool, string>>(true, new KeyValuePair<bool, string>(customerAny, "İşleminiz Başarılı"));
            }
            catch (Exception ex)
            {
                result = new KeyValuePair<bool, KeyValuePair<bool, string>>(false, new KeyValuePair<bool, string>(false, ex.Message));
            }
            return result;
        }
        public KeyValuePair<bool, KeyValuePair<List<Customer>, string>> GetCustomer()
        {
            var result = new KeyValuePair<bool, KeyValuePair<List<Customer>, string>>();
            try
            {
                var customerData = entity.Customer.ToList();
                result = new KeyValuePair<bool, KeyValuePair<List<Customer>, string>>(true, new KeyValuePair<List<Customer>, string>(customerData, "İşlem Başarılı"));
            }
            catch (Exception ex)
            {
                result = new KeyValuePair<bool, KeyValuePair<List<Customer>, string>>(false, new KeyValuePair<List<Customer>, string>(null, ex.Message));

            }
            return result;
        }
        public KeyValuePair<bool, string> Update(Customer cust, string name, string surname)
        {
            var result = new KeyValuePair<bool, string>(true, "İşlem Başarılı");
            try
            {
                cust.Name = name;
                cust.Surname = surname;
                cust.ModifiedOn = DateTime.Now;
                entity.SaveChanges();
            }
            catch (Exception ex)
            {
                result = new KeyValuePair<bool, string>(false, ex.Message);
            }
            return result;

        }
        public void CustomerUpsertPanelSet(Panel pnl, TextBox txtName, TextBox txtSurname)
        {
            pnl.Visible = false;
            txtName.Clear();
            txtSurname.Clear();
        }
        public KeyValuePair<bool, KeyValuePair<List<PhoneTypes>, string>> GetPhoneTypes()
        {
            var result = new KeyValuePair<bool, KeyValuePair<List<PhoneTypes>, string>>();
            try
            {
                var phoneTypes = entity.PhoneTypes.ToList();
                result = new KeyValuePair<bool, KeyValuePair<List<PhoneTypes>, string>>(true, new KeyValuePair<List<PhoneTypes>, string>(phoneTypes, "İşlem Başarılı"));
            }
            catch (Exception ex)
            {
                result = new KeyValuePair<bool, KeyValuePair<List<PhoneTypes>, string>>(false, new KeyValuePair<List<PhoneTypes>, string>(null, ex.Message));
            }
            return result;
        }
        public KeyValuePair<bool, string> PhoneAddValidation(PhoneTypes selectedPhoneTypes, Customer selectedCustomer, string phoneNumber)
        {
            var result = new KeyValuePair<bool, string>(true, "İşlem Başarılı");
            if (selectedPhoneTypes == null)
                result = new KeyValuePair<bool, string>(false, "Telefon Türü Seçiniz");
            else if (selectedCustomer == null)
                result = new KeyValuePair<bool, string>(false, "Müşteri Seçiniz");
            else if (string.IsNullOrWhiteSpace(phoneNumber))
                result = new KeyValuePair<bool, string>(false, "Telefon Numarası Giriniz");

            return result;
        }
        public KeyValuePair<bool, string> PhoneAdd(PhoneTypes selectedPhoneTypes, Customer selectedCustomer, string phoneNumber)
        {
            var result = new KeyValuePair<bool, string>(true, "İşlem Başarılı");
            try
            {
                Phone phone = new Phone();
                phone.CustomerId = selectedCustomer.Id;
                phone.PhoneType = selectedPhoneTypes.PhoneType;
                phone.PhoneNumber = phoneNumber;
                phone.ModifiedOn = DateTime.Now;
                phone.CreatedOn = DateTime.Now;
                entity.Phone.Add(phone);
                entity.SaveChanges();
            }
            catch (Exception ex)
            {
                result = new KeyValuePair<bool, string>(false, ex.Message);
            }
            return result;




        }
    }
}

