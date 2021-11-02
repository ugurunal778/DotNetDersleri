using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Mayin_Tarlasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        #region Data	
        List<int> mineIndex = new List<int>();											//mineIndex adinda yeni bir integer liste olustur
        List<GameData> gameDatas = new List<GameData>									//GameData class'i uzerinde gameDatas adinda yeni bir liste olustur
        {
            new GameData()	//Kolay icin set edilecek ayarlar
            {
                Difficulty = "Kolay",	//Zorluk ismi
                ButtonCount = 50,		//buton sayisi
                Width = 200,			//Panel genisligi
                Height = 160,			//Panel yuksekligi
                Index = 0,				//zorluk seviyesinin cagirilacagi index
                MineCount = 10,			//mayin sayisi
            },
            new GameData()	//Orta icin set edilecek ayarlar
            {
                Difficulty = "Orta",
                ButtonCount = 75,
                Width = 350,
                Height = 190,
                Index = 1,
                MineCount = 25,
            },
            new GameData()	//Zor icin set edilecek ayarlar
            {
                Difficulty = "Zor",
                ButtonCount = 100,
                Width = 500,
                Height = 220,
                Index = 2,
                MineCount = 50,
            }

        };
        #endregion

        #region Events
        private void Form1_Load(object sender, EventArgs e)								//from1 loadina gore calisacak metod
        {
            setCmbDifficulty();	//combobox uzerinde gosterilecek zorluklari belirleyen metodu cagir
        }
        private void CmbDifficulty_SelectedIndexChanged(object sender, EventArgs e)		//combobox uzerinde zorluk degistirildigi zaman calisacak metod
        {
            GameData selectedDifficulty = gameDatas[CmbDifficulty.SelectedIndex];	//gameDatas'daki zorluk seviyesinin index'ini GameData uzerinde oluturulan selectedDifficulty nesnesine esitle
            CreateGame(selectedDifficulty);											//CreateGame metodunu selectedDifficulty'ye gore calistir
        }
        private void BtnClicked(object sender, EventArgs e)								//ekrandaki butonlar abasildiginda yapilacak islemleri belirleyen betod
        {
            Button btn = (Button)sender;			//sender event'i ile btn adinda yeni buton olustur
            btn.Enabled = false;					//buton aktif olmasin
            SetMineResult(btn.ImageList != null);	//butonun imajina gore SetMineResult metodu calissin
        }
        private void SetMineResult(bool isExistMine)									//Butonlarda mayin olup olmayacagini belirleyen metod
        {
            bool isWin = true;									//bool tipinde isWin degiskeni olustur degeri true olsun
            foreach (var item in flowLayoutPanel1.Controls)		//flowLayoutPanel1'in tum kontrollerini don ve item nesnesine ata
            {
                Button btnEach = (Button)item;				//btnEach adinda yeni bit buton nesnesi olustur
                if (isExistMine)							//eger mayin var ise 
                {
                    if (btnEach.ImageList != null)		//eger butonun imaji bos degil ise
                    {				
                        btnEach.ImageIndex = 0;		//btnEach ImageIndex'i 0 olsun
                        btnEach.Enabled = false;	//btnEach aktif olmasin
                        Thread.Sleep(100);			//100ms bekle 
                    }
                }
                else										//eger mayin yok ise
                {
                    if (btnEach.ImageList == null)		//eger buton imaji bo ise
                    {
                        if (btnEach.Enabled)		//btnEach aktif ise
                            isWin = false;			//isWin false olsun
                    }
                }
            }
            SendMessage(isExistMine, isWin);					//isExistMine ve isWin degerlerine gore SendMessage metodunu cagir
        }
        private static void SendMessage(bool isExistMine, bool isWin)					//sonucun ciktisini ekrana gonderecek olan metod
        {
            if (isExistMine)											//isExistMine true ise
			{
                MessageBox.Show("Kaybettiniz. ");					//ekrana yazdir
			}
            else														//degil ise
            {
                if (isWin)											//isWin tru ise
                    MessageBox.Show("Tebrikler Kazandiniz. ");	//mesajini yazdir
            }
        }
        #endregion

        #region Methods
        private void setCmbDifficulty()													//combobox uzerinde gosterilecek zorluklari belirleyen metod
        {
            for (int i = 0; i < gameDatas.Count; i++)								//i gameDatas'in Count'undan kucuk ise donguyu bir artir 
            {															
                CmbDifficulty.Items.Insert(i, gameDatas[i].Difficulty);			//gameDatas'in [i]'ninci indexinin Difficulty degerini CmbDifficulty'nin itemine insert et
            }
        }
        private void SetFlowlayouProperties(GameData selectedDifficulty)				//flowLayoutPanel1'in ozelliklerini belirleyen metod
        {
            flowLayoutPanel1.Controls.Clear();										//flowLayoutPanel1 kontrollerini temizle
            flowLayoutPanel1.Visible = true;										//flowLayoutPanel1 gorunurlugunu aktif et
            flowLayoutPanel1.Width = selectedDifficulty.Width;						//flowLayoutPanel1 genisligini selectedDifficulty'nin Width'ine gore ayarla
            flowLayoutPanel1.Height = selectedDifficulty.Height;					//flowLayoutPanel1 yuksekligini selectedDifficulty'nin Height'ine gore ayarla
        }
        private void CreateButtonsToFlowLayoutControl(GameData selectedDifficulty)		//flowLayoutPanel1 uzerinde butonlari olusturan metod
        {
            for (int i = 0; i < selectedDifficulty.ButtonCount; i++)				//i selectedDifficulty'nin buton sayisindan az ise donguye gir ve i'yi 1 artir
            {
                bool isExistImage = mineIndex.Contains(i);						//mineIndex'in contains'inin i degerini tanimlanan isExistMine degiskenine ata
                GenerateButtons(i, isExistImage);								//i ve isExistMine sonucuna gore GenerateButtons metodu ile buton olustur
            }
        }
        private void GenerateButtons(int i, bool isExistImage)							//butonlarin ozelliklerini belirleyen metod
        {
            Button btn = new Button													//asagidaki parametrelere gore btn adinda yeni bir buton nesnesi olustur
            {
                Location = new Point(40 + 36 * i, 12),							//olusturularcak lokasyonun bir onceki butondan ileride olmasini sagliyor
                Name = "btn" + i,												//butonun adi btn+[i] olacak sakilde set ediliyor
                Size = new Size(30, 26),										//butonun boyutu ayarlaniyor
                UseVisualStyleBackColor = true,									//gorsel olarak arkaplan rengi aktif ediliyor
                ImageList = isExistImage ? ımageList1 : null					//isExistImage durumuna gore butonda imaj olup olmayacagi belirleniyor
            };
            btn.Click += new EventHandler(BtnClicked);								//butona basidiginda olusacak event BtnClickedmetodu uzerinde EventHandler olarak ayarlaniyor
            flowLayoutPanel1.Controls.Add(btn);										//flowLayoutPanel1'in kontrollerine btn nesnesi ekleniyor
        }
        private void CreateGame(GameData selectedDifficulty)							//oyunu asamali olarak baslatan metod
        {
            SetFlowlayouProperties(selectedDifficulty);								//selectedDifficulty'ye gore flowLayoutPanel1 icin ayarlamalarin yapildigi metod cagiriliyor
            SetSelectedDifficultyMineIndex(selectedDifficulty);						//selectedDifficulty'ye gore mayin indexlerinin oldugu metod cagiriliyor
            CreateButtonsToFlowLayoutControl(selectedDifficulty);					//selectedDifficulty'ye gore flowLayoutPanel1 uzerinde olusturulacak butonlarin ayarlandigi metod cagiriliyor
        }
        private void SetSelectedDifficultyMineIndex(GameData selectedDifficulty)		//secilen zorluk seviyesine gore mayin sayisini ayarlayan metod
        {
            Random rnd = new Random();														//rnd adinda yeni bir random nesne olustur
            for (int i = 0; i < selectedDifficulty.MineCount; i++)							//selectedDifficulty'nin MineCount'una gelene kadar donguye gir ve i'yi 1 artir 
            {
                int rndNumber = rnd.Next(0, selectedDifficulty.ButtonCount - 1);				//rnd nesnesi ile 0 ve secilen zorlugun buton sayisinin 1 eksigi arasinda rastgele bir sayi olustur ve onu olusturulan rndNumber degiskenine ata
                if (mineIndex.Contains(rndNumber))												//mineIndex bu rndNumber'i iceriyor ise
                    i--;																			//i'yi 1 azalt
                else																			//icermiyorsa
                    mineIndex.Add(rndNumber);														//mineIndex'e bu rndNumber'i ekle
            }
        }
        #endregion
    }
}