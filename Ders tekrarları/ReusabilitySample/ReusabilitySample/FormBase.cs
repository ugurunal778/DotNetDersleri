using BusinessLayer.TextBoxOperations;
using BusinessLayer;
using System.Windows.Forms;

namespace ReusabilitySample
{
    public class FormBase : Form    //Form'dan miras alıyor
    {
        private TextBoxOperationsBusinessLayer _textBoxOperationsBusinessLayer; //TextBoxOperationBusinessLayer üzerinde _textBoxOperationsBusinessLayer adında bir field oluştur
        private BankBusinessLayer _bankBusinessLayer;                           //BankBusinessLayer üzerinde _bankBusinessLayer adında bir field oluştur
        public TextBoxOperationsBusinessLayer TextBoxOperationsBusinessLayer    //TextBoxOperationsBusinessLayer içerisine TextBoxOperationsBusinessLayer adında bir propertty tanımla
        {
            get                                                                     //çağır
            {
                if (_textBoxOperationsBusinessLayer is null)                            //eğer _textBoxOperationsBusinessLayer null ise
                    _textBoxOperationsBusinessLayer = new TextBoxOperationsBusinessLayer(); //TextBoxOperationsBusinessLayer üzerine yeni bir field oluştur ve onu _textBoxOperationsBusinessLayer'e eşitle
                return _textBoxOperationsBusinessLayer;                                 //_textBoxOperationsBusinessLayer değerini dön ve metoddan çık
            }
        }
        public BankBusinessLayer BankBusinessLayerOperation                     //BankBusinessLayer içinde BankBusinessLayerOperation adında bir property tanımla
        {
            get                                                                     //çağır
            {   
                if (_bankBusinessLayer is null)                                         //eğer _bankBusinessLayer null ise
                    _bankBusinessLayer = new BankBusinessLayer();                           //BankBusinessLayer üzerine yeni bir field oluştur ve onu _bankBusinessLayer'e eşitle
                return _bankBusinessLayer;                                              //_bankBusinessLayer değerini dön ve metoddan çık
            }
        }
    }
}
