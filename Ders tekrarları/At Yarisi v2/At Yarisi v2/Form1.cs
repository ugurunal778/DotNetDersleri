using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
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
        private List<KeyValuePair<Label, PictureBox>> HorseAndLabel
        {
            get
            {
                return GetHorseLabelAndPicture();
            }
        }
        private void txtAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBoxValidation(e);
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            KeyValuePair<bool, string> finishResult = MoveHorse();
            if (finishResult.Key)
            {
                AreyouWin(finishResult.Value);
                ClearGame();
            }
        }
        private void btnCreate_Click(object sender, EventArgs e)
        {
            int horseCount = Convert.ToInt32(txtHorseNum.Text);
            if (horseCount > 10)
            {
                MessageBox.Show("10 attan fazla olusturamazsiniz. ");
            }
            else
            {
                pnlSelection.Visible = true;
                CreateHorses(horseCount);
                pnlGame.Visible = true;
                SetComboboxValues();
            }
        }
        private void txtHorseNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBoxValidation(e);
        }
        private void btnPlay_Click(object sender, EventArgs e)
        {
            var result = BahisInputValidation();
            if (result)
                PlayGame();
        }
        #endregion

        #region Methods
        private void PlayGame()
        {
            pnlGame.Visible = true;
            PlayGame_CalculateHorseRate();
            timer1.Start();
        }
        private void SetComboboxValues()
        {
            cmbPickHorse.Items.Clear();
            int index = 0;
            foreach (var item in HorseAndLabel)
            {
                cmbPickHorse.Items.Insert(index, item.Key.Text);
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
            if (cmbPickHorse.SelectedItem == null)
            {
                result = false;
                MessageBox.Show("At secimi yapiniz. ");
            }
            else if (string.IsNullOrWhiteSpace(txtAmount.Text))
            {
                result = false;
                MessageBox.Show("Bahis tutari giriniz. ");
            }
            return result;
        }
        private void CreateHorses(int horseCount)
        {
            pnlGame.Controls.Clear();
            List<string> horseNames = new List<string>()
            {
                "At1", "At2", "At3", "At4", "At5", "At6", "At7", "At8", "At9", "At10"
            };

            for (int i = 0; i < horseCount; i++)
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
                int rndLocation = 0;
                if (item.Key.Text == cmbPickHorse.SelectedItem.ToString() && txtAmount.Text == "50")
                    rndLocation = rnd.Next(15, 20);
                else
                    rndLocation = rnd.Next(0, 20);

                item.Value.Location = new Point(item.Value.Location.X + rndLocation, item.Value.Location.Y);
                item.Key.Location = new Point(item.Key.Location.X + rndLocation, item.Key.Location.Y);

                if (item.Value.Location.X >= btnfinish.Location.X)
                    return new KeyValuePair<bool, string>(true, item.Key.Text);
            }
            return new KeyValuePair<bool, string>(false, "");
        }
        public void AreyouWin(string finihedHorseName)
        {
            timer1.Stop();
            Label winnerHorseLabel = (Label)pnlGame.Controls.Find("lbl" + finihedHorseName, true).FirstOrDefault();
            string selectedHorse = cmbPickHorse.SelectedItem.ToString();
            if (selectedHorse == winnerHorseLabel.Text)
            {
                int calculateProfit = Convert.ToInt32(winnerHorseLabel.Tag) * Convert.ToInt32(txtAmount.Text);
                MessageBox.Show("Tebrikler Kazandınız.... Yatırdığınız Tutar " + txtAmount.Text + " Kazandığınız Tutar: " + calculateProfit);
            }
            else
            {
                MessageBox.Show("Kazanan At " + winnerHorseLabel.Text + " Kaybetttiniz :) Kaybettiğiniz Tutar " + txtAmount.Text);
            }
        }
        private void ClearGame()
        {
            pnlSelection.Visible = false;
            pnlGame.Visible = false;
            cmbPickHorse.Items.Clear();
            cmbPickHorse.Text = "";
            txtAmount.Text = "";
        }
        #endregion
    }
}