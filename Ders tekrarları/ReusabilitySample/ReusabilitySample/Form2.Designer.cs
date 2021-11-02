
namespace ReusabilitySample
{
    partial class Form2
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
            this.btnParaYatir = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblOndalik = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtOndalıkli = new System.Windows.Forms.TextBox();
            this.txtFromId = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnParaYatir
            // 
            this.btnParaYatir.Location = new System.Drawing.Point(132, 70);
            this.btnParaYatir.Margin = new System.Windows.Forms.Padding(2);
            this.btnParaYatir.Name = "btnParaYatir";
            this.btnParaYatir.Size = new System.Drawing.Size(67, 23);
            this.btnParaYatir.TabIndex = 32;
            this.btnParaYatir.Text = "Para Yatır";
            this.btnParaYatir.UseVisualStyleBackColor = true;
            this.btnParaYatir.Click += new System.EventHandler(this.btnParaYatir_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "FromId";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(132, 5);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(68, 20);
            this.textBox1.TabIndex = 30;
            this.textBox1.Tag = "0";
            // 
            // lblOndalik
            // 
            this.lblOndalik.AutoSize = true;
            this.lblOndalik.Location = new System.Drawing.Point(11, 50);
            this.lblOndalik.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOndalik.Name = "lblOndalik";
            this.lblOndalik.Size = new System.Drawing.Size(32, 13);
            this.lblOndalik.TabIndex = 29;
            this.lblOndalik.Text = "Tutar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "ToId";
            // 
            // txtOndalıkli
            // 
            this.txtOndalıkli.Location = new System.Drawing.Point(132, 50);
            this.txtOndalıkli.Margin = new System.Windows.Forms.Padding(2);
            this.txtOndalıkli.Name = "txtOndalıkli";
            this.txtOndalıkli.Size = new System.Drawing.Size(68, 20);
            this.txtOndalıkli.TabIndex = 27;
            this.txtOndalıkli.Tag = "1";
            // 
            // txtFromId
            // 
            this.txtFromId.Location = new System.Drawing.Point(132, 26);
            this.txtFromId.Margin = new System.Windows.Forms.Padding(2);
            this.txtFromId.Name = "txtFromId";
            this.txtFromId.Size = new System.Drawing.Size(68, 20);
            this.txtFromId.TabIndex = 26;
            this.txtFromId.Tag = "0";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnParaYatir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblOndalik);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtOndalıkli);
            this.Controls.Add(this.txtFromId);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnParaYatir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblOndalik;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtOndalıkli;
        private System.Windows.Forms.TextBox txtFromId;
    }
}