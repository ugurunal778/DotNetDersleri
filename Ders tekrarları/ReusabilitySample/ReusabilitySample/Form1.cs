using BusinessLayer.TextBoxOperations;
using System;
using System.Windows.Forms;

namespace ReusabilitySample
{ 
    public partial class Form1 : FormBase   //FormBase'den miras alıyor
    {
        public Form1()
        {
            InitializeComponent();
        }
        int x = 15;
        Math.Sin(x);
        private void TextBoxKeyPressValidation(object sender, KeyPressEventArgs e)  //sender objesi ile e keypressevent'i oluşturup bunlara göre textbox girdilerinde çalışacak event
        {
            e.Handled = !TextBoxOperationsBusinessLayer.TextBoxInputValidate(sender, e.KeyChar);    //e'nin keychar'ını TextBoxInputValidate metoduna göre çalıştır ve sonucu e.handled'ı çalıştır ve girdileri engelle
        }
    }
}