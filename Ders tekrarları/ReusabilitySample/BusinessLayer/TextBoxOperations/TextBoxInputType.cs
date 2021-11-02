namespace BusinessLayer.TextBoxOperations
{
    public partial class TextBoxOperationsBusinessLayer
    {
        public enum TextBoxInputType //textbox'ların etiketlerine göre ENUM'larını alacak metod
        {
            WholeNumber=0,      //tag 0 ise 
            DecimalNumber=1,    //tag 1 ise
            OnlyText=2,         //tag 2 ise
            All=3               //tag 3 ise
        }
    }
}
