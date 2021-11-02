
namespace TestProject
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnlGame = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.pnlSelection = new System.Windows.Forms.Panel();
            this.btnBahisOyna = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBahis = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbAt = new System.Windows.Forms.ComboBox();
            this.txtHorseCount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAtOlustur = new System.Windows.Forms.Button();
            this.pnlGame.SuspendLayout();
            this.pnlSelection.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pnlGame
            // 
            this.pnlGame.Controls.Add(this.button1);
            this.pnlGame.Controls.Add(this.pnlSelection);
            this.pnlGame.Location = new System.Drawing.Point(10, 8);
            this.pnlGame.Margin = new System.Windows.Forms.Padding(2);
            this.pnlGame.Name = "pnlGame";
            this.pnlGame.Size = new System.Drawing.Size(1161, 548);
            this.pnlGame.TabIndex = 15;
            this.pnlGame.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(765, 94);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // pnlSelection
            // 
            this.pnlSelection.Controls.Add(this.btnBahisOyna);
            this.pnlSelection.Controls.Add(this.label2);
            this.pnlSelection.Controls.Add(this.txtBahis);
            this.pnlSelection.Controls.Add(this.label1);
            this.pnlSelection.Controls.Add(this.cmbAt);
            this.pnlSelection.Location = new System.Drawing.Point(243, 2);
            this.pnlSelection.Margin = new System.Windows.Forms.Padding(2);
            this.pnlSelection.Name = "pnlSelection";
            this.pnlSelection.Size = new System.Drawing.Size(439, 49);
            this.pnlSelection.TabIndex = 21;
            this.pnlSelection.Visible = false;
            // 
            // btnBahisOyna
            // 
            this.btnBahisOyna.Location = new System.Drawing.Point(286, 3);
            this.btnBahisOyna.Margin = new System.Windows.Forms.Padding(2);
            this.btnBahisOyna.Name = "btnBahisOyna";
            this.btnBahisOyna.Size = new System.Drawing.Size(89, 43);
            this.btnBahisOyna.TabIndex = 25;
            this.btnBahisOyna.Text = "Bahis Oyna";
            this.btnBahisOyna.UseVisualStyleBackColor = true;
            this.btnBahisOyna.Click += new System.EventHandler(this.btnBahisOyna_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 6);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Bahis Tutarı";
            // 
            // txtBahis
            // 
            this.txtBahis.Location = new System.Drawing.Point(143, 3);
            this.txtBahis.Margin = new System.Windows.Forms.Padding(2);
            this.txtBahis.Name = "txtBahis";
            this.txtBahis.Size = new System.Drawing.Size(117, 20);
            this.txtBahis.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Atı Seçiniz";
            // 
            // cmbAt
            // 
            this.cmbAt.FormattingEnabled = true;
            this.cmbAt.Location = new System.Drawing.Point(143, 27);
            this.cmbAt.Margin = new System.Windows.Forms.Padding(2);
            this.cmbAt.Name = "cmbAt";
            this.cmbAt.Size = new System.Drawing.Size(117, 21);
            this.cmbAt.TabIndex = 21;
            // 
            // txtHorseCount
            // 
            this.txtHorseCount.Location = new System.Drawing.Point(135, 12);
            this.txtHorseCount.Margin = new System.Windows.Forms.Padding(2);
            this.txtHorseCount.Name = "txtHorseCount";
            this.txtHorseCount.Size = new System.Drawing.Size(68, 20);
            this.txtHorseCount.TabIndex = 22;
            this.txtHorseCount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHorseCount_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 18);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Yarışacak At Sayısı";
            // 
            // btnAtOlustur
            // 
            this.btnAtOlustur.Location = new System.Drawing.Point(135, 42);
            this.btnAtOlustur.Margin = new System.Windows.Forms.Padding(2);
            this.btnAtOlustur.Name = "btnAtOlustur";
            this.btnAtOlustur.Size = new System.Drawing.Size(67, 23);
            this.btnAtOlustur.TabIndex = 24;
            this.btnAtOlustur.Text = "At Oluştur";
            this.btnAtOlustur.UseVisualStyleBackColor = true;
            this.btnAtOlustur.Click += new System.EventHandler(this.btnAtOlustur_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 567);
            this.Controls.Add(this.btnAtOlustur);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtHorseCount);
            this.Controls.Add(this.pnlGame);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.pnlGame.ResumeLayout(false);
            this.pnlSelection.ResumeLayout(false);
            this.pnlSelection.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel pnlGame;
        private System.Windows.Forms.Panel pnlSelection;
        private System.Windows.Forms.Button btnBahisOyna;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBahis;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbAt;
        private System.Windows.Forms.TextBox txtHorseCount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAtOlustur;
        private System.Windows.Forms.Button button1;
    }
}

