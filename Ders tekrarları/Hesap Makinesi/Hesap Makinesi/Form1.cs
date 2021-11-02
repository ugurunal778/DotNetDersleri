using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hesap_Makinesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        decimal? firstInput = null;
        bool isDefault = false;
        string operationtype = "";

        private void btnNumber_Click(object sender, EventArgs e)
        {
            if (isDefault)
            {
                ClearMethods(true, false, false);
            }
            Button btn = (Button)sender;
            txtHesap.Text += btn.Text;
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearMethods(true, false, true);
        }
        private void btnBackSpace_Click(object sender, EventArgs e)
        {
            if (txtHesap.Text.Length > 0)
            {
                int lastIndex = txtHesap.Text.Length - 1;
                txtHesap.Text = txtHesap.Text.Remove(lastIndex);
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
                operationtype = "=";
                isDefault = true;
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
        private void btnIslem_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (operationtype == "=")
                firstInput = Convert.ToDecimal(txtHesap.Text);

            operationtype = btn.Text;

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
        private void txtHesap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false)
            {
                if (e.KeyChar == ',')
                {

                    if (txtHesap.Text.Contains(','))
                        e.Handled = true;
                }
                else
                {
                    e.Handled = true;
                }
            }
        }
        public void ClearMethods(bool isTexBoxParam, bool? isDefaultParam, bool firstInputParam)
        {
            if (isTexBoxParam)
                txtHesap.Clear();

            if (isDefaultParam.HasValue)
                isDefault = isDefaultParam.Value;

            if (firstInputParam)
                firstInput = null;
        }
        private decimal? Calculate()
        {
            decimal? result = null;
            if (operationtype == "/")
                result = firstInput.Value / Convert.ToDecimal(txtHesap.Text);
            if (operationtype == "*")
                result = firstInput.Value * Convert.ToDecimal(txtHesap.Text);
            if (operationtype == "-")
                result = firstInput.Value - Convert.ToDecimal(txtHesap.Text);
            if (operationtype == "+")
                result = firstInput.Value + Convert.ToDecimal(txtHesap.Text);
            return result;
        }

        
    }
}