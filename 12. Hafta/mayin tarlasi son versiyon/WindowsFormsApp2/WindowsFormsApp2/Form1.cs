using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2.Properties;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            List<string> horseName = new List<string>() { "Ercan", "Serkan", "Akçagül", "Emirhan", "Levent", "Mert", "Uğur", "Abdullah", "Nurullah", "Yusuf" };

            int btnCount = Convert.ToInt32(textBox1.Text);

            for (int i = 0; i < btnCount; i++)
            {
                Random random = new Random();
                int rndNumber = random.Next(0, horseName.Count - 1);
                string horseNameForLabel = horseName[rndNumber];
                horseName.RemoveAt(rndNumber);
               
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
                pic.TabIndex = 3;
                pic.TabStop = false;

                lbl.Location = new System.Drawing.Point(panel1.Location.X, panel1.Location.Y + 33 + 50 * i);
                pic.Location = new System.Drawing.Point(panel1.Location.X, panel1.Location.Y + 50 + 50 * i);

                panel1.Controls.Add(pic);
                panel1.Controls.Add(lbl);

            }


        }
    }
}
