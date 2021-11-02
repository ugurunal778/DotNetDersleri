using PhoneBook.DataLayer;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using PhoneBook.BusinessLayer;

namespace PhoneBook
{
    public partial class Form1 : Form
    {
        CustomerOperations customerOperations = new CustomerOperations();

        public Form1()
        {
            InitializeComponent();
        }
        private void btnCustomerAdd_Click(object sender, EventArgs e)
        {
            var result = customerOperations.CustomerUpsertValidation(txtName.Text, txtSurname.Text);
            if (result.Key == false)
            {
                MessageBox.Show(result.Value);
            }
            else
            {
                var createResult = customerOperations.CustomerCreate(txtName.Text, txtSurname.Text);
                MessageBox.Show(createResult.Value);
                customerOperations.CustomerUpsertPanelSet(pnlCustomerAdd, txtName, txtSurname);
            }
        }
        private void txtInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
                e.Handled = true;
        }
        private void btnOpenCustomerPanel_Click(object sender, EventArgs e)
        {
            customerOperations.SetPanelValue(Controls, pnlCustomerAdd);
        }
        private void btnOpenCustomerUpdatePanel_Click(object sender, EventArgs e)
        {
            var customerAnyResult = customerOperations.CustomerAny();

            if (!customerAnyResult.Key)
            {
                MessageBox.Show(customerAnyResult.Value.Value);
                return;
            }
            else if (customerAnyResult.Value.Key == false)
            {
                MessageBox.Show("Güncellenecek Kayıt Bulunamamaktadır.");
                return;
            }
            else
            {

                //customerOperations.SetPanelValue(
                //    pnlCustomerAdd, false, pnlCustomerUpdate, true);

                customerOperations.SetPanelValue(Controls, pnlCustomerUpdate);


                cmbCustomer.Items.Clear();
                var customerResult = customerOperations.GetCustomer();
                if (customerResult.Key)
                {
                    for (int i = 0; i < customerResult.Value.Key.Count; i++)
                    {
                        cmbCustomer.Items.Insert(i, customerResult.Value.Key[i]);
                    }
                    cmbCustomer.DisplayMember = "FullName";

                }
                else
                {
                    MessageBox.Show(customerResult.Value.Value);
                }
            }
        }
        private void cmbCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            Customer selectedItem = (Customer)cmbCustomer.SelectedItem;
            txtNameUpdate.Text = selectedItem.Name;
            txtSurnameUpdate.Text = selectedItem.Surname;
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var result = customerOperations.CustomerUpsertValidation(txtNameUpdate.Text, txtSurnameUpdate.Text);
            if (result.Key == false)
            {
                MessageBox.Show(result.Value);
            }
            else
            {
                var customerUpdateResult = customerOperations.Update((Customer)cmbCustomer.SelectedItem, txtNameUpdate.Text, txtSurnameUpdate.Text);
                MessageBox.Show(customerUpdateResult.Value);
                txtSurnameUpdate.Text = "";
                txtNameUpdate.Text = "";
                cmbCustomer.Text = "";
                pnlCustomerUpdate.Visible = false;
            }
        }
        private void btnPhoneAddPanel_Click(object sender, EventArgs e)
        {
            customerOperations.SetPanelValue(Controls, pnlPhoneAdd);
            cmbPhoneAddCustomer.Items.Clear();
            cmbPhoneType.Items.Clear();
            txtPhone.Text = "";
            cmbPhoneAddCustomer.Text = "";
            cmbPhoneType.Text = "";
;            var phoneTypesResult = customerOperations.GetPhoneTypes();
            if (phoneTypesResult.Key == false)
            {
                MessageBox.Show(phoneTypesResult.Value.Value);
                return;
            }

            for (int i = 0; i < phoneTypesResult.Value.Key.Count; i++)
            {
                cmbPhoneType.Items.Insert(i, phoneTypesResult.Value.Key[i]);
            }
            cmbPhoneType.DisplayMember = "PhoneType";


            var customerAnyResult = customerOperations.CustomerAny();

            if (!customerAnyResult.Key)
            {
                MessageBox.Show(customerAnyResult.Value.Value);
                return;
            }
            else if (customerAnyResult.Value.Key == false)
            {
                MessageBox.Show("Müşteri Kaydı Bulunamamaktadır.");
                return;
            }
            else
            {
                cmbPhoneAddCustomer.Items.Clear();
                var customerResult = customerOperations.GetCustomer();
                if (customerResult.Key)
                {
                    for (int i = 0; i < customerResult.Value.Key.Count; i++)
                    {
                        cmbPhoneAddCustomer.Items.Insert(i, customerResult.Value.Key[i]);
                    }
                    cmbPhoneAddCustomer.DisplayMember = "FullName";
                }
                else
                {
                    MessageBox.Show(customerResult.Value.Value);
                }
            }
        }
        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false)
                e.Handled = true;
        }
        private void btnPhoneAdd_Click(object sender, EventArgs e)
        {
            var selectedPhoneTypes = (PhoneTypes)cmbPhoneType.SelectedItem;
            var selectedCustomer = (Customer)cmbPhoneAddCustomer.SelectedItem;
            var phoneNumber = txtPhone.Text;
            var result = customerOperations.PhoneAddValidation(selectedPhoneTypes, selectedCustomer, phoneNumber);
            if (result.Key == false)
            {
                MessageBox.Show(result.Value);
            }
            else
            {
                var phoneAddResult = customerOperations.PhoneAdd(selectedPhoneTypes, selectedCustomer, phoneNumber);
                MessageBox.Show(phoneAddResult.Value);
            }
        }
        private void lblName_Click(object sender, EventArgs e)
        {

        }
    }
}