using PhoneBook.DataLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace PhoneBook
{
    public partial class Form1 : Form
    {
        List<Customer> customers = new List<Customer>();                                                    //Customer class`inda "customers" adinda yeni liste olustur
        List<Phone> phones = new List<Phone>();                                                             //Phone class`inda "Phones" adinda yeni liste olustur
        List<string> typeOfPhone = new List<string>() { "Ev Telefonu", "Cep Telefonu", "İş Telefonu" };     //String Tipinde "typeOfPhones" adinda yeni liste olustur ve icerigi sunlar olsun...
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }                         //

        private void btnCustomerAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtSurname.Text))
            {
                MessageBox.Show("İsim ve Soyisim Dolu Olmalıdır.");
            }   //isim veya soyisim textbox`i bos mu?
            else if (txtName.Text.Length < 3)                                                           
            {
                MessageBox.Show("İsim en az 3 haneli olmalıdır");
            }                                                            //isim uzunlugu 3 harften kisa mi?
            else if (txtSurname.Text.Length < 3)                                                        
            {
                MessageBox.Show("Soyisim en az 3 haneli olmalıdır");
            }                                                         //soyisim uzunlugu 3 harften kisa mi?

            Customer customer = new Customer();     //Customer class`inda "customer" adinda yeni dizin olustur
            customer.CreatedOn = DateTime.Now;      //customer dizinin yaratilma zamanini simdiki saat yap
            customer.ModifiedOn = DateTime.Now;     //customer dizinin guncellenme zamani simdiki saat yap
            customer.Name = txtName.Text;           //customer dizinin adi text paneldeki isim yap
            customer.Surname = txtSurname.Text;     //customer dizinin soyadi text paneldeki soyisim yap
            int maxid = 0;                          

            foreach (var item in customers)         
            {
                if (item.Id > maxid)        //Item ID`si maxid`den buyuk mu
                    maxid = item.Id;    //buyuk ise maxid`yi item.ID`ye esitle
            }      //"item" adinda degisken tanimla ve "customers" dizinini bu degiskene atayarak tara
            customer.Id = maxid + 1;                //customer.ID maxid`nin 1 fazlasi ile topla
            customers.Add(customer);                //Customer dizinine yeni customers ekle
            MessageBox.Show("Ekleme İşleminiz Başarılı");
            pnlCustomerAdd.Visible = false;         //Musteri ekleme panelini kapat
            txtName.Clear();                        //Name textbox`ini temizle
            txtSurname.Clear();                     //Surname textbox`ini temizle
        }               //CustomerAdd butonuna tiklandiginda bu event calisacak

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))    //Girilen karakter numerik mi
                e.Handled = true;       //Eger numerik ise yazilmasini engelle
        }           //Name textbox`ina girdi oldugunda bu event calisacak

        private void txtSurname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))    //Girilen karakter numerik mi
                e.Handled = true;       //Eger numerik ise yazilmasini engelle
        }        //Surname textbox`ina girdi oldugunda bu event calisacak

        private void btnOpenCustomerPanel_Click(object sender, EventArgs e)
        {
            pnlCustomerAdd.Visible = true;          //Kullanici ekleme panelini ac
            pnlCustomerUpdate.Visible = false;      //Kullanici guncelleme panelini kapat
        }         //Musteri ekleme butonuna tiklandiginda bu event calisacak

        private void btnOpenCustomerUpdatePanel_Click(object sender, EventArgs e)
        {
            if (customers.Count == 0)   
            {
                MessageBox.Show("Güncellenecek Kayıt Bulunamamaktadır.");
                return;
            }        //Kullanici yok ise
            pnlCustomerUpdate.Visible = true;   //Kullanici guncelleme paneligi ac
            pnlCustomerAdd.Visible = false;     //Kullanici ekleme panelini kapat

            cmbCustomer.Items.Clear();                     //Customer combobox`ini temizle
            for (int i = 0; i < customers.Count; i++)       //int tipinde iteration olustur ve customer sayisindan az ise bir artir donguye gir
            {
                cmbCustomer.Items.Insert(i, customers[i]);  //[i] numarali musteri bilgilerini Customer combobox`ina insert et
            }   
            cmbCustomer.DisplayMember = "FullName";        //Customer combobox`inin uyelerini Customer class`indaki "Fullname" ile senkronize et
                
        }   //Musteri bilgileri guncelleme butonuna basildiginda bu event calisacak

        private void cmbCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            Customer selectedItem = (Customer)cmbCustomer.SelectedItem; //Customer combobox`daki secili itemi selectedItem degiskenine ata
            txtNameUpdate.Text = selectedItem.Name;                     //secili ismi NameUpdate textbox`ina ata
            txtSurnameUpdate.Text = selectedItem.Surname;               //secili soyismi SurnameUpdate textbox`ina ata
        }   //Guncelleme panelindeki combobox icin calisacak event

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNameUpdate.Text) || string.IsNullOrWhiteSpace(txtSurnameUpdate.Text))
            {
                MessageBox.Show("İsim ve Soyisim Dolu Olmalıdır.");
            }   //Nameupdate veya SurnameUpdate bos mu
            else if (txtNameUpdate.Text.Length < 3)
            {
                MessageBox.Show("İsim en az 3 haneli olmalıdır");
            }                                                                  //NameUpdate uzunlugu 3 harften kucuk mu
            else if (txtSurnameUpdate.Text.Length < 3)
            {
                MessageBox.Show("Soyisim en az 3 haneli olmalıdır");
            }                                                               //SurnameUpdate uzunlugu 3 harften kucuk mu
            else
            {
                Customer customerUpdate = (Customer)cmbCustomer.SelectedItem;   //Customer combobox`indaki secili itemi customerUpdate dizinine ata
                customerUpdate.Name = txtNameUpdate.Text;                       //ismi NameUpdate textbox`a esitle
                customerUpdate.Surname = txtSurnameUpdate.Text;                 //soyismi SurnameUpdate textbox`a esitle
                customerUpdate.ModifiedOn = DateTime.Now;                       //Guncelleme saatini anlik saate ayarla
                MessageBox.Show("Güncelleme İşleminiz Başarılı");
                txtSurnameUpdate.Text = "";                                     //SurnameUpdate textbox`ini temizle
                txtNameUpdate.Text = "";                                        //NameUpdate textbox`ini temizle
                cmbCustomer.Text = "";                                          //Customer combobox`ini temizle
                pnlCustomerUpdate.Visible = false;                              //Guncelleme panelini kapat
            }
        }                    //guncelleme panelindeki "update" butonuna basildiginda calisacak event
    }
}