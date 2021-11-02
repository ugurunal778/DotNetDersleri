using System;
using PhoneBook.DataLayer;
using PhoneBook.BussinessLayer;
using System.Windows.Forms;

namespace PhoneBook
{
    public partial class Form1 : Form
    {
        CustomerOperations customerOperations = new CustomerOperations();
        public Form1()
        {
            InitializeComponent();
        }
        private void btnAddCustomerPanel_Click(object sender, EventArgs e)
        {
            customerOperations.SetPanelValue(Controls, pnlAddCustomer);
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            var result = customerOperations.CustomerUpsertValidation(txtAddName.Text, txtAddSurname.Text);
            if (result.Key == false)
            {
                MessageBox.Show(result.Value);
            }
            else
            {
                var createResult = customerOperations.CustomerCreate(txtAddName.Text, txtAddSurname.Text);
                MessageBox.Show(createResult.Value);
                customerOperations.CustomerUpsertPanelSet(pnlAddCustomer, txtAddName, txtAddSurname);
            }
        }
        private void txtInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
                e.Handled = true;
        }
        private void btnUpdateCustomerPanel_Click(object sender, EventArgs e)
        {
            var customerAnyResult = customerOperations.CustomerAny();
            if (!customerAnyResult.Key)
            {
                MessageBox.Show(customerAnyResult.Value.Value);
                return;
            }
            else if (customerAnyResult.Value.Key == false)
            {
                MessageBox.Show("guncellenecek kayit bulunamamaktadir. ");
                return;
            }
            else
            {
                customerOperations.SetPanelValue(Controls, pnlUpgradeCustomer);
                cmbUpgradePickCustomer.Items.Clear();
                var customerResult = customerOperations.GetCustomer();
                if (customerResult.Key)
                {
                    for (int i = 0; i < customerResult.Value.Key.Count; i++)
                    {
                        cmbUpgradePickCustomer.Items.Insert(i, customerResult.Value.Key[i]);
                    }
                    cmbUpgradePickCustomer.DisplayMember = "FullName";
                }
                else
                {
                    MessageBox.Show(customerResult.Value.Value);
                }
            }
        }
        private void cmbUpgradePickCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            Customer selectedItem = (Customer)cmbUpgradePickCustomer.SelectedItem;
            txtUgradeName.Text = selectedItem.Name;
            txtUpgradeSurname.Text = selectedItem.Surname;
        }
        private void btnUpgrade_Click(object sender, EventArgs e)
        {
            var result = customerOperations.CustomerUpsertValidation(txtUgradeName.Text, txtUpgradeSurname.Text);
            if (result.Key == false)
            {
                MessageBox.Show(result.Value);
            }
            else
            {
                var customerUpdateResult = customerOperations.Update((Customer)cmbUpgradePickCustomer.SelectedItem, txtUgradeName.Text, txtUpgradeSurname.Text);
                MessageBox.Show(customerUpdateResult.Value);
                txtUpgradeSurname.Text = "";
                txtUgradeName.Text = "";
                cmbUpgradePickCustomer.Text = "";
                pnlUpgradeCustomer.Visible = false;
            }
        }
        private void btnAddPhonePanel_Click(object sender, EventArgs e)
        {
            customerOperations.SetPanelValue(Controls, pnlAddPhone);
            cmbAddPhonePickCustomer.Items.Clear();
            cmbAddPhoneType.Items.Clear();
            txtAddPhoneType.Text = "";
            cmbAddPhonePickCustomer.Text = "";
            cmbAddPhoneType.Text = "";
            var phoneTypesResult = customerOperations.GetPhoneTypes();
            if (phoneTypesResult.Key==false)
            {
                MessageBox.Show(phoneTypesResult.Value.Value);
                return;    
            }
            for (int i = 0; i < phoneTypesResult.Value.Key.Count; i++)
            {
                cmbAddPhoneType.Items.Insert(i, phoneTypesResult.Value.Key[i]);
            }
            cmbAddPhoneType.DisplayMember = "PhoneType1";

            var customerAnyResult = customerOperations.CustomerAny();
            if (!customerAnyResult.Key)
            {
                MessageBox.Show(customerAnyResult.Value.Value);
                return;
            }
            else if (customerAnyResult.Value.Key == false)
            {
                MessageBox.Show("Musteri kaydi bulunmamaktadir. ");
                return;
            }
            else
            {
                cmbAddPhonePickCustomer.Items.Clear();
                var customerResult = customerOperations.GetCustomer();
                if (customerResult.Key)
                {
                    for (int i = 0; i < customerResult.Value.Key.Count; i++)
                    {
                        cmbAddPhonePickCustomer.Items.Insert(i, customerResult.Value.Key[i]);
                    }
                    cmbAddPhonePickCustomer.DisplayMember = "FullName";
                }
                else
                {
                    MessageBox.Show(customerResult.Value.Value);
                }
            }

        }
        private void txtAddPhoneType_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false)
                e.Handled = true;
        }
        private void btnAddPhone_Click(object sender, EventArgs e)
        {
            var selectedPhoneTypes = (PhoneType)cmbAddPhoneType.SelectedItem;
            var selectedCustomer = (Customer)cmbAddPhonePickCustomer.SelectedItem;
            var phoneNumber = txtAddPhoneNumber.Text;
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
    }
}
