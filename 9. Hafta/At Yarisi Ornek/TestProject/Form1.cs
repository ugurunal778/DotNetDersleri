using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace TestProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private List<KeyValuePair<Label, PictureBox>> _horseandlabel;
        #region Methods
        private void PlayGame()
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
                cmbAt.Items.Insert(index, item.Key.Text);
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
            if (cmbAt.SelectedItem == null)
            {
                MessageBox.Show("At Seçimini Yapınız");
                Environment.Exit(0);
            }
            if (string.IsNullOrWhiteSpace(txtBahis.Text))
            {
                MessageBox.Show("Bahis Tutarı Giriniz");
                Environment.Exit(0);
            }
        }

        public List<KeyValuePair<Label, PictureBox>> GetHorseLabelAndPicture()
        {
            List<KeyValuePair<Label, PictureBox>> dataList = new List<KeyValuePair<Label, PictureBox>>();
            foreach (var item in pnlGame.Controls)
            {
                if (item is Label)
                {
                    Label lblAtName = (Label)item;
                    PictureBox pic = (PictureBox)pnlGame.Controls.Find(lblAtName.Name.Replace("lbl", "pic"), true).FirstOrDefault();

                    dataList.Add(new KeyValuePair<Label, PictureBox>(lblAtName, pic));
                }
            }
            return dataList;
        }

        public void AreYouWin(string finishedHorseName)
        {
            timer1.Stop();
            Label winnerHorseLabel = (Label)pnlGame.Controls.Find("lbl" + finishedHorseName, true).FirstOrDefault();
            string selectedHorse = cmbAt.SelectedItem.ToString();
            if (selectedHorse == winnerHorseLabel.Text)
            {
                int calculateProfit = Convert.ToInt32(winnerHorseLabel.Tag) * Convert.ToInt32(txtBahis.Text);
                MessageBox.Show("Tebrikler Kazandınız.... Yatırdığınız Tutar " + txtBahis.Text + " Kazandığınız Tutar: " + calculateProfit);
            }
            else
            {
                MessageBox.Show("Kazanan At " + winnerHorseLabel.Text + " Kaybetttiniz :) Kaybettiğiniz Tutar " + txtBahis.Text);
            }
            pnlGame.Visible = false;
        }
        private void ClearGame()
        {
            foreach (var item in HorseAndLabel)
            {
                item.Key.Location = new Point(pnlGame.Location.X, item.Key.Location.Y);
                item.Value.Location = new Point(pnlGame.Location.X, item.Value.Location.Y);
            }
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
                {
                    return new KeyValuePair<bool, string>(true, item.Key.Text);
                }
            }
            return new KeyValuePair<bool, string>(false, "");
        }
        #endregion

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

        private void txtBahis_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBoxValidation(e);
        }

        private void btnBahisOyna_Click(object sender, EventArgs e)
        {
            BahisInputValidation();
            PlayGame();
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
    }
}
