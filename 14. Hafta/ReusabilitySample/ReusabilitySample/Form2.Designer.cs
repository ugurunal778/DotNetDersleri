
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
            this.lblOndalik = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtOndalıkli = new System.Windows.Forms.TextBox();
            this.txtFromId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnParaYatir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblOndalik
            // 
            this.lblOndalik.AutoSize = true;
            this.lblOndalik.Location = new System.Drawing.Point(36, 101);
            this.lblOndalik.Name = "lblOndalik";
            this.lblOndalik.Size = new System.Drawing.Size(46, 20);
            this.lblOndalik.TabIndex = 22;
            this.lblOndalik.Text = "Tutar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "ToId";
            // 
            // txtOndalıkli
            // 
            this.txtOndalıkli.Location = new System.Drawing.Point(217, 101);
            this.txtOndalıkli.Name = "txtOndalıkli";
            this.txtOndalıkli.Size = new System.Drawing.Size(100, 26);
            this.txtOndalıkli.TabIndex = 19;
            this.txtOndalıkli.Tag = "1";
            this.txtOndalıkli.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxKeyPressValidation);
            // 
            // txtFromId
            // 
            this.txtFromId.Location = new System.Drawing.Point(217, 65);
            this.txtFromId.Name = "txtFromId";
            this.txtFromId.Size = new System.Drawing.Size(100, 26);
            this.txtFromId.TabIndex = 18;
            this.txtFromId.Tag = "0";
            this.txtFromId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxKeyPressValidation);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 24;
            this.label2.Text = "FromId";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(217, 33);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 26);
            this.textBox1.TabIndex = 23;
            this.textBox1.Tag = "0";
            // 
            // btnParaYatir
            // 
            this.btnParaYatir.Location = new System.Drawing.Point(217, 133);
            this.btnParaYatir.Name = "btnParaYatir";
            this.btnParaYatir.Size = new System.Drawing.Size(100, 35);
            this.btnParaYatir.TabIndex = 25;
            this.btnParaYatir.Text = "Para Yatır";
            this.btnParaYatir.UseVisualStyleBackColor = true;
            this.btnParaYatir.Click += new System.EventHandler(this.btnParaYatir_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
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
        private System.Windows.Forms.Label lblOndalik;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtOndalıkli;
        private System.Windows.Forms.TextBox txtFromId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnParaYatir;
    }
}