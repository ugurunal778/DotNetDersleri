using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace WindowsFormsApp2
{

    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        List<GameData> gameDatas = new List<GameData>
            {
                new GameData()
                {
                    Difficulty = "Kolay",
                    ButtonCount = 50,
                    Width = 200,
                    Height = 160
                },
                new GameData()
                {
                    Difficulty = "Orta",
                    ButtonCount = 75,
                    Width = 350,
                    Height = 190
                },
                new GameData()
                {
                    Difficulty = "Zor",
                    ButtonCount = 100,
                    Width = 500,
                    Height =   220
                }
            };

        private void btnClicked(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.ImageIndex = 0;
            btn.Enabled = false;

            if (btn.ImageList != null)
            {
                foreach (var item in flowLayoutPanel1.Controls)
                {
                    Button btnEach = (Button)item;
                    if (btnEach.ImageList != null)
                    {
                        btnEach.ImageIndex = 0;
                        btnEach.Enabled = false;
                        Thread.Sleep(100);
                    }
                }

                MessageBox.Show("Kaybettiniz");
            }
            else
            {
                bool isWin = true;
                foreach (var item in flowLayoutPanel1.Controls)
                {

                    Button btnWin = (Button)item;
                    if (btnWin.ImageList == null)
                    {
                        if (btnWin.Enabled)
                        {
                            isWin = false;
                        }
                    }
                }
                if (isWin)
                    MessageBox.Show("Tebrikler Kazandnız");
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < gameDatas.Count; i++)
            {
                comboBox1.Items.Insert(i, gameDatas[i].Difficulty);
            }
        }

        private void CreateGame(int difficulty)
        {
            GameData selectedDifficulty = gameDatas[difficulty];
            flowLayoutPanel1.Controls.Clear();
            flowLayoutPanel1.Visible = true;
            flowLayoutPanel1.Width = selectedDifficulty.Width;
            flowLayoutPanel1.Height = selectedDifficulty.Height;
            Random rnd = new Random();

            for (int i = 0; i < selectedDifficulty.ButtonCount; i++)
            {
                int difficultyNumber = 9 / (difficulty + 1);
                int result = rnd.Next(0, difficultyNumber);
                Button btn = new Button
                {
                    Location = new Point(40 + 36 * i, 12),
                    Name = "btn" + i,
                    Size = new Size(30, 26),
                    TabIndex = 0,
                    UseVisualStyleBackColor = true,

                };
                if (result == 1)
                {
                    btn.ImageList = ımageList1;
                }
                btn.Click += new EventHandler(this.btnClicked);
                flowLayoutPanel1.Controls.Add(btn);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = comboBox1.SelectedIndex;
            CreateGame(selectedIndex);
        }
    }
}