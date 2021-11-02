using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        TeknikServis ts = new TeknikServis();
        public Form1()
        {
            InitializeComponent();
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Nokia")
            {
                Nokia nk = new Nokia();
                nk.CallSound();

            }
            if (comboBox1.Text == "Samsung")
            {
                Samsung sm = new Samsung();
                sm.CallSound();
            }
            if (comboBox1.Text == "IPhone")
            {
                IPhone ıp = new IPhone();
                ıp.CallSound();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Nokia");
            comboBox1.Items.Add("Samsung");
            comboBox1.Items.Add("IPhone");
        }
    }
}
