
namespace PhoneBook
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
            this.btnAddCustomerPanel = new System.Windows.Forms.Button();
            this.btnUpdateCustomerPanel = new System.Windows.Forms.Button();
            this.btnAddPhonePanel = new System.Windows.Forms.Button();
            this.pnlAddCustomer = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblAddSurname = new System.Windows.Forms.Label();
            this.txtAddSurname = new System.Windows.Forms.TextBox();
            this.txtAddName = new System.Windows.Forms.TextBox();
            this.lblAddName = new System.Windows.Forms.Label();
            this.lblAddCustomerHeader = new System.Windows.Forms.Label();
            this.pnlUpgradeCustomer = new System.Windows.Forms.Panel();
            this.cmbUpgradePickCustomer = new System.Windows.Forms.ComboBox();
            this.lblUpgradeCustomerHeader = new System.Windows.Forms.Label();
            this.lblUpgradePickCustomer = new System.Windows.Forms.Label();
            this.lblUpgradeName = new System.Windows.Forms.Label();
            this.btnUpgrade = new System.Windows.Forms.Button();
            this.txtUpgradeSurname = new System.Windows.Forms.TextBox();
            this.txtUgradeName = new System.Windows.Forms.TextBox();
            this.lblUpgradeSurname = new System.Windows.Forms.Label();
            this.pnlAddPhone = new System.Windows.Forms.Panel();
            this.btnAddPhone = new System.Windows.Forms.Button();
            this.txtAddPhoneType = new System.Windows.Forms.TextBox();
            this.txtAddPhoneNumber = new System.Windows.Forms.Label();
            this.cmbAddPhoneType = new System.Windows.Forms.ComboBox();
            this.lblAddPhoneType = new System.Windows.Forms.Label();
            this.cmbAddPhonePickCustomer = new System.Windows.Forms.ComboBox();
            this.lblAddPhoneHeader = new System.Windows.Forms.Label();
            this.lblAddPhonePickCustomer = new System.Windows.Forms.Label();
            this.pnlAddCustomer.SuspendLayout();
            this.pnlUpgradeCustomer.SuspendLayout();
            this.pnlAddPhone.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddCustomerPanel
            // 
            this.btnAddCustomerPanel.Location = new System.Drawing.Point(13, 13);
            this.btnAddCustomerPanel.Name = "btnAddCustomerPanel";
            this.btnAddCustomerPanel.Size = new System.Drawing.Size(224, 36);
            this.btnAddCustomerPanel.TabIndex = 0;
            this.btnAddCustomerPanel.Text = "Musteri Ekle";
            this.btnAddCustomerPanel.UseVisualStyleBackColor = true;
            this.btnAddCustomerPanel.Click += new System.EventHandler(this.btnAddCustomerPanel_Click);
            // 
            // btnUpdateCustomerPanel
            // 
            this.btnUpdateCustomerPanel.Location = new System.Drawing.Point(243, 12);
            this.btnUpdateCustomerPanel.Name = "btnUpdateCustomerPanel";
            this.btnUpdateCustomerPanel.Size = new System.Drawing.Size(224, 37);
            this.btnUpdateCustomerPanel.TabIndex = 1;
            this.btnUpdateCustomerPanel.Text = "Musteri Guncelle";
            this.btnUpdateCustomerPanel.UseVisualStyleBackColor = true;
            this.btnUpdateCustomerPanel.Click += new System.EventHandler(this.btnUpdateCustomerPanel_Click);
            // 
            // btnAddPhonePanel
            // 
            this.btnAddPhonePanel.Location = new System.Drawing.Point(473, 12);
            this.btnAddPhonePanel.Name = "btnAddPhonePanel";
            this.btnAddPhonePanel.Size = new System.Drawing.Size(224, 37);
            this.btnAddPhonePanel.TabIndex = 2;
            this.btnAddPhonePanel.Text = "Telefon Ekle";
            this.btnAddPhonePanel.UseVisualStyleBackColor = true;
            this.btnAddPhonePanel.Click += new System.EventHandler(this.btnAddPhonePanel_Click);
            // 
            // pnlAddCustomer
            // 
            this.pnlAddCustomer.Controls.Add(this.btnAdd);
            this.pnlAddCustomer.Controls.Add(this.lblAddSurname);
            this.pnlAddCustomer.Controls.Add(this.txtAddSurname);
            this.pnlAddCustomer.Controls.Add(this.txtAddName);
            this.pnlAddCustomer.Controls.Add(this.lblAddName);
            this.pnlAddCustomer.Controls.Add(this.lblAddCustomerHeader);
            this.pnlAddCustomer.Location = new System.Drawing.Point(13, 55);
            this.pnlAddCustomer.Name = "pnlAddCustomer";
            this.pnlAddCustomer.Size = new System.Drawing.Size(224, 146);
            this.pnlAddCustomer.TabIndex = 3;
            this.pnlAddCustomer.Visible = false;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(90, 88);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(124, 23);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Musteri Ekle";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblAddSurname
            // 
            this.lblAddSurname.AutoSize = true;
            this.lblAddSurname.Location = new System.Drawing.Point(6, 70);
            this.lblAddSurname.Name = "lblAddSurname";
            this.lblAddSurname.Size = new System.Drawing.Size(37, 13);
            this.lblAddSurname.TabIndex = 4;
            this.lblAddSurname.Text = "Soyad";
            // 
            // txtAddSurname
            // 
            this.txtAddSurname.Location = new System.Drawing.Point(90, 64);
            this.txtAddSurname.Name = "txtAddSurname";
            this.txtAddSurname.Size = new System.Drawing.Size(124, 20);
            this.txtAddSurname.TabIndex = 3;
            this.txtAddSurname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInput_KeyPress);
            // 
            // txtAddName
            // 
            this.txtAddName.Location = new System.Drawing.Point(90, 37);
            this.txtAddName.Name = "txtAddName";
            this.txtAddName.Size = new System.Drawing.Size(124, 20);
            this.txtAddName.TabIndex = 2;
            this.txtAddName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInput_KeyPress);
            // 
            // lblAddName
            // 
            this.lblAddName.AutoSize = true;
            this.lblAddName.Location = new System.Drawing.Point(6, 44);
            this.lblAddName.Name = "lblAddName";
            this.lblAddName.Size = new System.Drawing.Size(20, 13);
            this.lblAddName.TabIndex = 1;
            this.lblAddName.Text = "Ad";
            // 
            // lblAddCustomerHeader
            // 
            this.lblAddCustomerHeader.AutoSize = true;
            this.lblAddCustomerHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAddCustomerHeader.Location = new System.Drawing.Point(3, 10);
            this.lblAddCustomerHeader.Name = "lblAddCustomerHeader";
            this.lblAddCustomerHeader.Size = new System.Drawing.Size(77, 13);
            this.lblAddCustomerHeader.TabIndex = 0;
            this.lblAddCustomerHeader.Text = "Musteri Ekle";
            // 
            // pnlUpgradeCustomer
            // 
            this.pnlUpgradeCustomer.Controls.Add(this.cmbUpgradePickCustomer);
            this.pnlUpgradeCustomer.Controls.Add(this.lblUpgradeCustomerHeader);
            this.pnlUpgradeCustomer.Controls.Add(this.lblUpgradePickCustomer);
            this.pnlUpgradeCustomer.Controls.Add(this.lblUpgradeName);
            this.pnlUpgradeCustomer.Controls.Add(this.btnUpgrade);
            this.pnlUpgradeCustomer.Controls.Add(this.txtUpgradeSurname);
            this.pnlUpgradeCustomer.Controls.Add(this.txtUgradeName);
            this.pnlUpgradeCustomer.Controls.Add(this.lblUpgradeSurname);
            this.pnlUpgradeCustomer.Location = new System.Drawing.Point(243, 55);
            this.pnlUpgradeCustomer.Name = "pnlUpgradeCustomer";
            this.pnlUpgradeCustomer.Size = new System.Drawing.Size(224, 146);
            this.pnlUpgradeCustomer.TabIndex = 4;
            this.pnlUpgradeCustomer.Visible = false;
            // 
            // cmbUpgradePickCustomer
            // 
            this.cmbUpgradePickCustomer.FormattingEnabled = true;
            this.cmbUpgradePickCustomer.Location = new System.Drawing.Point(87, 36);
            this.cmbUpgradePickCustomer.Name = "cmbUpgradePickCustomer";
            this.cmbUpgradePickCustomer.Size = new System.Drawing.Size(127, 21);
            this.cmbUpgradePickCustomer.TabIndex = 12;
            this.cmbUpgradePickCustomer.SelectedIndexChanged += new System.EventHandler(this.cmbUpgradePickCustomer_SelectedIndexChanged);
            // 
            // lblUpgradeCustomerHeader
            // 
            this.lblUpgradeCustomerHeader.AutoSize = true;
            this.lblUpgradeCustomerHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUpgradeCustomerHeader.Location = new System.Drawing.Point(3, 10);
            this.lblUpgradeCustomerHeader.Name = "lblUpgradeCustomerHeader";
            this.lblUpgradeCustomerHeader.Size = new System.Drawing.Size(102, 13);
            this.lblUpgradeCustomerHeader.TabIndex = 1;
            this.lblUpgradeCustomerHeader.Text = "Musteri Guncelle";
            // 
            // lblUpgradePickCustomer
            // 
            this.lblUpgradePickCustomer.AutoSize = true;
            this.lblUpgradePickCustomer.Location = new System.Drawing.Point(3, 44);
            this.lblUpgradePickCustomer.Name = "lblUpgradePickCustomer";
            this.lblUpgradePickCustomer.Size = new System.Drawing.Size(78, 13);
            this.lblUpgradePickCustomer.TabIndex = 11;
            this.lblUpgradePickCustomer.Text = "Musteri Seciniz";
            // 
            // lblUpgradeName
            // 
            this.lblUpgradeName.AutoSize = true;
            this.lblUpgradeName.Location = new System.Drawing.Point(3, 71);
            this.lblUpgradeName.Name = "lblUpgradeName";
            this.lblUpgradeName.Size = new System.Drawing.Size(20, 13);
            this.lblUpgradeName.TabIndex = 6;
            this.lblUpgradeName.Text = "Ad";
            // 
            // btnUpgrade
            // 
            this.btnUpgrade.Location = new System.Drawing.Point(87, 116);
            this.btnUpgrade.Name = "btnUpgrade";
            this.btnUpgrade.Size = new System.Drawing.Size(127, 23);
            this.btnUpgrade.TabIndex = 10;
            this.btnUpgrade.Text = "Musteri Guncelle";
            this.btnUpgrade.UseVisualStyleBackColor = true;
            this.btnUpgrade.Click += new System.EventHandler(this.btnUpgrade_Click);
            // 
            // txtUpgradeSurname
            // 
            this.txtUpgradeSurname.Location = new System.Drawing.Point(87, 90);
            this.txtUpgradeSurname.Name = "txtUpgradeSurname";
            this.txtUpgradeSurname.Size = new System.Drawing.Size(127, 20);
            this.txtUpgradeSurname.TabIndex = 8;
            this.txtUpgradeSurname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInput_KeyPress);
            // 
            // txtUgradeName
            // 
            this.txtUgradeName.Location = new System.Drawing.Point(87, 64);
            this.txtUgradeName.Name = "txtUgradeName";
            this.txtUgradeName.Size = new System.Drawing.Size(127, 20);
            this.txtUgradeName.TabIndex = 7;
            this.txtUgradeName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInput_KeyPress);
            // 
            // lblUpgradeSurname
            // 
            this.lblUpgradeSurname.AutoSize = true;
            this.lblUpgradeSurname.Location = new System.Drawing.Point(3, 97);
            this.lblUpgradeSurname.Name = "lblUpgradeSurname";
            this.lblUpgradeSurname.Size = new System.Drawing.Size(37, 13);
            this.lblUpgradeSurname.TabIndex = 9;
            this.lblUpgradeSurname.Text = "Soyad";
            // 
            // pnlAddPhone
            // 
            this.pnlAddPhone.Controls.Add(this.btnAddPhone);
            this.pnlAddPhone.Controls.Add(this.txtAddPhoneType);
            this.pnlAddPhone.Controls.Add(this.txtAddPhoneNumber);
            this.pnlAddPhone.Controls.Add(this.cmbAddPhoneType);
            this.pnlAddPhone.Controls.Add(this.lblAddPhoneType);
            this.pnlAddPhone.Controls.Add(this.cmbAddPhonePickCustomer);
            this.pnlAddPhone.Controls.Add(this.lblAddPhoneHeader);
            this.pnlAddPhone.Controls.Add(this.lblAddPhonePickCustomer);
            this.pnlAddPhone.Location = new System.Drawing.Point(473, 55);
            this.pnlAddPhone.Name = "pnlAddPhone";
            this.pnlAddPhone.Size = new System.Drawing.Size(224, 146);
            this.pnlAddPhone.TabIndex = 4;
            this.pnlAddPhone.Visible = false;
            // 
            // btnAddPhone
            // 
            this.btnAddPhone.Location = new System.Drawing.Point(114, 116);
            this.btnAddPhone.Name = "btnAddPhone";
            this.btnAddPhone.Size = new System.Drawing.Size(100, 23);
            this.btnAddPhone.TabIndex = 13;
            this.btnAddPhone.Text = "Telefon Ekle";
            this.btnAddPhone.UseVisualStyleBackColor = true;
            this.btnAddPhone.Click += new System.EventHandler(this.btnAddPhone_Click);
            // 
            // txtAddPhoneType
            // 
            this.txtAddPhoneType.Location = new System.Drawing.Point(114, 90);
            this.txtAddPhoneType.Name = "txtAddPhoneType";
            this.txtAddPhoneType.Size = new System.Drawing.Size(100, 20);
            this.txtAddPhoneType.TabIndex = 13;
            this.txtAddPhoneType.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAddPhoneType_KeyPress);
            // 
            // txtAddPhoneNumber
            // 
            this.txtAddPhoneNumber.AutoSize = true;
            this.txtAddPhoneNumber.Location = new System.Drawing.Point(4, 97);
            this.txtAddPhoneNumber.Name = "txtAddPhoneNumber";
            this.txtAddPhoneNumber.Size = new System.Drawing.Size(90, 13);
            this.txtAddPhoneNumber.TabIndex = 17;
            this.txtAddPhoneNumber.Text = "Telefon Numarasi";
            // 
            // cmbAddPhoneType
            // 
            this.cmbAddPhoneType.FormattingEnabled = true;
            this.cmbAddPhoneType.Location = new System.Drawing.Point(114, 63);
            this.cmbAddPhoneType.Name = "cmbAddPhoneType";
            this.cmbAddPhoneType.Size = new System.Drawing.Size(100, 21);
            this.cmbAddPhoneType.TabIndex = 16;
            // 
            // lblAddPhoneType
            // 
            this.lblAddPhoneType.AutoSize = true;
            this.lblAddPhoneType.Location = new System.Drawing.Point(4, 71);
            this.lblAddPhoneType.Name = "lblAddPhoneType";
            this.lblAddPhoneType.Size = new System.Drawing.Size(100, 13);
            this.lblAddPhoneType.TabIndex = 15;
            this.lblAddPhoneType.Text = "Telefon Tipi Seciniz";
            // 
            // cmbAddPhonePickCustomer
            // 
            this.cmbAddPhonePickCustomer.FormattingEnabled = true;
            this.cmbAddPhonePickCustomer.Location = new System.Drawing.Point(114, 36);
            this.cmbAddPhonePickCustomer.Name = "cmbAddPhonePickCustomer";
            this.cmbAddPhonePickCustomer.Size = new System.Drawing.Size(100, 21);
            this.cmbAddPhonePickCustomer.TabIndex = 14;
            // 
            // lblAddPhoneHeader
            // 
            this.lblAddPhoneHeader.AutoSize = true;
            this.lblAddPhoneHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAddPhoneHeader.Location = new System.Drawing.Point(3, 10);
            this.lblAddPhoneHeader.Name = "lblAddPhoneHeader";
            this.lblAddPhoneHeader.Size = new System.Drawing.Size(79, 13);
            this.lblAddPhoneHeader.TabIndex = 2;
            this.lblAddPhoneHeader.Text = "Telefon Ekle";
            // 
            // lblAddPhonePickCustomer
            // 
            this.lblAddPhonePickCustomer.AutoSize = true;
            this.lblAddPhonePickCustomer.Location = new System.Drawing.Point(4, 40);
            this.lblAddPhonePickCustomer.Name = "lblAddPhonePickCustomer";
            this.lblAddPhonePickCustomer.Size = new System.Drawing.Size(78, 13);
            this.lblAddPhonePickCustomer.TabIndex = 13;
            this.lblAddPhonePickCustomer.Text = "Musteri Seciniz";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 223);
            this.Controls.Add(this.pnlUpgradeCustomer);
            this.Controls.Add(this.pnlAddPhone);
            this.Controls.Add(this.pnlAddCustomer);
            this.Controls.Add(this.btnAddPhonePanel);
            this.Controls.Add(this.btnUpdateCustomerPanel);
            this.Controls.Add(this.btnAddCustomerPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.pnlAddCustomer.ResumeLayout(false);
            this.pnlAddCustomer.PerformLayout();
            this.pnlUpgradeCustomer.ResumeLayout(false);
            this.pnlUpgradeCustomer.PerformLayout();
            this.pnlAddPhone.ResumeLayout(false);
            this.pnlAddPhone.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddCustomerPanel;
        private System.Windows.Forms.Button btnUpdateCustomerPanel;
        private System.Windows.Forms.Button btnAddPhonePanel;
        private System.Windows.Forms.Panel pnlAddCustomer;
        private System.Windows.Forms.Label lblAddCustomerHeader;
        private System.Windows.Forms.Panel pnlUpgradeCustomer;
        private System.Windows.Forms.Label lblUpgradeCustomerHeader;
        private System.Windows.Forms.Panel pnlAddPhone;
        private System.Windows.Forms.Label lblAddPhoneHeader;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblAddSurname;
        private System.Windows.Forms.TextBox txtAddSurname;
        private System.Windows.Forms.TextBox txtAddName;
        private System.Windows.Forms.Label lblAddName;
        private System.Windows.Forms.ComboBox cmbUpgradePickCustomer;
        private System.Windows.Forms.Label lblUpgradePickCustomer;
        private System.Windows.Forms.Label lblUpgradeName;
        private System.Windows.Forms.Button btnUpgrade;
        private System.Windows.Forms.TextBox txtUpgradeSurname;
        private System.Windows.Forms.TextBox txtUgradeName;
        private System.Windows.Forms.Label lblUpgradeSurname;
        private System.Windows.Forms.Button btnAddPhone;
        private System.Windows.Forms.TextBox txtAddPhoneType;
        private System.Windows.Forms.Label txtAddPhoneNumber;
        private System.Windows.Forms.ComboBox cmbAddPhoneType;
        private System.Windows.Forms.Label lblAddPhoneType;
        private System.Windows.Forms.ComboBox cmbAddPhonePickCustomer;
        private System.Windows.Forms.Label lblAddPhonePickCustomer;
    }
}

