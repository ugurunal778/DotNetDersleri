using System;
using System.Collections.Generic;
using System.Linq;
using PhoneBook.DataLayer;
using System.Windows.Forms;

namespace PhoneBook.BussinessLayer
{
    public class CustomerOperations
    {
        readonly xfvkxruc_phonebookEntities entity = new xfvkxruc_phonebookEntities();
        public KeyValuePair<bool, string> CustomerUpsertValidation(string name, string surname)
        {
            var result = new KeyValuePair<bool, string>(true, "islem basarili");
            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(surname))
                result = new KeyValuePair<bool, string>(false, "isim ve soyisim dolu olmalidir. ");
            else if (name.Length < 3)
                result = new KeyValuePair<bool, string>(false, "isim en az 3 haneli olmalidir. ");
            else if (surname.Length < 3)
                result = new KeyValuePair<bool, string>(false, "soyisim en az 3 haneli olmalidir. ");
            return result;
        }
        public KeyValuePair<bool, string> CustomerCreate(string name, string surname)
        {
            var result = new KeyValuePair<bool, string>(true, "islem basarili. ");
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
                    pnl.Visible = false;
            }
            pnlActive.Visible = true;
        }        
        public KeyValuePair<bool, KeyValuePair<bool, string>> CustomerAny()
        {
            var result = new KeyValuePair<bool, KeyValuePair<bool, string>>();
            try
            {
                var customerAny = entity.Customer.Any();
                result = new KeyValuePair<bool, KeyValuePair<bool, string>>(true, new KeyValuePair<bool, string>(customerAny, "Isleminiz Basarili. "));
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
                var CustomerData = entity.Customer.ToList();
                result = new KeyValuePair<bool, KeyValuePair<List<Customer>, string>>(true, new KeyValuePair<List<Customer>, string>(CustomerData, "Isleminiz Basarili. "));
            }
            catch (Exception ex)
            {
                result = new KeyValuePair<bool, KeyValuePair<List<Customer>, string>>(false, new KeyValuePair<List<Customer>, string>(null, ex.Message));
            }
            return result;
        }
        public KeyValuePair<bool, string> Update(Customer cust, string name, string surname)
        {
            var result = new KeyValuePair<bool, string>(true, "Islem Basarili. ");
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
        public KeyValuePair<bool, KeyValuePair<List<PhoneType>, string>> GetPhoneTypes()
        {
            var result = new KeyValuePair<bool, KeyValuePair<List<PhoneType>, string>>();
            try
            {
                var phoneTypes = entity.PhoneType.ToList();
                result = new KeyValuePair<bool, KeyValuePair<List<PhoneType>, string>>(true, new KeyValuePair<List<PhoneType>, string>(phoneTypes, "Islem Basarili. "));
            }
            catch (Exception ex)
            {
                result = new KeyValuePair<bool, KeyValuePair<List<PhoneType>, string>>(false, new KeyValuePair<List<PhoneType>, string>(null, ex.Message));
            }
            return result;
            
        }
        public KeyValuePair<bool, string> PhoneAddValidation(PhoneType selectedPhonTypes, Customer selectedCustomer, string phoneNumber)
        {
            var result = new KeyValuePair<bool, string>(true, "Islem barasili. ");
            if (selectedPhonTypes == null)
                result = new KeyValuePair<bool, string>(false, "telefon turu seciniz. ");
            else if (selectedCustomer == null)
                result = new KeyValuePair<bool, string>(false, "musteri seciniz. ");
            else if (string.IsNullOrWhiteSpace(phoneNumber))
                result = new KeyValuePair<bool, string>(false, "telefon numarasi giriniz. ");

            return result;
        }
        public KeyValuePair<bool, string> PhoneAdd(PhoneType selectedPhoneTypes, Customer selectedCustomer, string phoneNumber)
        {
            var result = new KeyValuePair<bool, string>(true, "Islem Basarili. ");
            try
            {
                Phone phone = new Phone();
                phone.CustomerId = selectedCustomer.Id;
                phone.PhoneType = selectedPhoneTypes.PhoneType1;
                phone.PhoneNumber = phoneNumber;
                phone.ModifiedOn = DateTime.Now;
                phone.CreatedOn = DateTime.Now;
                entity.Phone.Add(phone);
                entity.SaveChanges();
            }
            catch (Exception ex)
            {
                result = new KeyValuePair<bool, string>(false, ex.Message);
                throw;
            }
            return result;
        }
    }
}