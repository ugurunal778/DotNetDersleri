using System.Windows.Forms;

namespace BusinessLayer.TextBoxOperations
{
    public class TextBoxOperationsBusinessLayer
    {
        public bool TextBoxInputValidate(TextBox sender, char chr)
        {
            var txtTagValue = int.Parse(sender.Tag.ToString());
            var textBoxInputType = (TextBoxInputType)txtTagValue;

            if (textBoxInputType == TextBoxInputType.WholeNumber)
            {
                if (chr != 08)
                {
                    if (!char.IsDigit(chr))
                        return false;
                }
                return true;
            }
            else if (textBoxInputType == TextBoxInputType.DecimalNumber)
            {
                if (chr != 08)
                {
                    if (chr == 46)
                    {
                        if (sender.Text.Length == 0)
                            return false;
                        else if (sender.Text.Contains("."))
                            return false;
                    }
                    else if (!char.IsDigit(chr))
                        return false;
                }
                return true;
            }
            else if (textBoxInputType == TextBoxInputType.OnlyText)
            {
                if (chr != 08)
                {
                    if (char.IsDigit(chr))
                        return false;
                }
                return true;
            }
            else if (textBoxInputType == TextBoxInputType.All)
            {
                return true;
            }
            else
                return false;
        }
    }
}
