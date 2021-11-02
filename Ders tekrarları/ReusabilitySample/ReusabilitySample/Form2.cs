using System;
using System.Windows.Forms;

namespace ReusabilitySample
{
    public partial class Form2 : FormBase   //FormBase'den miras alıyor
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void TextBoxKeyPressValidation(object sender, KeyPressEventArgs e)  //keypress olduğunda çalışcak metod
        {
            e.Handled = !TextBoxOperationsBusinessLayer.TextBoxInputValidate(sender, e.KeyChar);
        }

        private void btnParaYatir_Click(object sender, EventArgs e)                 //parayatırma butonuna tıklandığında çalışacak metod
        {
            var result = BankBusinessLayerOperation.ParaYatir(Convert.ToInt32(txtFromId.Text), Convert.ToInt32(textBox1.Text), Convert.ToDecimal(txtOndalıkli.Text));   //textbox girdilerini dönüştürüp ParaYatir metodunu çalıştırıp sonucu result değişkenine atar
            if (result == false)                                                                                                                                        //eğer result false ise
                MessageBox.Show("Bakiyeniz yeterli degildir.");                                                                                                      //ekranda göster
            else                                                                                                                                                        //değilse
                MessageBox.Show("Islem Basarili.");                                                                                                                  //ekranda göster
        }
    }
}