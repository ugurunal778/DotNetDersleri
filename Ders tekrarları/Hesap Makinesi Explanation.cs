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
        decimal? firstInput = null;	//firstInput degiskenini decimal ve nullable olarak tanimla
        bool isDefault = false;		//isDefault degiskenini bool olarak tanimla
        string operationtype = "";	//operationtype degiskenini string olarak tanimla

        private void btnNumber_Click(object sender, EventArgs e)			//Numerik butonlara basildiginda calisacak olan metod
        {
            if (isDefault)							//isDefault true mu?
            {
                ClearMethods(true, false, false);	//true ise ClearMethods'u su sekilde calistir
            }
            Button btn = (Button)sender;			//"btn" adinda buton objesi tanimla
            txtHesap.Text += btn.Text;				//butondan gelen text`i textbox'in text'ine ekle
        }
        private void btnClear_Click(object sender, EventArgs e)				//"C" butonuna basildiginda calisacak metod
        {
            ClearMethods(true, false, true);		//ClearMethods'u bu sekilde calistir
        }
        private void btnBackSpace_Click(object sender, EventArgs e)			//Silme "<--" butonuna basildiginda calisacak metod
        {
            if (txtHesap.Text.Length > 0)							//textbox'in text`inin uzunlugu 0'dan buyuk mu
            {
                int lastIndex = txtHesap.Text.Length - 1;			//textbox'in text`ini 1 azalt sonra lastIndex degiskeni tanimla ve ona aktar
                txtHesap.Text = txtHesap.Text.Remove(lastIndex);	//text`in text`ini lastIndex ile degistir ve text`in text`ine ata
            }
        }
        private void btnEqual_Click(object sender, EventArgs e)				//esittir butonuna basildiginda calisacak metod
        {
            if (isDefault || txtHesap.Text.Length == 0) 	//isDefault true mu yada txtHesap uzunlugu 0 mi
                return;										//metoddan cik

            if (firstInput.HasValue)						//firstInput'da herhangi deger var mi
            {
                decimal? result = Calculate();				//result degiskenini decimal ve nullable olarak tanimla Calculate sonucunu ona ata	

                txtHesap.Text = result.ToString();			//result'i string'e donustur ve txtHesap textine atar
                firstInput = null;							//firstInput'u null yap
                operationtype = "=";						//operationtype'i esittir olarak ayarla
                isDefault = true;							//isDefault'u true'ya cek
            }
        }
        private void btnDot_Click(object sender, EventArgs e)				//virgul butonuna basildiginda calisacak metod
        {
            if (txtHesap.Text.Length == 0)		//txtHesap text`i 0 mi
                return;							//metoddan cik
            if (txtHesap.Text.Contains(","))	//txtHesap text'i "," iceriyor mu
                return;							//metoddan cik
            txtHesap.Text += ",";				//txtHesap text`ine "," ekle
        }
        private void btnIslem_Click(object sender, EventArgs e)				//butonlarin yapacagi islemleri bir araya getiren metod
        {
            Button btn = (Button)sender;						//btn adinda Button objesi tanimla
            if (operationtype == "=")							//eger operationtype "=" ise
                firstInput = Convert.ToDecimal(txtHesap.Text);	//txtHesap text`ini decimal'e cevir ve firstInput'a ata

            operationtype = btn.Text;							//btn text`ini operationtype'a ata

            if (isDefault || txtHesap.Text.Length == 0)			//isDefault true mu veya txtHesap text`i 0 mi
                return;											//metoddan cik

            if (firstInput.HasValue)							//firstInput'ta deger var mi
            {
                decimal? result = Calculate();					//result adinda decimal ve nullable degisken tanimla ardindan Calculate metodunun sonucunu ona ata
                txtHesap.Text = result.ToString();				//result degiskenini string'e cevir ve txtHesap text`ine ata
                firstInput = result;							//result'u firstInput'a ata
                isDefault = true;								//isDefault'u true'ya cek
            }
            else												//eger yoksa
            {
                firstInput = Convert.ToDecimal(txtHesap.Text);	//txtHesap text`ini decimal'e cevir ve firstInput'a ata
                txtHesap.Clear();								//txtHesap'i temizle
            }
        }
        private void txtHesap_KeyPress(object sender, KeyPressEventArgs e)	//textbox`a girdi oldugunda calisacak metod
        {
            if (char.IsDigit(e.KeyChar) == false)		//eger girilen karakter numerik degilse
            {
                if (e.KeyChar == ',')					//eger girilen karakter ',' ise
                {

                    if (txtHesap.Text.Contains(','))	//eger txtHesap text`i ',' iceriyor ise
                        e.Handled = true;				//basilan tusu gecersiz kil
                }
                else									//eger degilse
                {
                    e.Handled = true;					//basilan tusu gecersiz kil
                }
            }
        }
        public void ClearMethods(bool isTextBoxParam, bool? isDefaultParam, bool firstInputParam)	//herhangi bir temizleme isleminde calisak metod
        {
            if (isTextBoxParam)						//isTextBoxParam true mu
                txtHesap.Clear();					//txtHesap'i temizle

            if (isDefaultParam.HasValue)			//isDefaultParam'da deger var mi
                isDefault = isDefaultParam.Value;	//isDefaultParam'in degerini isDefault'a ata

            if (firstInputParam)					//firstInputParam true mu
                firstInput = null;					//firstInput'u null'a cek
        }
        private decimal? Calculate()										//hesaplama islemlerinin yapildigi metod
        {
            decimal? result = null;												//result adinda decimal ve nullable degisken olustur ve null'a cek
            if (operationtype == "/")											//operationtype "/" mu
                result = firstInput.Value / Convert.ToDecimal(txtHesap.Text);	//txtHesap text`ini decimal'e cevir ve firstInput'u bu degere bol
            if (operationtype == "*")											//operationtype "*" mi
                result = firstInput.Value * Convert.ToDecimal(txtHesap.Text);	//txtHesap text`ini decimal'e cevir ve firstInput'u bu degere carp
            if (operationtype == "-")											//operationtype "-" mi
                result = firstInput.Value - Convert.ToDecimal(txtHesap.Text);	//txtHesap text`ini decimal'e cevir ve firstInput'u bu degere cikart
            if (operationtype == "+")											//operationtype "+" mi
                result = firstInput.Value + Convert.ToDecimal(txtHesap.Text);	//txtHesap text`ini decimal'e cevir ve firstInput'u bu degere topla
            return result;														//metoddan cik
        }
    }
}