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
        #region Methods
        private void PlayGame()
        {
            pnlGame.Visible = true;
            PlayGame_CalculateHorseRate();
            timer1.Start();
        }
        private void SetComboboxValues()
        {
            cmbAt.Items.Clear();
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
        public bool BahisInputValidation()
        {
            var result = true;
            if (cmbAt.SelectedItem == null)
            {
                result = false;
                MessageBox.Show("At Seçimini Yapınız");
            }
            else if (string.IsNullOrWhiteSpace(txtBahis.Text))
            {
                result = false;
                MessageBox.Show("Bahis Tutarı Giriniz");
            }
            return result;
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

        }
        private void ClearGame()
        {
            pnlSelection.Visible = false;
            pnlGame.Visible = false;
            cmbAt.Items.Clear();
            cmbAt.Text = "";
            txtBahis.Text = "";
        }
        public KeyValuePair<bool, string> MoveHorse()
        {
            Random rnd = new Random();
            foreach (var item in HorseAndLabel)
            {
                int rndLocation = 0;
                if (item.Key.Text == cmbAt.SelectedItem.ToString() && txtBahis.Text == "50")
                {
                    rndLocation = rnd.Next(15, 20);
                }
                else
                {
                    rndLocation = rnd.Next(0, 20);
                }

                item.Value.Location = new Point(item.Value.Location.X + rndLocation, item.Value.Location.Y);
                item.Key.Location = new Point(item.Key.Location.X + rndLocation, item.Key.Location.Y);

                if (item.Value.Location.X >= button1.Location.X)
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
                return GetHorseLabelAndPicture();

            }
        }
        private void txtBahis_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBoxValidation(e);
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
        private void btnAtOlustur_Click(object sender, EventArgs e)
        {
            int horsecount = Convert.ToInt32(txtHorseCount.Text);
            if (horsecount > 10)
            {
                MessageBox.Show("10 attan fazla oluşturamazsınız");
            }
            else
            {
                pnlSelection.Visible = true;
                CreateHorses(horsecount);
                pnlGame.Visible = true;
                SetComboboxValues();
            }
        }
        private void CreateHorses(int horsecount)
        {
            pnlGame.Controls.Clear();
            List<string> horseNames = new List<string>() { "Ercan", "Serkan", "Akçagül", "Emirhan", "Levent", "Mert", "Uğur", "Abdullah", "Nurullah", "Yusuf" };

            for (int i = 0; i < horsecount; i++)
            {
                Random random = new Random();
                int rndNumber = random.Next(0, horseNames.Count - 1);
                string horseNameForLabel = horseNames[rndNumber];
                horseNames.RemoveAt(rndNumber);
                Label lbl = new Label();
                PictureBox pic = new PictureBox();

                lbl.AutoSize = true;
                lbl.Name = "lbl" + horseNameForLabel;
                lbl.Size = new System.Drawing.Size(51, 20);
                lbl.TabIndex = 3;
                lbl.Text = horseNameForLabel;

                pic.ImageLocation = @"D:\Users\euykan\source\repos\WindowsFormsApp2\WindowsFormsApp2\h.gif";
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
        private void txtHorseCount_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBoxValidation(e);
        }
        private void btnBahisOyna_Click(object sender, EventArgs e)
        {
            var result = BahisInputValidation();
            if (result)
                PlayGame();
        } 
        #endregion
    }
}