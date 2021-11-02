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
        private List<KeyValuePair<Label, PictureBox>> _horseandlabel;

        #region Events
        private List<KeyValuePair<Label, PictureBox>> HorseAndLabel
        {
            get
            {
                if (_horseandlabel is null)
                    _horseandlabel = GetHorseLabelAndPicture();
                return _horseandlabel;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            SetComboboxValues();
        }
        private void txtAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBoxValidation(e);
        }
        private void btnPlay_Click(object sender, EventArgs e)
        {
            BahisInputValidation();
            Playgame();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            KeyValuePair<bool, string> finishResult = MoveHorse();
            if (finishResult.Key)
            {
                AreYouWin(finishResult.Value);
                ClearGame();
            }
        } 
        #endregion


        #region Methods
        public List<KeyValuePair<Label, PictureBox>> GetHorseLabelAndPicture()
        {
            List<KeyValuePair<Label, PictureBox>> dataList = new List<KeyValuePair<Label, PictureBox>>();
            foreach (var item in pnlGame.Controls)
            {
                if (item is Label)
                {
                    Label lblHorseName = (Label)item;
                    PictureBox pic = (PictureBox)pnlGame.Controls.Find(lblHorseName.Name.Replace("lbl", "pic"), true).FirstOrDefault();

                    dataList.Add(new KeyValuePair<Label, PictureBox>(lblHorseName, pic));
                }
            }
            return dataList;
        }
        public KeyValuePair<bool, string> MoveHorse()
        {
            Random rnd = new Random();
            foreach (var item in HorseAndLabel)
            {
                int rndLocation = rnd.Next(1, 20);
                item.Value.Location = new Point(item.Value.Location.X + rndLocation, item.Value.Location.Y);
                item.Key.Location = new Point(item.Key.Location.X + rndLocation, item.Key.Location.Y);
                if (item.Value.Location.X >= picFinish.Location.X)
                    return new KeyValuePair<bool, string>(true, item.Key.Text);
            }
            return new KeyValuePair<bool, string>(false, "");
        }
        private void Playgame()
        {
            pnlGame.Visible = true;
            PlayGame_CalculateHorseRate();
            timer1.Start();

        }
        private void SetComboboxValues()
        {
            int index = 0;
            foreach (var item in HorseAndLabel)
            {
                cmbHorse.Items.Insert(index, item.Key.Text);
                index++;
            }
        }
        private void PlayGame_CalculateHorseRate()
        {
            foreach (var item in HorseAndLabel)
            {
                Random rnd = new Random();
                int rate = rnd.Next(1, 10);
                item.Key.Tag = rate;
            }
        }
        private static void TextBoxValidation(KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false)
            {
                if (e.KeyChar != 8)
                    e.Handled = true;
            }
        }
        public void BahisInputValidation()
        {
            if (cmbHorse.SelectedItem == null)
            {
                MessageBox.Show("At secimi yapiniz.");
                Environment.Exit(0);
            }
            if (string.IsNullOrWhiteSpace(txtAmount.Text))
            {
                MessageBox.Show("Bahis tutari giriniz.");
                Environment.Exit(0);
            }
        }
        public void AreYouWin(string finishHorseName)
        {
            timer1.Stop();
            Label winnerHorseLabel = (Label)pnlGame.Controls.Find("lbl" + finishHorseName, true).FirstOrDefault();
            string selectedHorse = cmbHorse.SelectedIndex.ToString();
            if (selectedHorse == winnerHorseLabel.Text)
            {
                int calculateProfit = Convert.ToInt32(winnerHorseLabel.Tag) * Convert.ToInt32(txtAmount.Text);
                MessageBox.Show("Tebrikler kazandiniz. Yatirdiginiz tutar: " + txtAmount.Text + "Kazandiginiz tutar: " + calculateProfit);
            }
            else
            {
                MessageBox.Show("Kazanan at: " + winnerHorseLabel.Text + " Kaybettiginiz Tutar: " + txtAmount.Text);
            }
            pnlGame.Visible = false;
        }
        private void ClearGame()
        {
            foreach (var item in HorseAndLabel)
            {
                item.Key.Location = new Point(pnlGame.Location.X, item.Key.Location.Y);
                item.Value.Location = new Point(pnlGame.Location.X, item.Key.Location.Y);
            }
        }
        #endregion
    }
}
