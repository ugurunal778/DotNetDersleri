using System;
using System.Linq;
using System.Windows.Forms;

namespace Hesap_Makinesi
{
    public partial class Form1 : Form
    {
        decimal? firstInput = null;
        bool isDefault = false;
        string operationType = "";
        public Form1()
        {
            InitializeComponent();
        }

        public void ClearMethods(bool isTextBoxParam, bool? isDefaultParam, bool firstInputParam)
        {
            if (isTextBoxParam)
            {
                txtSonuc.Clear();
            }

            if (isDefaultParam.HasValue)
            {
                isDefault = isDefaultParam.Value;
            }
            if (firstInputParam)
                firstInput = null;

        }

        private void btnNumber_Click(object sender, EventArgs e)
        {
            if (isDefault)
            {
                ClearMethods(true, false, false);
            }
            Button btn = (Button)sender;
            txtSonuc.Text += btn.Text;
        }

        private void txtSonuc_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Sayısal Bir İfade mi ? 
            if (char.IsDigit(e.KeyChar) == false)
            {
                //Girilen Değer Virgül Mü ? 
                if (e.KeyChar == ',')
                {
                    //Daha önceden virgül var mı ?
                    if (txtSonuc.Text.Contains(','))
                        e.Handled = true;
                }
                else
                {
                    //Virgül Değilse
                    e.Handled = true;
                }
            }
        }

        private void btnSilme_Click(object sender, EventArgs e)
        {
            ClearMethods(true, false, true);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtSonuc.Text.Length > 0)
            {
                int lastIndex = txtSonuc.Text.Length - 1;
                txtSonuc.Text = txtSonuc.Text.Remove(lastIndex);
            }
        }

        private void btnVirgül_Click(object sender, EventArgs e)
        {
            if (txtSonuc.Text.Length == 0)
                return;
            if (txtSonuc.Text.Contains(","))
                return;

            txtSonuc.Text += ",";
        }

        private void btnIslem_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (operationType == "=")
            {
                firstInput = Convert.ToDecimal(txtSonuc.Text);
            }
            operationType = btn.Text;

            if (isDefault || txtSonuc.Text.Length == 0) return;

            if (firstInput.HasValue)
            {
                decimal? result = Calculate();
                txtSonuc.Text = result.ToString();
                firstInput = result;
                isDefault = true;
            }
            else
            {
                firstInput = Convert.ToDecimal(txtSonuc.Text);
                txtSonuc.Clear();
            }
        }

        private void btnEşittir_Click(object sender, EventArgs e)
        {
            if (isDefault || txtSonuc.Text.Length == 0) return;

            if (firstInput.HasValue)
            {
                decimal? result = Calculate();

                txtSonuc.Text = result.ToString();
                firstInput = null;
                operationType = "=";
                isDefault = true;
            }
        }

        private decimal? Calculate()
        {
            decimal? result = null;
            if (operationType == "/")
            {
                result = firstInput.Value / Convert.ToDecimal(txtSonuc.Text);
            }
            else if (operationType == "*")
            {
                result = firstInput.Value * Convert.ToDecimal(txtSonuc.Text);
            }
            else if (operationType == "+")
            {
                result = firstInput.Value + Convert.ToDecimal(txtSonuc.Text);
            }
            else if (operationType == "-")
            {
                result = firstInput.Value - Convert.ToDecimal(txtSonuc.Text);
            }

            return result;
        }
    }
}
