
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
            this.txtTamSayi = new System.Windows.Forms.TextBox();
            this.txtOndalıkli = new System.Windows.Forms.TextBox();
            this.txtYazi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtTamSayi
            // 
            this.txtTamSayi.Location = new System.Drawing.Point(129, 25);
            this.txtTamSayi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTamSayi.Name = "txtTamSayi";
            this.txtTamSayi.Size = new System.Drawing.Size(68, 20);
            this.txtTamSayi.TabIndex = 0;
            this.txtTamSayi.Tag = "0";
            this.txtTamSayi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxKeyPressValidation);
            // 
            // txtOndalıkli
            // 
            this.txtOndalıkli.Location = new System.Drawing.Point(129, 48);
            this.txtOndalıkli.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtOndalıkli.Name = "txtOndalıkli";
            this.txtOndalıkli.Size = new System.Drawing.Size(68, 20);
            this.txtOndalıkli.TabIndex = 1;
            this.txtOndalıkli.Tag = "1";
            this.txtOndalıkli.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxKeyPressValidation);
            // 
            // txtYazi
            // 
            this.txtYazi.Location = new System.Drawing.Point(129, 69);
            this.txtYazi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtYazi.Name = "txtYazi";
            this.txtYazi.Size = new System.Drawing.Size(68, 20);
            this.txtYazi.TabIndex = 2;
            this.txtYazi.Tag = "2";
            this.txtYazi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxKeyPressValidation);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tam Sayı Giriniz";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 48);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ondalıklı Sayı Giriniz";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 69);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Yazı Giriniz";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 135);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Yazı Giriniz";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 114);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Ondalıklı Sayı Giriniz";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 94);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Tam Sayı Giriniz";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(129, 135);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(68, 20);
            this.textBox1.TabIndex = 8;
            this.textBox1.Tag = "2";
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxKeyPressValidation);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(129, 114);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(68, 20);
            this.textBox2.TabIndex = 7;
            this.textBox2.Tag = "1";
            this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxKeyPressValidation);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(129, 94);
            this.textBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(68, 20);
            this.textBox3.TabIndex = 6;
            this.textBox3.Tag = "0";
            this.textBox3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxKeyPressValidation);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 196);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Yazı Giriniz";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 175);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Ondalıklı Sayı Giriniz";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 156);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Tam Sayı Giriniz";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(129, 196);
            this.textBox4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(68, 20);
            this.textBox4.TabIndex = 14;
            this.textBox4.Tag = "2";
            this.textBox4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxKeyPressValidation);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(129, 175);
            this.textBox5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(68, 20);
            this.textBox5.TabIndex = 13;
            this.textBox5.Tag = "1";
            this.textBox5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxKeyPressValidation);
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(129, 156);
            this.textBox6.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(68, 20);
            this.textBox6.TabIndex = 12;
            this.textBox6.Tag = "0";
            this.textBox6.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxKeyPressValidation);
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(129, 222);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(68, 20);
            this.textBox7.TabIndex = 18;
            this.textBox7.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxKeyPressValidation);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 292);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtYazi);
            this.Controls.Add(this.txtOndalıkli);
            this.Controls.Add(this.txtTamSayi);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTamSayi;
        private System.Windows.Forms.TextBox txtOndalıkli;
        private System.Windows.Forms.TextBox txtYazi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
    }
}

