
namespace Hesap_Makinesi
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
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtSonuc = new System.Windows.Forms.TextBox();
            this.btnSilme = new System.Windows.Forms.Button();
            this.btnEşittir = new System.Windows.Forms.Button();
            this.btnVirgül = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btnTopla = new System.Windows.Forms.Button();
            this.btnCıkarma = new System.Windows.Forms.Button();
            this.btnÇarpma = new System.Windows.Forms.Button();
            this.btnBölme = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(403, 153);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(144, 44);
            this.btnDelete.TabIndex = 37;
            this.btnDelete.Text = "<=";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtSonuc
            // 
            this.txtSonuc.Location = new System.Drawing.Point(253, 54);
            this.txtSonuc.Multiline = true;
            this.txtSonuc.Name = "txtSonuc";
            this.txtSonuc.Size = new System.Drawing.Size(294, 93);
            this.txtSonuc.TabIndex = 36;
            this.txtSonuc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSonuc_KeyPress);
            // 
            // btnSilme
            // 
            this.btnSilme.Location = new System.Drawing.Point(253, 153);
            this.btnSilme.Name = "btnSilme";
            this.btnSilme.Size = new System.Drawing.Size(144, 44);
            this.btnSilme.TabIndex = 35;
            this.btnSilme.Text = "C";
            this.btnSilme.UseVisualStyleBackColor = true;
            this.btnSilme.Click += new System.EventHandler(this.btnSilme_Click);
            // 
            // btnEşittir
            // 
            this.btnEşittir.Location = new System.Drawing.Point(403, 353);
            this.btnEşittir.Name = "btnEşittir";
            this.btnEşittir.Size = new System.Drawing.Size(69, 44);
            this.btnEşittir.TabIndex = 34;
            this.btnEşittir.Text = "=";
            this.btnEşittir.UseVisualStyleBackColor = true;
            this.btnEşittir.Click += new System.EventHandler(this.btnEşittir_Click);
            // 
            // btnVirgül
            // 
            this.btnVirgül.Location = new System.Drawing.Point(253, 353);
            this.btnVirgül.Name = "btnVirgül";
            this.btnVirgül.Size = new System.Drawing.Size(69, 44);
            this.btnVirgül.TabIndex = 33;
            this.btnVirgül.Text = ",";
            this.btnVirgül.UseVisualStyleBackColor = true;
            this.btnVirgül.Click += new System.EventHandler(this.btnVirgül_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(328, 203);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(69, 44);
            this.btn2.TabIndex = 32;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(403, 203);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(69, 44);
            this.btn3.TabIndex = 31;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(253, 253);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(69, 44);
            this.btn4.TabIndex = 30;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(328, 253);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(69, 44);
            this.btn5.TabIndex = 29;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btnTopla
            // 
            this.btnTopla.Location = new System.Drawing.Point(478, 203);
            this.btnTopla.Name = "btnTopla";
            this.btnTopla.Size = new System.Drawing.Size(69, 44);
            this.btnTopla.TabIndex = 28;
            this.btnTopla.Text = "+";
            this.btnTopla.UseVisualStyleBackColor = true;
            this.btnTopla.Click += new System.EventHandler(this.btnIslem_Click);
            // 
            // btnCıkarma
            // 
            this.btnCıkarma.Location = new System.Drawing.Point(478, 253);
            this.btnCıkarma.Name = "btnCıkarma";
            this.btnCıkarma.Size = new System.Drawing.Size(69, 44);
            this.btnCıkarma.TabIndex = 27;
            this.btnCıkarma.Text = "-";
            this.btnCıkarma.UseVisualStyleBackColor = true;
            this.btnCıkarma.Click += new System.EventHandler(this.btnIslem_Click);
            // 
            // btnÇarpma
            // 
            this.btnÇarpma.Location = new System.Drawing.Point(478, 303);
            this.btnÇarpma.Name = "btnÇarpma";
            this.btnÇarpma.Size = new System.Drawing.Size(69, 44);
            this.btnÇarpma.TabIndex = 26;
            this.btnÇarpma.Text = "*";
            this.btnÇarpma.UseVisualStyleBackColor = true;
            this.btnÇarpma.Click += new System.EventHandler(this.btnIslem_Click);
            // 
            // btnBölme
            // 
            this.btnBölme.Location = new System.Drawing.Point(478, 353);
            this.btnBölme.Name = "btnBölme";
            this.btnBölme.Size = new System.Drawing.Size(69, 44);
            this.btnBölme.TabIndex = 25;
            this.btnBölme.Text = "/";
            this.btnBölme.UseVisualStyleBackColor = true;
            this.btnBölme.Click += new System.EventHandler(this.btnIslem_Click);
            // 
            // btn8
            // 
            this.btn8.Location = new System.Drawing.Point(328, 303);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(69, 44);
            this.btn8.TabIndex = 24;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btn0
            // 
            this.btn0.Location = new System.Drawing.Point(328, 353);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(69, 44);
            this.btn0.TabIndex = 23;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btn9
            // 
            this.btn9.Location = new System.Drawing.Point(403, 303);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(69, 44);
            this.btn9.TabIndex = 22;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(403, 253);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(69, 44);
            this.btn6.TabIndex = 21;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btn7
            // 
            this.btn7.Location = new System.Drawing.Point(253, 303);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(69, 44);
            this.btn7.TabIndex = 20;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(253, 203);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(69, 44);
            this.btn1.TabIndex = 19;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txtSonuc);
            this.Controls.Add(this.btnSilme);
            this.Controls.Add(this.btnEşittir);
            this.Controls.Add(this.btnVirgül);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btnTopla);
            this.Controls.Add(this.btnCıkarma);
            this.Controls.Add(this.btnÇarpma);
            this.Controls.Add(this.btnBölme);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtSonuc;
        private System.Windows.Forms.Button btnSilme;
        private System.Windows.Forms.Button btnEşittir;
        private System.Windows.Forms.Button btnVirgül;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btnTopla;
        private System.Windows.Forms.Button btnCıkarma;
        private System.Windows.Forms.Button btnÇarpma;
        private System.Windows.Forms.Button btnBölme;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn1;
    }
}

