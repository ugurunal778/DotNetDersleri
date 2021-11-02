using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace At_Yarisi_v2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region Events
        private List<KeyValuePair<Label, PictureBox>> HorseAndLabel				//HorseAndLabel adinda bir liste tanimla key'i label, value'su PictureBox olsun
        {
            get	//getir
            {
                return GetHorseLabelAndPicture();	//GetHorseLabelAndPicture kismina don
            }
        }
        private void txtAmount_KeyPress(object sender, KeyPressEventArgs e)		//Bahis tutarina rakam yazildiginda 
        {
            TextBoxValidation(e);	//TextBoxValidation metodunu calistir
        }
        private void timer1_Tick(object sender, EventArgs e)					//timer1_Tick her calistiginda 
        {
            KeyValuePair<bool, string> finishResult = MoveHorse();	//MoveHorse degerini tanimlanan finishResult listesine ata
            if (finishResult.Key)									//finishResult'un key'i var ise
            {
                AreyouWin(finishResult.Value);	//AreyouWin metodunu finishResult'in value'suna gore calistir
                ClearGame();					//oyunu temizle
            }
        }
        private void btnCreate_Click(object sender, EventArgs e)				//at olustur butonuna basildiginda
        {
            int horseCount = Convert.ToInt32(txtHorseNum.Text);	//at sayisi girilen txtHorseNum'daki degeri convert edip tanimlanan horseCount degiskenine ata
            if (horseCount > 10)	//eger horseCount 10'dan buyuk ise
            {
                MessageBox.Show("10 attan fazla olusturamazsiniz. ");
            }
            else 					//degilse
            {
                pnlSelection.Visible = true;	//pnlSelection gorunur olsun
                CreateHorses(horseCount);		//CreateHorses metodunu horseCount'a gore calistir
                pnlGame.Visible = true;			//pnlGame gorunur olsun
                SetComboboxValues();			//SetComboboxValues metodunu calistir
            }
        }
        private void txtHorseNum_KeyPress(object sender, KeyPressEventArgs e)	//at sayisi belirtilecek txtHorseNum'a bir deger girildiginde
        {
            TextBoxValidation(e);	//TextBoxValidation metodu calistir
        }
        private void btnPlay_Click(object sender, EventArgs e)					//btnPlay butonuna basildiginda
        {
            var result = BahisInputValidation();	//BahisInputValidation degerini tanimlanan result degiskenine ata
            if (result)								//result true ise
                PlayGame();							//PlayGame metodu calistir
        }
        #endregion

        #region Methods
        private void PlayGame()													//PlayGame metodu
        {
            pnlGame.Visible = true;			//pnlGame gorunur olsun
            PlayGame_CalculateHorseRate();	//PlayGame_CalculateHorseRate metodunu calistir
            timer1.Start();					//timer1 baslat
        }
        private void SetComboboxValues()										//Combobox gederlerinin set edilecegi metod
        {
            cmbPickHorse.Items.Clear();			//cmbPickHorse itemlerini temizle
            int index = 0;						//index degiskeni tanimla degeri 0 olsun
            foreach (var item in HorseAndLabel)	//HorseAndLabel'in tum degiskenlerini gez ve item nesnesine ata
            {
                cmbPickHorse.Items.Insert(index, item.Key.Text);	//item nesnesinin keyinin textini index olarak cmbPickHorse'un itemine insert et
                index++;											//indexi 1 artir
            }
        }
        private void PlayGame_CalculateHorseRate()								//atlarin performansinin belirlenecegi alan
        {
            foreach (var item in HorseAndLabel)	//HorseAndLabel'in tum degerlerini gez ve item nesnesine ata
            {
                Random rnd = new Random();	// random deger olustur ve rnd nesnesine ata
                int rate = rnd.Next(1, 10);	//1-10 arasi random rakam olustur ve rate degiskenine ata
                item.Key.Tag = rate;		//rate degiskenini item nesnesinin keyinin tag'ina yazdir
            }
        }
        private static void TextBoxValidation(KeyPressEventArgs e) 				//Texbox'a giren degerin dogrulugunu kontrol eden metod
        {
            if (char.IsDigit(e.KeyChar) == false)		//girilen karakter numerik rakam degil ise
            {
                if (e.KeyChar != 8)				//girilen karakter backspace'de degilse
                    e.Handled = true;	//girdiyi kabul etme
            }
        }
        public bool BahisInputValidation()										//girilen bahisin dogrulugunu kontrol eden metod
        {
            var result = true;										//result degiskeni tanimla true olsun
            if (cmbPickHorse.SelectedItem == null)					//eger cmbPickHorse'un secilen itemi null ise
            {
                result = false;								//result false olsun
                MessageBox.Show("At secimi yapiniz. ");		//ekranda yazilacak yazi
            }
            else if (string.IsNullOrWhiteSpace(txtAmount.Text))		//degilse ve txtAmount'un text'i IsNullOrWhiteSpace ise
            {
                result = false;								//result false olsun
                MessageBox.Show("Bahis tutari giriniz. ");	//ekranda yazilacak yazdir
            }
            return result;											//result'a gero don
        }
        private void CreateHorses(int horseCount)								//Atlarin olusturuldugu metod
        {
            pnlGame.Controls.Clear();						//pnlGame controllerini temizle
            List<string> horseNames = new List<string>()	//horseNames adinda yeni liste olustur
            {
                "At1", "At2", "At3", "At4", "At5", "At6", "At7", "At8", "At9", "At10"
            };

            for (int i = 0; i < horseCount; i++)			//i degeri horseCount'tan kucuk ise
            {
                Random random = new Random();							//yeni random rakam uret random nesnesine tanimla
                int rndNumber = random.Next(0, horseNames.Count - 1);	//0 ile at sayisinin 1 eksigi arasinda random rakam olusturup rndNumber uzerine yazdir
                string horseNameForLabel = horseNames[rndNumber];		//horseNames[rndNumber] olanini string olarak tanimlanan horseNameForLabel nesnesine ata
                horseNames.RemoveAt(rndNumber);							//horseNames deki (rndNumber) numarali indexi kaldir
                Label lbl = new Label();								//lbl isminde yeni label olustur
                PictureBox pic = new PictureBox();						//pic isminde yeni PictureBox olustur

                lbl.AutoSize = true;
                lbl.Name = "lbl" + horseNameForLabel;
                lbl.Size = new System.Drawing.Size(51, 20);
                lbl.TabIndex = 3;
                lbl.Text = horseNameForLabel;

                pic.ImageLocation = @"F:\.NET Dersleri\Ders tekrarları\At Yarisi\At Yarisi\Image\Horse.gif";
                pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                pic.Location = new System.Drawing.Point(24, 388);
                pic.Name = "pic" + horseNameForLabel;
                pic.Size = new System.Drawing.Size(50, 25);
                pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                pic.TabIndex = 3;
                pic.TabStop = false;

                lbl.Location = new System.Drawing.Point(pnlGame.Location.X, pnlGame.Location.Y + 33 + 50 * i);
                pic.Location = new System.Drawing.Point(pnlGame.Location.X, pnlGame.Location.Y + 50 + 50 * i);

                pnlGame.Controls.Add(pic);
                pnlGame.Controls.Add(lbl);
            }
        }
        public List<KeyValuePair<Label, PictureBox>> GetHorseLabelAndPicture()	//atlarin resimleri ile labellerinin esitlendigi metod
        {
            List<KeyValuePair<Label, PictureBox>> dataList = new List<KeyValuePair<Label, PictureBox>>();	dataList adinda yeni liste olustur
            foreach (var item in pnlGame.Controls)	//pnlGame'in kontrollerini kontrol et ve item nesnesine yazdir
            {
                if (item is Label)	//item'in labeli var mi
                {
                    Label lblHorseName = (Label)item;																						//item'in label'ini lblHorseName adinda label olusturarak ona ata
                    PictureBox pic = (PictureBox)pnlGame.Controls.Find(lblHorseName.Name.Replace("lbl", "pic"), true).FirstOrDefault();		//Tur donusumunu yapip pic adinda PictureBox tanimlayip ona ata

                    dataList.Add(new KeyValuePair<Label, PictureBox>(lblHorseName, pic));													//lblHorseName ve pic datalarini dataList struct'ina ekle
                }
            }
            return dataList;						//dataList'e geri don
        }
        public KeyValuePair<bool, string> MoveHorse()							//atlarin ilerletildigi metod
        {
            Random rnd = new Random();								//rnd isminde yeni random nesnesi olustur
            foreach (var item in HorseAndLabel)						//HorseAndLabel'i kontrol et item'e ata
            {
                int rndLocation = 0;																			//rndLocation degiskeni olustur degeri 0 olsun
                if (item.Key.Text == cmbPickHorse.SelectedItem.ToString() && txtAmount.Text == "50")			//eger item'in key'inin text'i cmbPickHorse'un selectedItem'inin ToString'ine esit mi ve txtAmount'un text'i string 50 ise
                    rndLocation = rnd.Next(15, 20);		//rndLocation'a 15,20 arasinda bir deger ata
                else																							//degilse
                    rndLocation = rnd.Next(0, 20);		//rndLocation'a 0,20 arasinda bir deger ata

                item.Value.Location = new Point(item.Value.Location.X + rndLocation, item.Value.Location.Y);	//item'in value'sunun X lokasyonunu rndLocation kadar artir Y lokasyonu oyle kalsin
                item.Key.Location = new Point(item.Key.Location.X + rndLocation, item.Key.Location.Y);			//item'in key'inin X lokasyonunu rndLocation kadar artir Y lokasyonu oyle kalsin

                if (item.Value.Location.X >= btnfinish.Location.X)												//eger item'in valuesunun X lokasyonu btnfinish'in X lokasyonundan buyuk ise
                    return new KeyValuePair<bool, string>(true, item.Key.Text);	//yeni KeyValuePair olustur key'i true value'su ise item.key.text olsun
            }
            return new KeyValuePair<bool, string>(false, "");		//yeni KeyValuePair olusturup icerisindeki degeri don
        }
        public void AreyouWin(string finihedHorseName)							//kazanilip kazanilmadigini belirleyen metod
        {
            timer1.Stop();																							//timer'i durdur
            Label winnerHorseLabel = (Label)pnlGame.Controls.Find("lbl" + finihedHorseName, true).FirstOrDefault();	//kazanan atin label'ini bul ve olusturulan winnerHorseLabel labeline yaz
            string selectedHorse = cmbPickHorse.SelectedItem.ToString();											//cmbPickHorse'taki secilen ati olusturulan selectedHorse stringine yaz
            if (selectedHorse == winnerHorseLabel.Text)																//eger secilen at ile kazanan at ayni ise
            {
                int calculateProfit = Convert.ToInt32(winnerHorseLabel.Tag) * Convert.ToInt32(txtAmount.Text);									//kazanilan deger hesaplamasini calculateProfit uzerine yaz
                MessageBox.Show("Tebrikler Kazandınız.... Yatırdığınız Tutar " + txtAmount.Text + " Kazandığınız Tutar: " + calculateProfit);	//ekranda yazdir
            }
            else																									//kaybedilirse
            {
                MessageBox.Show("Kazanan At " + winnerHorseLabel.Text + " Kaybetttiniz :) Kaybettiğiniz Tutar " + txtAmount.Text);				//ekrana yazdir
            }
        }
        private void ClearGame()												//oyunu temizleyen metod
        {
            pnlSelection.Visible = false;	//pnlSelection gorunur olmasin
            pnlGame.Visible = false;		//pnlGame gorunur olmasin
            cmbPickHorse.Items.Clear();		//combobox itemlerini temizle
            cmbPickHorse.Text = "";			//combobox textlerini temizle
            txtAmount.Text = "";			//bahis tutari kutusunu temizle
        }
        #endregion
    }
}