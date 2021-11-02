
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
            this.txtHesap = new System.Windows.Forms.TextBox();
            this.btnBackSpace = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btnMulti = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btnSum = new System.Windows.Forms.Button();
            this.btnEqual = new System.Windows.Forms.Button();
            this.btnDot = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnSub = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtHesap
            // 
            this.txtHesap.Location = new System.Drawing.Point(12, 12);
            this.txtHesap.Multiline = true;
            this.txtHesap.Name = "txtHesap";
            this.txtHesap.Size = new System.Drawing.Size(167, 64);
            this.txtHesap.TabIndex = 0;
            this.txtHesap.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHesap_KeyPress);
            // 
            // btnBackSpace
            // 
            this.btnBackSpace.Location = new System.Drawing.Point(12, 83);
            this.btnBackSpace.Name = "btnBackSpace";
            this.btnBackSpace.Size = new System.Drawing.Size(81, 23);
            this.btnBackSpace.TabIndex = 1;
            this.btnBackSpace.Text = "<--";
            this.btnBackSpace.UseVisualStyleBackColor = true;
            this.btnBackSpace.Click += new System.EventHandler(this.btnBackSpace_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(99, 83);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(80, 23);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "C";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btn7
            // 
            this.btn7.Location = new System.Drawing.Point(13, 113);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(37, 23);
            this.btn7.TabIndex = 3;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btn8
            // 
            this.btn8.Location = new System.Drawing.Point(56, 113);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(37, 23);
            this.btn8.TabIndex = 4;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btnDivide
            // 
            this.btnDivide.Location = new System.Drawing.Point(142, 113);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(37, 23);
            this.btnDivide.TabIndex = 6;
            this.btnDivide.Text = "/";
            this.btnDivide.UseVisualStyleBackColor = true;
            this.btnDivide.Click += new System.EventHandler(this.btnIslem_Click);
            // 
            // btn9
            // 
            this.btn9.Location = new System.Drawing.Point(99, 113);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(37, 23);
            this.btn9.TabIndex = 5;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btnMulti
            // 
            this.btnMulti.Location = new System.Drawing.Point(142, 142);
            this.btnMulti.Name = "btnMulti";
            this.btnMulti.Size = new System.Drawing.Size(37, 23);
            this.btnMulti.TabIndex = 10;
            this.btnMulti.Text = "*";
            this.btnMulti.UseVisualStyleBackColor = true;
            this.btnMulti.Click += new System.EventHandler(this.btnIslem_Click);
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(99, 142);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(37, 23);
            this.btn6.TabIndex = 9;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(56, 142);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(37, 23);
            this.btn5.TabIndex = 8;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(13, 142);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(37, 23);
            this.btn4.TabIndex = 7;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btnSum
            // 
            this.btnSum.Location = new System.Drawing.Point(141, 200);
            this.btnSum.Name = "btnSum";
            this.btnSum.Size = new System.Drawing.Size(37, 23);
            this.btnSum.TabIndex = 18;
            this.btnSum.Text = "+";
            this.btnSum.UseVisualStyleBackColor = true;
            this.btnSum.Click += new System.EventHandler(this.btnIslem_Click);
            // 
            // btnEqual
            // 
            this.btnEqual.Location = new System.Drawing.Point(98, 200);
            this.btnEqual.Name = "btnEqual";
            this.btnEqual.Size = new System.Drawing.Size(37, 23);
            this.btnEqual.TabIndex = 17;
            this.btnEqual.Text = "=";
            this.btnEqual.UseVisualStyleBackColor = true;
            this.btnEqual.Click += new System.EventHandler(this.btnEqual_Click);
            // 
            // btnDot
            // 
            this.btnDot.Location = new System.Drawing.Point(55, 200);
            this.btnDot.Name = "btnDot";
            this.btnDot.Size = new System.Drawing.Size(37, 23);
            this.btnDot.TabIndex = 16;
            this.btnDot.Text = ".";
            this.btnDot.UseVisualStyleBackColor = true;
            this.btnDot.Click += new System.EventHandler(this.btnDot_Click);
            // 
            // btn0
            // 
            this.btn0.Location = new System.Drawing.Point(12, 200);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(37, 23);
            this.btn0.TabIndex = 15;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btnSub
            // 
            this.btnSub.Location = new System.Drawing.Point(141, 171);
            this.btnSub.Name = "btnSub";
            this.btnSub.Size = new System.Drawing.Size(37, 23);
            this.btnSub.TabIndex = 14;
            this.btnSub.Text = "-";
            this.btnSub.UseVisualStyleBackColor = true;
            this.btnSub.Click += new System.EventHandler(this.btnIslem_Click);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(98, 171);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(37, 23);
            this.btn3.TabIndex = 13;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(55, 171);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(37, 23);
            this.btn2.TabIndex = 12;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(12, 171);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(37, 23);
            this.btn1.TabIndex = 11;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(196, 236);
            this.Controls.Add(this.btnSum);
            this.Controls.Add(this.btnEqual);
            this.Controls.Add(this.btnDot);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btnSub);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btnMulti);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btnDivide);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnBackSpace);
            this.Controls.Add(this.txtHesap);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtHesap;
        private System.Windows.Forms.Button btnBackSpace;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btnMulti;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btnSum;
        private System.Windows.Forms.Button btnEqual;
        private System.Windows.Forms.Button btnDot;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnSub;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
    }
}

