using BusinessLayer.TextBoxOperations;
using System.Windows.Forms;

namespace ReusabilitySample
{
    public partial class Form1 : FormBase
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void TextBoxKeyPressValidation(object sender, KeyPressEventArgs e)
        {
            e.Handled = !TextBoxOperationsBusinessLayerOperation.TextBoxInputValidate((TextBox)sender, e.KeyChar);
        }

    }
}
