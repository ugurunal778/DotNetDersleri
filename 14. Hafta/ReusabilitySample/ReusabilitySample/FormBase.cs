using BusinessLayer;
using BusinessLayer.TextBoxOperations;
using System.Windows.Forms;

namespace ReusabilitySample
{
    public class FormBase : Form
    {
        private TextBoxOperationsBusinessLayer _textBoxOperationsBusinessLayer;
        private BankBusinessLayer _bankBusinessLayer;
        public TextBoxOperationsBusinessLayer TextBoxOperationsBusinessLayerOperation
        {
            get
            {
                if (_textBoxOperationsBusinessLayer is null)
                    _textBoxOperationsBusinessLayer = new TextBoxOperationsBusinessLayer();
                return _textBoxOperationsBusinessLayer;
            }
        }
        public BankBusinessLayer BankBusinessLayerOperation
        {
            get
            {
                if (_bankBusinessLayer is null)
                    _bankBusinessLayer = new BankBusinessLayer();
                return _bankBusinessLayer;
            }
        }
    }
}