
namespace ReusabilitySample
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtyazi = new System.Windows.Forms.TextBox();
            this.txtOndalikli = new System.Windows.Forms.TextBox();
            this.txtTamsayi = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tamsayi Giriniz";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Yazi Giriniz";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ondalikli Sayi Giriniz";
            // 
            // txtyazi
            // 
            this.txtyazi.Location = new System.Drawing.Point(119, 65);
            this.txtyazi.Name = "txtyazi";
            this.txtyazi.Size = new System.Drawing.Size(100, 20);
            this.txtyazi.TabIndex = 4;
            this.txtyazi.Tag = "2";
            this.txtyazi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxKeyPressValidation);
            // 
            // txtOndalikli
            // 
            this.txtOndalikli.Location = new System.Drawing.Point(119, 39);
            this.txtOndalikli.Name = "txtOndalikli";
            this.txtOndalikli.Size = new System.Drawing.Size(100, 20);
            this.txtOndalikli.TabIndex = 5;
            this.txtOndalikli.Tag = "1";
            this.txtOndalikli.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxKeyPressValidation);
            // 
            // txtTamsayi
            // 
            this.txtTamsayi.Location = new System.Drawing.Point(119, 13);
            this.txtTamsayi.Name = "txtTamsayi";
            this.txtTamsayi.Size = new System.Drawing.Size(100, 20);
            this.txtTamsayi.TabIndex = 6;
            this.txtTamsayi.Tag = "0";
            this.txtTamsayi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxKeyPressValidation);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(119, 91);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 12;
            this.textBox1.Tag = "0";
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxKeyPressValidation);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(119, 117);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 11;
            this.textBox2.Tag = "1";
            this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxKeyPressValidation);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(119, 143);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 10;
            this.textBox3.Tag = "2";
            this.textBox3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxKeyPressValidation);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Ondalikli Sayi Giriniz";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Yazi Giriniz";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Tamsayi Giriniz";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(119, 169);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 18;
            this.textBox4.Tag = "0";
            this.textBox4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxKeyPressValidation);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(119, 195);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 17;
            this.textBox5.Tag = "1";
            this.textBox5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxKeyPressValidation);
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(119, 221);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 16;
            this.textBox6.Tag = "2";
            this.textBox6.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxKeyPressValidation);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 202);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Ondalikli Sayi Giriniz";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 228);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Yazi Giriniz";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 176);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Tamsayi Giriniz";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTamsayi);
            this.Controls.Add(this.txtOndalikli);
            this.Controls.Add(this.txtyazi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtyazi;
        private System.Windows.Forms.TextBox txtOndalikli;
        private System.Windows.Forms.TextBox txtTamsayi;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}

