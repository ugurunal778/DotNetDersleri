
namespace At_Yarisi_v2
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
            this.pnlGame = new System.Windows.Forms.Panel();
            this.btnfinish = new System.Windows.Forms.Button();
            this.pnlSelection = new System.Windows.Forms.Panel();
            this.btnPlay = new System.Windows.Forms.Button();
            this.cmbPickHorse = new System.Windows.Forms.ComboBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.lblPickHorse = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.lblHorseNum = new System.Windows.Forms.Label();
            this.txtHorseNum = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnlGame.SuspendLayout();
            this.pnlSelection.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlGame
            // 
            this.pnlGame.Controls.Add(this.btnfinish);
            this.pnlGame.Location = new System.Drawing.Point(3, 61);
            this.pnlGame.Name = "pnlGame";
            this.pnlGame.Size = new System.Drawing.Size(1212, 558);
            this.pnlGame.TabIndex = 0;
            this.pnlGame.Visible = false;
            // 
            // btnfinish
            // 
            this.btnfinish.Location = new System.Drawing.Point(1116, 59);
            this.btnfinish.Name = "btnfinish";
            this.btnfinish.Size = new System.Drawing.Size(75, 23);
            this.btnfinish.TabIndex = 0;
            this.btnfinish.Text = "button1";
            this.btnfinish.UseVisualStyleBackColor = true;
            // 
            // pnlSelection
            // 
            this.pnlSelection.Controls.Add(this.btnPlay);
            this.pnlSelection.Controls.Add(this.cmbPickHorse);
            this.pnlSelection.Controls.Add(this.txtAmount);
            this.pnlSelection.Controls.Add(this.lblPickHorse);
            this.pnlSelection.Controls.Add(this.lblAmount);
            this.pnlSelection.Location = new System.Drawing.Point(232, 3);
            this.pnlSelection.Margin = new System.Windows.Forms.Padding(2);
            this.pnlSelection.Name = "pnlSelection";
            this.pnlSelection.Size = new System.Drawing.Size(336, 50);
            this.pnlSelection.TabIndex = 3;
            this.pnlSelection.Visible = false;
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(202, 1);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(126, 43);
            this.btnPlay.TabIndex = 4;
            this.btnPlay.Text = "Bahis Oyna";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // cmbPickHorse
            // 
            this.cmbPickHorse.FormattingEnabled = true;
            this.cmbPickHorse.Location = new System.Drawing.Point(74, 23);
            this.cmbPickHorse.Name = "cmbPickHorse";
            this.cmbPickHorse.Size = new System.Drawing.Size(121, 21);
            this.cmbPickHorse.TabIndex = 3;
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(74, 1);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(121, 20);
            this.txtAmount.TabIndex = 2;
            this.txtAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAmount_KeyPress);
            // 
            // lblPickHorse
            // 
            this.lblPickHorse.AutoSize = true;
            this.lblPickHorse.Location = new System.Drawing.Point(4, 32);
            this.lblPickHorse.Name = "lblPickHorse";
            this.lblPickHorse.Size = new System.Drawing.Size(54, 13);
            this.lblPickHorse.TabIndex = 1;
            this.lblPickHorse.Text = "At Seciniz";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(4, 6);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(63, 13);
            this.lblAmount.TabIndex = 0;
            this.lblAmount.Text = "Bahis Tutari";
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(103, 30);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(100, 23);
            this.btnCreate.TabIndex = 2;
            this.btnCreate.Text = "At Olustur";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // lblHorseNum
            // 
            this.lblHorseNum.AutoSize = true;
            this.lblHorseNum.Location = new System.Drawing.Point(0, 6);
            this.lblHorseNum.Name = "lblHorseNum";
            this.lblHorseNum.Size = new System.Drawing.Size(97, 13);
            this.lblHorseNum.TabIndex = 1;
            this.lblHorseNum.Text = "Yarisacak At Sayisi";
            // 
            // txtHorseNum
            // 
            this.txtHorseNum.Location = new System.Drawing.Point(103, 3);
            this.txtHorseNum.Name = "txtHorseNum";
            this.txtHorseNum.Size = new System.Drawing.Size(100, 20);
            this.txtHorseNum.TabIndex = 0;
            this.txtHorseNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHorseNum_KeyPress);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1227, 631);
            this.Controls.Add(this.pnlGame);
            this.Controls.Add(this.pnlSelection);
            this.Controls.Add(this.lblHorseNum);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.txtHorseNum);
            this.Name = "Form1";
            this.Text = "Form1";
            this.pnlGame.ResumeLayout(false);
            this.pnlSelection.ResumeLayout(false);
            this.pnlSelection.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlGame;
        private System.Windows.Forms.Button btnfinish;
        private System.Windows.Forms.Panel pnlSelection;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.ComboBox cmbPickHorse;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label lblPickHorse;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Label lblHorseNum;
        private System.Windows.Forms.TextBox txtHorseNum;
        private System.Windows.Forms.Timer timer1;
    }
}

