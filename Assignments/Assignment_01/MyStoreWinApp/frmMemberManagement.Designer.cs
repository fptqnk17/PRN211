
namespace MyStoreWinApp
{
    partial class frmMemberManagement
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
            lbMemberID = new Label();
            txtMemberID = new TextBox();
            lbMemberName = new Label();
            txtMemberName = new TextBox();
            lbEmail = new Label();
            txtEmail = new TextBox();
            lbPassword = new Label();
            txtPassword = new TextBox();
            lbCity = new Label();
            txtCity = new TextBox();
            lbCountry = new Label();
            txtCountry = new TextBox();
            btnLoad = new Button();
            btnNew = new Button();
            btnDelete = new Button();
            dgvMemberList = new DataGridView();
            lbSearch = new Label();
            txtSearchValue = new TextBox();
            lbSearchCountry = new Label();
            cboCountry = new ComboBox();
            lbSearchCity = new Label();
            cboSearchCity = new ComboBox();
            btnSearch = new Button();
            grSearch = new GroupBox();
            radioByName = new RadioButton();
            radioByID = new RadioButton();
            grFilter = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dgvMemberList).BeginInit();
            grSearch.SuspendLayout();
            grFilter.SuspendLayout();
            SuspendLayout();
            // 
            // lbMemberID
            // 
            lbMemberID.AutoSize = true;
            lbMemberID.Location = new Point(30, 40);
            lbMemberID.Name = "lbMemberID";
            lbMemberID.Size = new Size(84, 20);
            lbMemberID.TabIndex = 0;
            lbMemberID.Text = "Member ID";
            // 
            // txtMemberID
            // 
            txtMemberID.Location = new Point(149, 36);
            txtMemberID.Margin = new Padding(3, 4, 3, 4);
            txtMemberID.Name = "txtMemberID";
            txtMemberID.Size = new Size(210, 27);
            txtMemberID.TabIndex = 1;
            // 
            // lbMemberName
            // 
            lbMemberName.AutoSize = true;
            lbMemberName.Location = new Point(30, 95);
            lbMemberName.Name = "lbMemberName";
            lbMemberName.Size = new Size(109, 20);
            lbMemberName.TabIndex = 2;
            lbMemberName.Text = "Member Name";
            // 
            // txtMemberName
            // 
            txtMemberName.Location = new Point(149, 91);
            txtMemberName.Margin = new Padding(3, 4, 3, 4);
            txtMemberName.Name = "txtMemberName";
            txtMemberName.Size = new Size(210, 27);
            txtMemberName.TabIndex = 3;
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Location = new Point(30, 149);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new Size(46, 20);
            lbEmail.TabIndex = 4;
            lbEmail.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(149, 145);
            txtEmail.Margin = new Padding(3, 4, 3, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(210, 27);
            txtEmail.TabIndex = 5;
            // 
            // lbPassword
            // 
            lbPassword.AutoSize = true;
            lbPassword.Location = new Point(434, 40);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new Size(70, 20);
            lbPassword.TabIndex = 6;
            lbPassword.Text = "Password";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(510, 36);
            txtPassword.Margin = new Padding(3, 4, 3, 4);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(210, 27);
            txtPassword.TabIndex = 7;
            // 
            // lbCity
            // 
            lbCity.AutoSize = true;
            lbCity.Location = new Point(434, 95);
            lbCity.Name = "lbCity";
            lbCity.Size = new Size(34, 20);
            lbCity.TabIndex = 8;
            lbCity.Text = "City";
            // 
            // txtCity
            // 
            txtCity.Location = new Point(510, 91);
            txtCity.Margin = new Padding(3, 4, 3, 4);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(210, 27);
            txtCity.TabIndex = 9;
            // 
            // lbCountry
            // 
            lbCountry.AutoSize = true;
            lbCountry.Location = new Point(434, 149);
            lbCountry.Name = "lbCountry";
            lbCountry.Size = new Size(60, 20);
            lbCountry.TabIndex = 10;
            lbCountry.Text = "Country";
            // 
            // txtCountry
            // 
            txtCountry.Location = new Point(510, 145);
            txtCountry.Margin = new Padding(3, 4, 3, 4);
            txtCountry.Name = "txtCountry";
            txtCountry.Size = new Size(210, 27);
            txtCountry.TabIndex = 11;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(234, 216);
            btnLoad.Margin = new Padding(3, 4, 3, 4);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(125, 31);
            btnLoad.TabIndex = 12;
            btnLoad.Text = "&Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // btnNew
            // 
            btnNew.Location = new Point(464, 216);
            btnNew.Margin = new Padding(3, 4, 3, 4);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(125, 31);
            btnNew.TabIndex = 13;
            btnNew.Text = "&New";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(595, 216);
            btnDelete.Margin = new Padding(3, 4, 3, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(125, 31);
            btnDelete.TabIndex = 14;
            btnDelete.Text = "&Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // dgvMemberList
            // 
            dgvMemberList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMemberList.Location = new Point(30, 396);
            dgvMemberList.Margin = new Padding(3, 4, 3, 4);
            dgvMemberList.Name = "dgvMemberList";
            dgvMemberList.ReadOnly = true;
            dgvMemberList.RowHeadersWidth = 51;
            dgvMemberList.RowTemplate.Height = 25;
            dgvMemberList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMemberList.Size = new Size(690, 288);
            dgvMemberList.TabIndex = 15;
            dgvMemberList.CellDoubleClick += dgvMemberList_CellDoubleClick;
            // 
            // lbSearch
            // 
            lbSearch.AutoSize = true;
            lbSearch.Location = new Point(27, 28);
            lbSearch.Name = "lbSearch";
            lbSearch.Size = new Size(53, 20);
            lbSearch.TabIndex = 16;
            lbSearch.Text = "Search";
            // 
            // txtSearchValue
            // 
            txtSearchValue.Location = new Point(82, 24);
            txtSearchValue.Margin = new Padding(3, 4, 3, 4);
            txtSearchValue.Name = "txtSearchValue";
            txtSearchValue.Size = new Size(134, 27);
            txtSearchValue.TabIndex = 17;
            // 
            // lbSearchCountry
            // 
            lbSearchCountry.AutoSize = true;
            lbSearchCountry.Location = new Point(31, 31);
            lbSearchCountry.Name = "lbSearchCountry";
            lbSearchCountry.Size = new Size(60, 20);
            lbSearchCountry.TabIndex = 18;
            lbSearchCountry.Text = "Country";
            // 
            // cboCountry
            // 
            cboCountry.Location = new Point(88, 27);
            cboCountry.Margin = new Padding(3, 4, 3, 4);
            cboCountry.Name = "cboCountry";
            cboCountry.Size = new Size(188, 28);
            cboCountry.TabIndex = 0;
            cboCountry.SelectedIndexChanged += cboCountry_SelectedIndexChanged;
            // 
            // lbSearchCity
            // 
            lbSearchCity.AutoSize = true;
            lbSearchCity.Location = new Point(37, 77);
            lbSearchCity.Name = "lbSearchCity";
            lbSearchCity.Size = new Size(34, 20);
            lbSearchCity.TabIndex = 19;
            lbSearchCity.Text = "City";
            // 
            // cboSearchCity
            // 
            cboSearchCity.Location = new Point(88, 73);
            cboSearchCity.Margin = new Padding(3, 4, 3, 4);
            cboSearchCity.Name = "cboSearchCity";
            cboSearchCity.Size = new Size(188, 28);
            cboSearchCity.TabIndex = 20;
            cboSearchCity.SelectedIndexChanged += cboSearchCity_SelectedIndexChanged;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(82, 69);
            btnSearch.Margin = new Padding(3, 4, 3, 4);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(86, 31);
            btnSearch.TabIndex = 21;
            btnSearch.Text = "&Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // grSearch
            // 
            grSearch.Controls.Add(radioByName);
            grSearch.Controls.Add(radioByID);
            grSearch.Controls.Add(txtSearchValue);
            grSearch.Controls.Add(btnSearch);
            grSearch.Controls.Add(lbSearch);
            grSearch.Location = new Point(29, 255);
            grSearch.Margin = new Padding(3, 4, 3, 4);
            grSearch.Name = "grSearch";
            grSearch.Padding = new Padding(3, 4, 3, 4);
            grSearch.Size = new Size(330, 119);
            grSearch.TabIndex = 22;
            grSearch.TabStop = false;
            grSearch.Text = "Search";
            // 
            // radioByName
            // 
            radioByName.AutoSize = true;
            radioByName.Checked = true;
            radioByName.Location = new Point(240, 69);
            radioByName.Margin = new Padding(3, 4, 3, 4);
            radioByName.Name = "radioByName";
            radioByName.Size = new Size(90, 24);
            radioByName.TabIndex = 23;
            radioByName.TabStop = true;
            radioByName.Text = "By Name";
            radioByName.UseVisualStyleBackColor = true;
            // 
            // radioByID
            // 
            radioByID.AutoSize = true;
            radioByID.Location = new Point(240, 29);
            radioByID.Margin = new Padding(3, 4, 3, 4);
            radioByID.Name = "radioByID";
            radioByID.Size = new Size(65, 24);
            radioByID.TabIndex = 22;
            radioByID.TabStop = true;
            radioByID.Text = "By ID";
            radioByID.UseVisualStyleBackColor = true;
            // 
            // grFilter
            // 
            grFilter.Controls.Add(cboSearchCity);
            grFilter.Controls.Add(lbSearchCity);
            grFilter.Controls.Add(cboCountry);
            grFilter.Controls.Add(lbSearchCountry);
            grFilter.Location = new Point(422, 260);
            grFilter.Margin = new Padding(3, 4, 3, 4);
            grFilter.Name = "grFilter";
            grFilter.Padding = new Padding(3, 4, 3, 4);
            grFilter.Size = new Size(297, 112);
            grFilter.TabIndex = 23;
            grFilter.TabStop = false;
            grFilter.Text = "Filter";
            // 
            // frmMemberManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(754, 700);
            Controls.Add(grFilter);
            Controls.Add(grSearch);
            Controls.Add(dgvMemberList);
            Controls.Add(btnDelete);
            Controls.Add(btnNew);
            Controls.Add(btnLoad);
            Controls.Add(txtCountry);
            Controls.Add(lbCountry);
            Controls.Add(txtCity);
            Controls.Add(lbCity);
            Controls.Add(txtPassword);
            Controls.Add(lbPassword);
            Controls.Add(txtEmail);
            Controls.Add(lbEmail);
            Controls.Add(txtMemberName);
            Controls.Add(lbMemberName);
            Controls.Add(txtMemberID);
            Controls.Add(lbMemberID);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmMemberManagement";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Member Management";
            Load += frmMemberManagement_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMemberList).EndInit();
            grSearch.ResumeLayout(false);
            grSearch.PerformLayout();
            grFilter.ResumeLayout(false);
            grFilter.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lbMemberID;
        private System.Windows.Forms.TextBox txtMemberID;
        private System.Windows.Forms.Label lbMemberName;
        private System.Windows.Forms.TextBox txtMemberName;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lbCity;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label lbCountry;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dgvMemberList;
        private System.Windows.Forms.Label lbSearch;
        private System.Windows.Forms.TextBox txtSearchValue;
        private System.Windows.Forms.Label lbSearchCountry;
        private System.Windows.Forms.ComboBox cboCountry;
        private System.Windows.Forms.Label lbSearchCity;
        private System.Windows.Forms.ComboBox cboSearchCity;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox grSearch;
        private System.Windows.Forms.RadioButton io;
        private System.Windows.Forms.RadioButton radioByID;
        private System.Windows.Forms.RadioButton radioByName;
        private System.Windows.Forms.GroupBox grFilter;
    }
}