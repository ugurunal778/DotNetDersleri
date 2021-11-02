
namespace WindowsFormsApp5
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
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnDot = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDevide = new System.Windows.Forms.Button();
            this.btnMultiple = new System.Windows.Forms.Button();
            this.btnSubtraction = new System.Windows.Forms.Button();
            this.btnSum = new System.Windows.Forms.Button();
            this.btnEqual = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
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
            this.txtHesap.Size = new System.Drawing.Size(150, 74);
            this.txtHesap.TabIndex = 39;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(12, 92);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(72, 23);
            this.btnDelete.TabIndex = 38;
            this.btnDelete.Text = "<<";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnDot
            // 
            this.btnDot.Location = new System.Drawing.Point(51, 210);
            this.btnDot.Name = "btnDot";
            this.btnDot.Size = new System.Drawing.Size(33, 23);
            this.btnDot.TabIndex = 37;
            this.btnDot.Text = ",";
            this.btnDot.UseVisualStyleBackColor = true;
            this.btnDot.Click += new System.EventHandler(this.btnDot_Click);
            // 
            // btn0
            // 
            this.btn0.Location = new System.Drawing.Point(12, 210);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(33, 23);
            this.btn0.TabIndex = 36;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(90, 92);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(72, 23);
            this.btnClear.TabIndex = 35;
            this.btnClear.Text = "Temizle";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDevide
            // 
            this.btnDevide.Location = new System.Drawing.Point(129, 123);
            this.btnDevide.Name = "btnDevide";
            this.btnDevide.Size = new System.Drawing.Size(33, 23);
            this.btnDevide.TabIndex = 34;
            this.btnDevide.Text = "/";
            this.btnDevide.UseVisualStyleBackColor = true;
            this.btnDevide.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnMultiple
            // 
            this.btnMultiple.Location = new System.Drawing.Point(129, 152);
            this.btnMultiple.Name = "btnMultiple";
            this.btnMultiple.Size = new System.Drawing.Size(33, 23);
            this.btnMultiple.TabIndex = 33;
            this.btnMultiple.Text = "*";
            this.btnMultiple.UseVisualStyleBackColor = true;
            this.btnMultiple.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnSubtraction
            // 
            this.btnSubtraction.Location = new System.Drawing.Point(129, 181);
            this.btnSubtraction.Name = "btnSubtraction";
            this.btnSubtraction.Size = new System.Drawing.Size(33, 23);
            this.btnSubtraction.TabIndex = 32;
            this.btnSubtraction.Text = "-";
            this.btnSubtraction.UseVisualStyleBackColor = true;
            this.btnSubtraction.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnSum
            // 
            this.btnSum.Location = new System.Drawing.Point(129, 210);
            this.btnSum.Name = "btnSum";
            this.btnSum.Size = new System.Drawing.Size(33, 23);
            this.btnSum.TabIndex = 31;
            this.btnSum.Text = "+";
            this.btnSum.UseVisualStyleBackColor = true;
            this.btnSum.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnEqual
            // 
            this.btnEqual.Location = new System.Drawing.Point(90, 210);
            this.btnEqual.Name = "btnEqual";
            this.btnEqual.Size = new System.Drawing.Size(33, 23);
            this.btnEqual.TabIndex = 30;
            this.btnEqual.Text = "=";
            this.btnEqual.UseVisualStyleBackColor = true;
            this.btnEqual.Click += new System.EventHandler(this.btnEqual_Click);
            // 
            // btn9
            // 
            this.btn9.Location = new System.Drawing.Point(90, 123);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(33, 23);
            this.btn9.TabIndex = 29;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btn8
            // 
            this.btn8.Location = new System.Drawing.Point(51, 123);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(33, 23);
            this.btn8.TabIndex = 28;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btn7
            // 
            this.btn7.Location = new System.Drawing.Point(12, 123);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(33, 23);
            this.btn7.TabIndex = 27;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(90, 152);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(33, 23);
            this.btn6.TabIndex = 26;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(51, 152);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(33, 23);
            this.btn5.TabIndex = 25;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(12, 152);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(33, 23);
            this.btn4.TabIndex = 24;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(90, 181);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(33, 23);
            this.btn3.TabIndex = 23;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(51, 181);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(33, 23);
            this.btn2.TabIndex = 22;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(12, 181);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(33, 23);
            this.btn1.TabIndex = 21;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(181, 247);
            this.Controls.Add(this.txtHesap);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnDot);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDevide);
            this.Controls.Add(this.btnMultiple);
            this.Controls.Add(this.btnSubtraction);
            this.Controls.Add(this.btnSum);
            this.Controls.Add(this.btnEqual);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtHesap;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnDot;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDevide;
        private System.Windows.Forms.Button btnMultiple;
        private System.Windows.Forms.Button btnSubtraction;
        private System.Windows.Forms.Button btnSum;
        private System.Windows.Forms.Button btnEqual;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
    }
}

