using System.Windows.Forms;

namespace BusinessLayer.TextBoxOperations
{
    public partial class TextBoxOperationsBusinessLayer
    {
        public bool TextBoxInputValidate(object sender,  char chr)  //sender nesnesi ve chr char değerine göre textbox girdisini doğrulayacak metod
        {
            var txtbox = (TextBox)sender;                                                           //txtbox adında TextBox oluştur
            var txtTagValue = int.Parse(txtbox.Tag.ToString());                                     //txtbox'ın tag'ını int olarak parse et ve oluşturulan txtTagValue değişkenine ata
            var textBoxInputType = (TextBoxOperationsBusinessLayer.TextBoxInputType)txtTagValue;    //txtTagValue'ya göre TextBoxInputType metodunu çalıştır ve sonucu textBoxInputType değişkenine ata
            if (textBoxInputType == TextBoxInputType.WholeNumber)                                   //eğer textBoxInputType WholeNUmberise
            {
                if (chr != 08 && !char.IsDigit(chr))        //eğer chr backspace değil ve numerik değilse
                    return false;                               //false dön ve metoddan çık
                return true;                                //true dön ve metoddan çık
            }                                
            else if (textBoxInputType == TextBoxInputType.DecimalNumber)                            //eğer textBoxInputType DecimalNumber ise
            {
                if (chr != 08)                              //eğer chr backspace değil ise
                {
                    if (chr == 46)                              //eğer chr nokta ise
                    {
                        if (txtbox.Text.Length == 0)                //eğer textbox'daki text'in uzunluğu 0'dan büyük ise
                            return false;                               //false dön ve metoddan çık
                        else if (txtbox.Text.Contains("."))         //eğer textbox'daki text "." içeriyorsa
                            return false;                               //false dön ve metoddan çık
                    }
                    else if (!char.IsDigit(chr))                //eğer chr numerik değil ise
                        return false;                               //false dön ve metoddan çık
                }
                return true;                                //true dön ve metoddan çık
            }                         
            else if (textBoxInputType == TextBoxInputType.OnlyText)                                 //eğer textBoxInputType OnlyText ise
            {
                if (chr != 08 && char.IsDigit(chr))         //eğer chr backspace değil ise ve chr numarik değil ise
                    return false;                               //false dön  ve metoddan çık
                return true;                                //true dön  ve metoddan çık
            }
            else                                                                                   //eğer hiçbiri değil ise    
                return false;                               //false dön  ve metoddan çık
        }
    }
}