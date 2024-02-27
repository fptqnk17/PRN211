
namespace MyStoreWinApp
{
    partial class frmMemberDetails
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
            txtCountry = new TextBox();
            lbCountry = new Label();
            txtCity = new TextBox();
            lbCity = new Label();
            txtPassword = new TextBox();
            lbPassword = new Label();
            txtEmail = new TextBox();
            lbEmail = new Label();
            txtMemberName = new TextBox();
            lbMemberName = new Label();
            txtMemberID = new TextBox();
            lbMemberID = new Label();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnCancel = new Button();
            lbConfirm = new Label();
            txtConfirm = new TextBox();
            SuspendLayout();
            // 
            // txtCountry
            // 
            txtCountry.Location = new Point(142, 348);
            txtCountry.Margin = new Padding(3, 4, 3, 4);
            txtCountry.Name = "txtCountry";
            txtCountry.Size = new Size(210, 27);
            txtCountry.TabIndex = 23;
            // 
            // lbCountry
            // 
            lbCountry.AutoSize = true;
            lbCountry.Location = new Point(23, 352);
            lbCountry.Name = "lbCountry";
            lbCountry.Size = new Size(60, 20);
            lbCountry.TabIndex = 22;
            lbCountry.Text = "Country";
            // 
            // txtCity
            // 
            txtCity.Location = new Point(142, 293);
            txtCity.Margin = new Padding(3, 4, 3, 4);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(210, 27);
            txtCity.TabIndex = 21;
            // 
            // lbCity
            // 
            lbCity.AutoSize = true;
            lbCity.Location = new Point(23, 297);
            lbCity.Name = "lbCity";
            lbCity.Size = new Size(34, 20);
            lbCity.TabIndex = 20;
            lbCity.Text = "City";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(142, 187);
            txtPassword.Margin = new Padding(3, 4, 3, 4);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(210, 27);
            txtPassword.TabIndex = 18;
            // 
            // lbPassword
            // 
            lbPassword.AutoSize = true;
            lbPassword.Location = new Point(23, 191);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new Size(70, 20);
            lbPassword.TabIndex = 18;
            lbPassword.Text = "Password";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(142, 129);
            txtEmail.Margin = new Padding(3, 4, 3, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(210, 27);
            txtEmail.TabIndex = 17;
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Location = new Point(23, 133);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new Size(46, 20);
            lbEmail.TabIndex = 16;
            lbEmail.Text = "Email";
            // 
            // txtMemberName
            // 
            txtMemberName.Location = new Point(142, 75);
            txtMemberName.Margin = new Padding(3, 4, 3, 4);
            txtMemberName.Name = "txtMemberName";
            txtMemberName.Size = new Size(210, 27);
            txtMemberName.TabIndex = 15;
            // 
            // lbMemberName
            // 
            lbMemberName.AutoSize = true;
            lbMemberName.Location = new Point(23, 79);
            lbMemberName.Name = "lbMemberName";
            lbMemberName.Size = new Size(109, 20);
            lbMemberName.TabIndex = 14;
            lbMemberName.Text = "Member Name";
            // 
            // txtMemberID
            // 
            txtMemberID.Location = new Point(142, 20);
            txtMemberID.Margin = new Padding(3, 4, 3, 4);
            txtMemberID.Name = "txtMemberID";
            txtMemberID.Size = new Size(210, 27);
            txtMemberID.TabIndex = 13;
            // 
            // lbMemberID
            // 
            lbMemberID.AutoSize = true;
            lbMemberID.Location = new Point(23, 24);
            lbMemberID.Name = "lbMemberID";
            lbMemberID.Size = new Size(84, 20);
            lbMemberID.TabIndex = 12;
            lbMemberID.Text = "Member ID";
            // 
            // btnAdd
            // 
            btnAdd.DialogResult = DialogResult.OK;
            btnAdd.Location = new Point(71, 425);
            btnAdd.Margin = new Padding(3, 4, 3, 4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(107, 31);
            btnAdd.TabIndex = 24;
            btnAdd.Text = "&Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.DialogResult = DialogResult.OK;
            btnUpdate.Location = new Point(71, 425);
            btnUpdate.Margin = new Padding(3, 4, 3, 4);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(107, 31);
            btnUpdate.TabIndex = 25;
            btnUpdate.Text = "&Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnCancel
            // 
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.Location = new Point(209, 425);
            btnCancel.Margin = new Padding(3, 4, 3, 4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(107, 31);
            btnCancel.TabIndex = 26;
            btnCancel.Text = "&Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // lbConfirm
            // 
            lbConfirm.AutoSize = true;
            lbConfirm.Location = new Point(23, 243);
            lbConfirm.Name = "lbConfirm";
            lbConfirm.Size = new Size(62, 20);
            lbConfirm.TabIndex = 18;
            lbConfirm.Text = "Confirm";
            // 
            // txtConfirm
            // 
            txtConfirm.Location = new Point(142, 239);
            txtConfirm.Margin = new Padding(3, 4, 3, 4);
            txtConfirm.Name = "txtConfirm";
            txtConfirm.PasswordChar = '*';
            txtConfirm.Size = new Size(210, 27);
            txtConfirm.TabIndex = 19;
            // 
            // frmMemberDetails
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(392, 473);
            Controls.Add(btnCancel);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(txtCountry);
            Controls.Add(lbCountry);
            Controls.Add(txtCity);
            Controls.Add(lbCity);
            Controls.Add(txtConfirm);
            Controls.Add(lbConfirm);
            Controls.Add(txtPassword);
            Controls.Add(lbPassword);
            Controls.Add(txtEmail);
            Controls.Add(lbEmail);
            Controls.Add(txtMemberName);
            Controls.Add(lbMemberName);
            Controls.Add(txtMemberID);
            Controls.Add(lbMemberID);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmMemberDetails";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmMemberDetails";
            Load += frmMemberDetails_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.Label lbCountry;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label lbCity;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.TextBox txtMemberName;
        private System.Windows.Forms.Label lbMemberName;
        private System.Windows.Forms.TextBox txtMemberID;
        private System.Windows.Forms.Label lbMemberID;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lbConfirm;
        private System.Windows.Forms.TextBox txtConfirm;
    }
}