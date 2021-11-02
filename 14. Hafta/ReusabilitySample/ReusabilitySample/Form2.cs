using System.Windows.Forms;
using System;

namespace ReusabilitySample
{
    public partial class Form2 : FormBase
    {
        public Form2()
        {
            InitializeComponent();
        }
        public void TextBoxKeyPressValidation(object sender, KeyPressEventArgs e)
        {
            e.Handled = !TextBoxOperationsBusinessLayerOperation.TextBoxInputValidate((TextBox)sender, e.KeyChar);
        }
        private void btnParaYatir_Click(object sender, System.EventArgs e)
        {
            var result = BankBusinessLayerOperation.ParaYatir(Convert.ToInt32(txtFromId.Text), Convert.ToInt32(textBox1.Text), Convert.ToDecimal(txtOndalıkli.Text));
            if (result == false)
            {
                MessageBox.Show("Bakiyeniz İşlemi Gerçekleştiremezsiniz");
            }
        }
    }
}