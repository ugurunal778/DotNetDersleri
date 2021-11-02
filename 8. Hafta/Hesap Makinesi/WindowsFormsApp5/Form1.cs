using System;
using System.Windows.Forms;

namespace WindowsFormsApp5
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
                txtHesap.Clear();

            if (isDefaultParam.HasValue)
                isDefault = isDefaultParam.Value;

            if (firstInputParam)
                firstInput = null;
        }

        public void btnNumber_Click(object sender, EventArgs e)
        {
            if (isDefault)
                ClearMethods(true, false, false);
            Button btn = (Button)sender;
            txtHesap.Text += btn.Text;
        }

        private void txtHesap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false)
            {
                if (e.KeyChar == ',')
                {
                    if (txtHesap.Text.Contains(","))
                        e.Handled = true;
                }
                else
                {
                    e.Handled = true;
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearMethods(true, false, true);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtHesap.Text.Length > 0)
            {
                int LastIndex = txtHesap.Text.Length - 1;
                txtHesap.Text = txtHesap.Text.Remove(LastIndex);
            }
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            if (txtHesap.Text.Length == 0)
                return;

            if (txtHesap.Text.Contains(","))
                return;

            txtHesap.Text += ",";
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (operationType == "=")
                firstInput = Convert.ToDecimal(txtHesap.Text);
            operationType = btn.Text;

            if (isDefault || txtHesap.Text.Length == 0)
                return;

            if (firstInput.HasValue)
            {
                decimal? result = Calculate();
                txtHesap.Text = result.ToString();
                firstInput = result;
                isDefault = true;
            }
            else
            {
                firstInput = Convert.ToDecimal(txtHesap.Text);
                txtHesap.Clear();
            }
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            if (isDefault || txtHesap.Text.Length == 0)
                return;

            if (firstInput.HasValue)
            {
                decimal? result = Calculate();

                txtHesap.Text = result.ToString();
                firstInput = null;
                operationType = "=";
                isDefault = true;
            }
        }

        private decimal? Calculate()
        {
            decimal? result = null;
            if (operationType == "+")
                result = firstInput.Value + Convert.ToDecimal(txtHesap.Text);

            if (operationType == "-")
                result = firstInput.Value - Convert.ToDecimal(txtHesap.Text);

            if (operationType == "*")
                result = firstInput.Value * Convert.ToDecimal(txtHesap.Text);

            if (operationType == "/")
                result = firstInput.Value / Convert.ToDecimal(txtHesap.Text);

            return
                result;
        }
    }
}
