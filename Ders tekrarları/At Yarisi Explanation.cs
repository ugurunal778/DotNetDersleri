using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace At_Yarisi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private List<KeyValuePair<Label, PictureBox>> _horseandlabel;	//horseandlabel adinda list olustur key'i label, value'su PictureBox olsun

        #region Events
        private List<KeyValuePair<Label, PictureBox>> HorseAndLabel	//HorseAndLabel adlinda list olustur key'i label, value'su PictureBox olsun
        {
            get														//su degerleri getir
            {
                if (_horseandlabel is null)							//eger _horseandlabel null ise 
                    _horseandlabel = GetHorseLabelAndPicture();		//GetHorseLabelAndPicture degerini _horseandlabel'e ata
                return _horseandlabel;								//_horseandlabel'a geri don
            }
        }
        private void Form1_Load(object sender, EventArgs e)	//Form1'in load'ini cek
        {
            SetComboboxValues();	//SetComboboxValues metodunu getir
        }
        private void txtAmount_KeyPress(object sender, KeyPressEventArgs e)	//txtAmount'a girdi oldugunda calisacak metod
        {
            TextBoxValidation(e);	//girilen degeri "e" uzerine ata ve TextBoxValidation metodunu calistir
        }
        private void btnPlay_Click(object sender, EventArgs e)	//btnPlay butonuna basildiginda calisacak metod
        {
            BahisInputValidation();	//BahisInputValidation metodunu cagir
            Playgame();				//Playgame metodunu cagir
        }
        private void timer1_Tick(object sender, EventArgs e)	//timer1 her arttiginda calisacak metod
        {
            KeyValuePair<bool, string> finishResult = MoveHorse();	//finishResult adinda bir struct olustur key'i bool, value'su string olsun ve MoveHorse struct'inin ciktisini buna ata
            if (finishResult.Key)				//finishResult key'i true mu
            {
                AreYouWin(finishResult.Value);	//AreYouWin metodunu finishResult value'suna gore calistir
                ClearGame();					//ClearGame metodunu cagir
            }
        } 
        #endregion


        #region Methods
        public List<KeyValuePair<Label, PictureBox>> GetHorseLabelAndPicture()	//GetHorseLabelAndPicture adinda list olustur key'i label, value'su PictureBox olsun
        {
            List<KeyValuePair<Label, PictureBox>> dataList = new List<KeyValuePair<Label, PictureBox>>();	//dataList adinda yeni list olustur key'i label, value'su PictureBox olsun
            foreach (var item in pnlGame.Controls)	//pnlGame'in control parametrelerinin hepsini kontrol et ve item degiskenine ata
            {
                if (item is Label)	//eger item degiskeni Label ise
                {
                    Label lblHorseName = (Label)item;																						//lblHorseName adinda bir Label tanimla ve item'i ona yazdir
                    PictureBox pic = (PictureBox)pnlGame.Controls.Find(lblHorseName.Name.Replace("lbl", "pic"), true).FirstOrDefault();		//Tur donusumunu yapip pic adinda PictureBox tanimlayip ona ata
		
                    dataList.Add(new KeyValuePair<Label, PictureBox>(lblHorseName, pic));													//lblHorseName ve pic datalarini dataList struct'ina ekle
                }
            }
            return dataList;	//dataList struct'ina geri don
        }
        public KeyValuePair<bool, string> MoveHorse()	//MoveHorse adinda struct olustur key'i label value'su string olsun
        {
            Random rnd = new Random();				//rnd adinda yeni bir random nesne olustur
            foreach (var item in HorseAndLabel)		//HorseAndLabel'in tum parametrelerini kontrol et ve item'a ata
            {
                int rndLocation = rnd.Next(1, 20);																//ilerlemek icin 1-20 arasinda rastgele lokasyon olustur
                item.Value.Location = new Point(item.Value.Location.X + rndLocation, item.Value.Location.Y);	//nesnenin value'sunun y konumu sabit kalsin X konumunu rndLocation kadar ilerlet
                item.Key.Location = new Point(item.Key.Location.X + rndLocation, item.Key.Location.Y);			//nesnenin Key'inin y konumu sabit kalsin X konumunu rndLocation kadar ilerlet
                if (item.Value.Location.X >= picFinish.Location.X)												//eger nesnenin value'sunun konumu picFinish'den buyuk veya esit ise
                    return new KeyValuePair<bool, string>(true, item.Key.Text);	//nesnenin key'inin text'ini yeni struct olarak don
            }
            return new KeyValuePair<bool, string>(false, ""); //yeni struct degeri don
        }
        private void Playgame()	//playgame metodu
        {
            pnlGame.Visible = true;				//pnlGame'i gorunur yap
            PlayGame_CalculateHorseRate();		//PlayGame_CalculateHorseRate metodunu calistir
            timer1.Start();						//timer1'i baslat

        }
        private void SetComboboxValues()	//combobox girdileri ayarlanacak olan metod
        {
            int index = 0;						//index degiskeni ayarla ve degeri 0 olsun
            foreach (var item in HorseAndLabel)	//HorseAndLabel'in tum parametrelerini gez ve item nesnesine ata
            {
                cmbHorse.Items.Insert(index, item.Key.Text);	//HorseAndLabel icerisinde donen label'lari cmbHorse itemleri icerisine insert et
                index++;										//index'i 1 artir
            }
        }
        private void PlayGame_CalculateHorseRate()	//atlarin ilerleme hizlarini belirleyecek metod
        {
            foreach (var item in HorseAndLabel)	//HorseAndLabel icerisindeki parametrelerini gez ve item uzerine ata
            {
                Random rnd = new Random();		//rnd adinda random bir nesne tanimla
                int rate = rnd.Next(1, 10);		//rate adinda bir value type tanimla ve 1-10 arasinda bir deger ver
                item.Key.Tag = rate;			//nesnenin key'inin tagini rate kadar artir
            }
        }
        private static void TextBoxValidation(KeyPressEventArgs e)	//"e"deki gonderilen degere gore texbox uzerinde dogrulama yapacak metod
        {
            if (char.IsDigit(e.KeyChar) == false)	//gelen "e" degiskeni numerik degil ise
            {
                if (e.KeyChar != 8)		//gelen deger backspace degil ise (backspace'in ondalik karsiligi 8'dir)
                    e.Handled = true;	//girdi kabul etme
            }
        }
        public void BahisInputValidation()	//bahis gidrilerinin dogrulamasi yapilacak kisim
        {
            if (cmbHorse.SelectedItem == null)				//cmbHorse uzerinde secim yapilmadi ise
            {
                MessageBox.Show("At secimi yapiniz.");			//ekrana yazilacak kisim
                Environment.Exit(0);							//islemi sonlandir ve isletim sistemine cikis kodu dondur
            }
            if (string.IsNullOrWhiteSpace(txtAmount.Text))	//txtAmount uzerine herhangi bir deger yazilmadi ise
            {
                MessageBox.Show("Bahis tutari giriniz.");		//ekrana yazilacak kisim
                Environment.Exit(0);							//islemi sonlandir ve isletim sistemine cikis kodu dondur
            }
        }
        public void AreYouWin(string finishHorseName)	//Bahisin kazanilip kazanilmadigini sorgu alcak kisim
        {
            timer1.Stop();																							//timer1'i durdur
            Label winnerHorseLabel = (Label)pnlGame.Controls.Find("lbl" + finishHorseName, true).FirstOrDefault();	//winnerHorseLabel adinda bir Label tanimla ve timer1_Tick metodundan gelen gelen degere gore kazanan atin lamet'ini bu label'a ata
            string selectedHorse = cmbHorse.SelectedIndex.ToString();												//cmbHorse'taki secilen ati selectedHorse degiskenine ata
            if (selectedHorse == winnerHorseLabel.Text)																//secilen at ile kazanan at ayni mi
            {
                int calculateProfit = Convert.ToInt32(winnerHorseLabel.Tag) * Convert.ToInt32(txtAmount.Text);								//elde edilen kazanci hesapla ve calculateProfit uzeirne yaz
                MessageBox.Show("Tebrikler kazandiniz. Yatirdiginiz tutar: " + txtAmount.Text + "Kazandiginiz tutar: " + calculateProfit);	//ekranda verielcek cikti
            }
            else																									//ayni degil ise
            {
                MessageBox.Show("Kazanan at: " + winnerHorseLabel.Text + " Kaybettiginiz Tutar: " + txtAmount.Text);						//ekranda verilecek cikti
            }
            pnlGame.Visible = false;																				//penelin gorunurlugunu kapat
        }
        private void ClearGame()	//oyunu sifirlayacak metod
        {
            foreach (var item in HorseAndLabel)	//HorseAndLabel icerisindeki tum parametrelerinigez ve item nesnesi uzerine ata
            {
                item.Key.Location = new Point(pnlGame.Location.X, item.Key.Location.Y);		//Item nesnenin key lokasyonunu sifirla
                item.Value.Location = new Point(pnlGame.Location.X, item.Key.Location.Y);	//Item nesnenin value lokasyonunu sifirla
            }
        }
        #endregion
    }
}
