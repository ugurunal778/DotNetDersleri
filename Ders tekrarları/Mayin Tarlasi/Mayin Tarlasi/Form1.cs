﻿using System;
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
        List<int> mineIndex = new List<int>();
        List<GameData> gameDatas = new List<GameData>
        {
            new GameData()
            {
                Difficulty = "Kolay",
                ButtonCount = 50,
                Width = 200,
                Height = 160,
                Index = 0,
                MineCount = 10,
            },
            new GameData()
            {
                Difficulty = "Orta",
                ButtonCount = 75,
                Width = 350,
                Height = 190,
                Index = 1,
                MineCount = 25,
            },
            new GameData()
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
        private void Form1_Load(object sender, EventArgs e)
        {
            setCmbDifficulty();
        }
        private void CmbDifficulty_SelectedIndexChanged(object sender, EventArgs e)
        {
            GameData selectedDifficulty = gameDatas[CmbDifficulty.SelectedIndex];
            CreateGame(selectedDifficulty);
        }
        private void BtnClicked(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.Enabled = false;
            SetMineResult(btn.ImageList != null);
        }
        private void SetMineResult(bool isExistMine)
        {
            bool isWin = true;
            foreach (var item in flowLayoutPanel1.Controls)
            {
                Button btnEach = (Button)item;
                if (isExistMine)
                {
                    if (btnEach.ImageList != null)
                    {
                        btnEach.ImageIndex = 0;
                        btnEach.Enabled = false;
                        Thread.Sleep(100);
                    }
                }
                else
                {
                    if (btnEach.ImageList == null)
                    {
                        if (btnEach.Enabled)
                            isWin = false;
                    }
                }
            }
            SendMessage(isExistMine, isWin);
        }
        private static void SendMessage(bool isExistMine, bool isWin)
        {
            if (isExistMine)
                MessageBox.Show("Kaybettiniz. ");
            else
            {
                if (isWin)
                    MessageBox.Show("Tebrikler Kazandiniz. ");
            }
        }
        #endregion

        #region Methods
        private void setCmbDifficulty()
        {
            for (int i = 0; i < gameDatas.Count; i++)
            {
                CmbDifficulty.Items.Insert(i, gameDatas[i].Difficulty);
            }
        }
        private void SetFlowlayouProperties(GameData selectedDifficulty)
        {
            flowLayoutPanel1.Controls.Clear();
            flowLayoutPanel1.Visible = true;
            flowLayoutPanel1.Width = selectedDifficulty.Width;
            flowLayoutPanel1.Height = selectedDifficulty.Height;
        }
        private void CreateButtonsToFlowLayoutControl(GameData selectedDifficulty)
        {
            for (int i = 0; i < selectedDifficulty.ButtonCount; i++)
            {
                bool isExistImage = mineIndex.Contains(i);
                GenerateButtons(i, isExistImage);
            }
        }
        private void GenerateButtons(int i, bool isExistImage)
        {
            Button btn = new Button
            {
                Location = new Point(40 + 36 * i, 12),
                Name = "btn" + i,
                Size = new Size(30, 26),
                UseVisualStyleBackColor = true,
                ImageList = isExistImage ? ımageList1 : null
            };
            btn.Click += new EventHandler(BtnClicked);
            flowLayoutPanel1.Controls.Add(btn);
        }
        private void CreateGame(GameData selectedDifficulty)
        {
            SetFlowlayouProperties(selectedDifficulty);
            SetSelectedDifficultyMineIndex(selectedDifficulty);
            CreateButtonsToFlowLayoutControl(selectedDifficulty);
        }
        private void SetSelectedDifficultyMineIndex(GameData selectedDifficulty)
        {
            Random rnd = new Random();
            for (int i = 0; i < selectedDifficulty.MineCount; i++)
            {
                int rndNumber = rnd.Next(0, selectedDifficulty.ButtonCount - 1);
                if (mineIndex.Contains(rndNumber))
                    i--;
                else
                    mineIndex.Add(rndNumber);
            }
        }
        #endregion
    }
}
