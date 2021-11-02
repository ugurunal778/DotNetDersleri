
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.btnCustomerAdd = new System.Windows.Forms.Button();
            this.pnlCustomerAdd = new System.Windows.Forms.Panel();
            this.lblCustomerAddHeader = new System.Windows.Forms.Label();
            this.btnOpenCustomerCreatePanel = new System.Windows.Forms.Button();
            this.btnOpenCustomerUpdatePanel = new System.Windows.Forms.Button();
            this.pnlCustomerUpdate = new System.Windows.Forms.Panel();
            this.cmbCustomer = new System.Windows.Forms.ComboBox();
            this.lblCustomerSelect = new System.Windows.Forms.Label();
            this.lblCustomerUpdateHeader = new System.Windows.Forms.Label();
            this.lblNameUpdate = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lblSurnameUpdate = new System.Windows.Forms.Label();
            this.txtSurnameUpdate = new System.Windows.Forms.TextBox();
            this.txtNameUpdate = new System.Windows.Forms.TextBox();
            this.pnlCustomerAdd.SuspendLayout();
            this.pnlCustomerUpdate.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(4, 29);
            this.lblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(25, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "İsim";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(4, 49);
            this.lblSurname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(42, 13);
            this.lblSurname.TabIndex = 1;
            this.lblSurname.Text = "Soyisim";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(77, 25);
            this.txtName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(115, 20);
            this.txtName.TabIndex = 2;
            this.txtName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtName_KeyPress);
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(77, 45);
            this.txtSurname.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(115, 20);
            this.txtSurname.TabIndex = 3;
            this.txtSurname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSurname_KeyPress);
            // 
            // btnCustomerAdd
            // 
            this.btnCustomerAdd.Location = new System.Drawing.Point(77, 67);
            this.btnCustomerAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCustomerAdd.Name = "btnCustomerAdd";
            this.btnCustomerAdd.Size = new System.Drawing.Size(114, 23);
            this.btnCustomerAdd.TabIndex = 4;
            this.btnCustomerAdd.Text = "Müşteri Ekle";
            this.btnCustomerAdd.UseVisualStyleBackColor = true;
            this.btnCustomerAdd.Click += new System.EventHandler(this.btnCustomerAdd_Click);
            // 
            // pnlCustomerAdd
            // 
            this.pnlCustomerAdd.Controls.Add(this.lblCustomerAddHeader);
            this.pnlCustomerAdd.Controls.Add(this.lblName);
            this.pnlCustomerAdd.Controls.Add(this.btnCustomerAdd);
            this.pnlCustomerAdd.Controls.Add(this.lblSurname);
            this.pnlCustomerAdd.Controls.Add(this.txtSurname);
            this.pnlCustomerAdd.Controls.Add(this.txtName);
            this.pnlCustomerAdd.Location = new System.Drawing.Point(8, 84);
            this.pnlCustomerAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlCustomerAdd.Name = "pnlCustomerAdd";
            this.pnlCustomerAdd.Size = new System.Drawing.Size(207, 92);
            this.pnlCustomerAdd.TabIndex = 5;
            this.pnlCustomerAdd.Visible = false;
            // 
            // lblCustomerAddHeader
            // 
            this.lblCustomerAddHeader.AutoSize = true;
            this.lblCustomerAddHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCustomerAddHeader.Location = new System.Drawing.Point(4, 6);
            this.lblCustomerAddHeader.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCustomerAddHeader.Name = "lblCustomerAddHeader";
            this.lblCustomerAddHeader.Size = new System.Drawing.Size(77, 13);
            this.lblCustomerAddHeader.TabIndex = 5;
            this.lblCustomerAddHeader.Text = "Müşteri Ekle";
            // 
            // btnOpenCustomerCreatePanel
            // 
            this.btnOpenCustomerCreatePanel.Location = new System.Drawing.Point(8, 40);
            this.btnOpenCustomerCreatePanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnOpenCustomerCreatePanel.Name = "btnOpenCustomerCreatePanel";
            this.btnOpenCustomerCreatePanel.Size = new System.Drawing.Size(207, 31);
            this.btnOpenCustomerCreatePanel.TabIndex = 6;
            this.btnOpenCustomerCreatePanel.Text = "Müşteri Ekle";
            this.btnOpenCustomerCreatePanel.UseVisualStyleBackColor = true;
            this.btnOpenCustomerCreatePanel.Click += new System.EventHandler(this.btnOpenCustomerPanel_Click);
            // 
            // btnOpenCustomerUpdatePanel
            // 
            this.btnOpenCustomerUpdatePanel.Location = new System.Drawing.Point(219, 40);
            this.btnOpenCustomerUpdatePanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnOpenCustomerUpdatePanel.Name = "btnOpenCustomerUpdatePanel";
            this.btnOpenCustomerUpdatePanel.Size = new System.Drawing.Size(207, 31);
            this.btnOpenCustomerUpdatePanel.TabIndex = 8;
            this.btnOpenCustomerUpdatePanel.Text = "Müşteri Güncelle";
            this.btnOpenCustomerUpdatePanel.UseVisualStyleBackColor = true;
            this.btnOpenCustomerUpdatePanel.Click += new System.EventHandler(this.btnOpenCustomerUpdatePanel_Click);
            // 
            // pnlCustomerUpdate
            // 
            this.pnlCustomerUpdate.Controls.Add(this.cmbCustomer);
            this.pnlCustomerUpdate.Controls.Add(this.lblCustomerSelect);
            this.pnlCustomerUpdate.Controls.Add(this.lblCustomerUpdateHeader);
            this.pnlCustomerUpdate.Controls.Add(this.lblNameUpdate);
            this.pnlCustomerUpdate.Controls.Add(this.btnUpdate);
            this.pnlCustomerUpdate.Controls.Add(this.lblSurnameUpdate);
            this.pnlCustomerUpdate.Controls.Add(this.txtSurnameUpdate);
            this.pnlCustomerUpdate.Controls.Add(this.txtNameUpdate);
            this.pnlCustomerUpdate.Location = new System.Drawing.Point(219, 84);
            this.pnlCustomerUpdate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlCustomerUpdate.Name = "pnlCustomerUpdate";
            this.pnlCustomerUpdate.Size = new System.Drawing.Size(207, 125);
            this.pnlCustomerUpdate.TabIndex = 7;
            this.pnlCustomerUpdate.Visible = false;
            // 
            // cmbCustomer
            // 
            this.cmbCustomer.FormattingEnabled = true;
            this.cmbCustomer.Location = new System.Drawing.Point(91, 31);
            this.cmbCustomer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbCustomer.Name = "cmbCustomer";
            this.cmbCustomer.Size = new System.Drawing.Size(115, 21);
            this.cmbCustomer.TabIndex = 7;
            this.cmbCustomer.SelectedIndexChanged += new System.EventHandler(this.cmbCustomer_SelectedIndexChanged);
            // 
            // lblCustomerSelect
            // 
            this.lblCustomerSelect.AutoSize = true;
            this.lblCustomerSelect.Location = new System.Drawing.Point(4, 32);
            this.lblCustomerSelect.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCustomerSelect.Name = "lblCustomerSelect";
            this.lblCustomerSelect.Size = new System.Drawing.Size(78, 13);
            this.lblCustomerSelect.TabIndex = 6;
            this.lblCustomerSelect.Text = "Müşteri Seçiniz";
            // 
            // lblCustomerUpdateHeader
            // 
            this.lblCustomerUpdateHeader.AutoSize = true;
            this.lblCustomerUpdateHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCustomerUpdateHeader.Location = new System.Drawing.Point(4, 6);
            this.lblCustomerUpdateHeader.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCustomerUpdateHeader.Name = "lblCustomerUpdateHeader";
            this.lblCustomerUpdateHeader.Size = new System.Drawing.Size(102, 13);
            this.lblCustomerUpdateHeader.TabIndex = 5;
            this.lblCustomerUpdateHeader.Text = "Müşteri Güncelle";
            // 
            // lblNameUpdate
            // 
            this.lblNameUpdate.AutoSize = true;
            this.lblNameUpdate.Location = new System.Drawing.Point(4, 53);
            this.lblNameUpdate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNameUpdate.Name = "lblNameUpdate";
            this.lblNameUpdate.Size = new System.Drawing.Size(25, 13);
            this.lblNameUpdate.TabIndex = 0;
            this.lblNameUpdate.Text = "İsim";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(93, 95);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(114, 23);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "Müşteri Güncelle";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lblSurnameUpdate
            // 
            this.lblSurnameUpdate.AutoSize = true;
            this.lblSurnameUpdate.Location = new System.Drawing.Point(4, 74);
            this.lblSurnameUpdate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSurnameUpdate.Name = "lblSurnameUpdate";
            this.lblSurnameUpdate.Size = new System.Drawing.Size(42, 13);
            this.lblSurnameUpdate.TabIndex = 1;
            this.lblSurnameUpdate.Text = "Soyisim";
            // 
            // txtSurnameUpdate
            // 
            this.txtSurnameUpdate.Location = new System.Drawing.Point(91, 74);
            this.txtSurnameUpdate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSurnameUpdate.Name = "txtSurnameUpdate";
            this.txtSurnameUpdate.Size = new System.Drawing.Size(115, 20);
            this.txtSurnameUpdate.TabIndex = 3;
            // 
            // txtNameUpdate
            // 
            this.txtNameUpdate.Location = new System.Drawing.Point(91, 53);
            this.txtNameUpdate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNameUpdate.Name = "txtNameUpdate";
            this.txtNameUpdate.Size = new System.Drawing.Size(115, 20);
            this.txtNameUpdate.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 292);
            this.Controls.Add(this.btnOpenCustomerUpdatePanel);
            this.Controls.Add(this.pnlCustomerUpdate);
            this.Controls.Add(this.btnOpenCustomerCreatePanel);
            this.Controls.Add(this.pnlCustomerAdd);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlCustomerAdd.ResumeLayout(false);
            this.pnlCustomerAdd.PerformLayout();
            this.pnlCustomerUpdate.ResumeLayout(false);
            this.pnlCustomerUpdate.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Button btnCustomerAdd;
        private System.Windows.Forms.Panel pnlCustomerAdd;
        private System.Windows.Forms.Label lblCustomerAddHeader;
        private System.Windows.Forms.Button btnOpenCustomerCreatePanel;
        private System.Windows.Forms.Button btnOpenCustomerUpdatePanel;
        private System.Windows.Forms.Panel pnlCustomerUpdate;
        private System.Windows.Forms.Label lblCustomerUpdateHeader;
        private System.Windows.Forms.Label lblNameUpdate;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lblSurnameUpdate;
        private System.Windows.Forms.TextBox txtSurnameUpdate;
        private System.Windows.Forms.TextBox txtNameUpdate;
        private System.Windows.Forms.ComboBox cmbCustomer;
        private System.Windows.Forms.Label lblCustomerSelect;
    }
}

