using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralObserver
{
    //Subject
    abstract class absUrun
    {
        public string UrunAdi { get; set; }
        private decimal _Fiyat;
        /*Direkt erişim yerine private tanımlanıp, tanımlanacak metotlar ile yapılabilir.*/
        //Observer nesne listesi
        public List<IUye> TakipList = new List<IUye>();
        public absUrun(string UrunAd, decimal UrunFiyat)
        {
            this.UrunAdi = UrunAd;
            this._Fiyat = UrunFiyat;
        }
        public decimal Fiyat
        {
            get { return _Fiyat; }
            set
            {
                //fiaytı düşmüş ise üyelere haber ver
                if (_Fiyat != value)
                    NotifyUrun();
                _Fiyat = value;
            }
        }
        public void NotifyUrun()
        {
            foreach (IUye item in TakipList)
            {
                item.Update(this);
            }
        }
    }
}
