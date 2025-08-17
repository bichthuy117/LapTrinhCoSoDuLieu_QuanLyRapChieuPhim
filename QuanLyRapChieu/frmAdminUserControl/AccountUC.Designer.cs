using System;
using System.Windows.Forms;

namespace QuanLyRapChieu.frmAdminUserControl
{
    partial class AccountUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccountUC));
            this.Show_MK = new System.Windows.Forms.CheckBox();
            this.txt_Pass = new System.Windows.Forms.TextBox();
            this.txt_idNV = new System.Windows.Forms.TextBox();
            this.nudAccountType = new System.Windows.Forms.NumericUpDown();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblStaffName_Account = new System.Windows.Forms.Label();
            this.lblAccountType = new System.Windows.Forms.Label();
            this.lblStaffID_Account = new System.Windows.Forms.Label();
            this.grpAccount = new Guna.UI2.WinForms.Guna2GroupBox();
            this.grpDetailAcc = new System.Windows.Forms.GroupBox();
            this.dtgvAccount = new System.Windows.Forms.DataGridView();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoaiTK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbAccUC = new System.Windows.Forms.Label();
            this.btnInsertAccount = new Guna.UI2.WinForms.Guna2Button();
            this.btnUpdateAccount = new Guna.UI2.WinForms.Guna2Button();
            this.btnDeleteAccount = new Guna.UI2.WinForms.Guna2Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.nudAccountType)).BeginInit();
            this.grpAccount.SuspendLayout();
            this.grpDetailAcc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvAccount)).BeginInit();
            this.SuspendLayout();
            // 
            // Show_MK
            // 
            this.Show_MK.AutoSize = true;
            this.Show_MK.Font = new System.Drawing.Font("Times New Roman", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Show_MK.ForeColor = System.Drawing.Color.SlateGray;
            this.Show_MK.Location = new System.Drawing.Point(608, 191);
            this.Show_MK.Name = "Show_MK";
            this.Show_MK.Size = new System.Drawing.Size(176, 29);
            this.Show_MK.TabIndex = 7;
            this.Show_MK.Text = "Hiện mật khẩu";
            this.Show_MK.UseMnemonic = false;
            this.Show_MK.UseVisualStyleBackColor = true;
            this.Show_MK.CheckedChanged += new System.EventHandler(this.Show_MK_CheckedChanged);
            // 
            // txt_Pass
            // 
            this.txt_Pass.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Pass.Location = new System.Drawing.Point(180, 129);
            this.txt_Pass.Multiline = true;
            this.txt_Pass.Name = "txt_Pass";
            this.txt_Pass.PasswordChar = '*';
            this.txt_Pass.Size = new System.Drawing.Size(200, 41);
            this.txt_Pass.TabIndex = 8;
            // 
            // txt_idNV
            // 
            this.txt_idNV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_idNV.Location = new System.Drawing.Point(573, 131);
            this.txt_idNV.Name = "txt_idNV";
            this.txt_idNV.Size = new System.Drawing.Size(187, 35);
            this.txt_idNV.TabIndex = 7;
            // 
            // nudAccountType
            // 
            this.nudAccountType.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudAccountType.Location = new System.Drawing.Point(573, 71);
            this.nudAccountType.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudAccountType.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudAccountType.Name = "nudAccountType";
            this.nudAccountType.Size = new System.Drawing.Size(186, 35);
            this.nudAccountType.TabIndex = 6;
            this.nudAccountType.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(30, 78);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(123, 26);
            this.lblUsername.TabIndex = 4;
            this.lblUsername.Text = "Username:\r\n";
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(180, 77);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(200, 35);
            this.txtUsername.TabIndex = 2;
            // 
            // lblStaffName_Account
            // 
            this.lblStaffName_Account.AutoSize = true;
            this.lblStaffName_Account.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStaffName_Account.Location = new System.Drawing.Point(33, 131);
            this.lblStaffName_Account.Name = "lblStaffName_Account";
            this.lblStaffName_Account.Size = new System.Drawing.Size(118, 26);
            this.lblStaffName_Account.TabIndex = 4;
            this.lblStaffName_Account.Text = "Password:\r\n";
            // 
            // lblAccountType
            // 
            this.lblAccountType.AutoSize = true;
            this.lblAccountType.BackColor = System.Drawing.Color.Transparent;
            this.lblAccountType.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccountType.Location = new System.Drawing.Point(441, 77);
            this.lblAccountType.Name = "lblAccountType";
            this.lblAccountType.Size = new System.Drawing.Size(113, 26);
            this.lblAccountType.TabIndex = 4;
            this.lblAccountType.Text = "Loại TK: ";
            // 
            // lblStaffID_Account
            // 
            this.lblStaffID_Account.AutoSize = true;
            this.lblStaffID_Account.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStaffID_Account.Location = new System.Drawing.Point(441, 131);
            this.lblStaffID_Account.Name = "lblStaffID_Account";
            this.lblStaffID_Account.Size = new System.Drawing.Size(93, 26);
            this.lblStaffID_Account.TabIndex = 4;
            this.lblStaffID_Account.Text = "Mã NV:";
            // 
            // grpAccount
            // 
            this.grpAccount.Controls.Add(this.txt_idNV);
            this.grpAccount.Controls.Add(this.lblAccountType);
            this.grpAccount.Controls.Add(this.txtUsername);
            this.grpAccount.Controls.Add(this.Show_MK);
            this.grpAccount.Controls.Add(this.lblStaffID_Account);
            this.grpAccount.Controls.Add(this.nudAccountType);
            this.grpAccount.Controls.Add(this.lblStaffName_Account);
            this.grpAccount.Controls.Add(this.txt_Pass);
            this.grpAccount.Controls.Add(this.lblUsername);
            this.grpAccount.FillColor = System.Drawing.Color.Transparent;
            this.grpAccount.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpAccount.ForeColor = System.Drawing.Color.DimGray;
            this.grpAccount.Location = new System.Drawing.Point(384, 20);
            this.grpAccount.Name = "grpAccount";
            this.grpAccount.Size = new System.Drawing.Size(826, 238);
            this.grpAccount.TabIndex = 16;
            this.grpAccount.Text = "Tra cứu thông tin tài khoản";
            // 
            // grpDetailAcc
            // 
            this.grpDetailAcc.Controls.Add(this.dtgvAccount);
            this.grpDetailAcc.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDetailAcc.ForeColor = System.Drawing.Color.DimGray;
            this.grpDetailAcc.Location = new System.Drawing.Point(93, 352);
            this.grpDetailAcc.Name = "grpDetailAcc";
            this.grpDetailAcc.Size = new System.Drawing.Size(1276, 538);
            this.grpDetailAcc.TabIndex = 28;
            this.grpDetailAcc.TabStop = false;
            this.grpDetailAcc.Text = "Thông tin chi tiết tài khoản";
            // 
            // dtgvAccount
            // 
            this.dtgvAccount.AllowUserToAddRows = false;
            this.dtgvAccount.AllowUserToDeleteRows = false;
            this.dtgvAccount.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvAccount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgvAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvAccount.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserName,
            this.Pass,
            this.LoaiTK,
            this.IdNV});
            this.dtgvAccount.Location = new System.Drawing.Point(0, 0);
            this.dtgvAccount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtgvAccount.Name = "dtgvAccount";
            this.dtgvAccount.ReadOnly = true;
            this.dtgvAccount.RowHeadersWidth = 62;
            this.dtgvAccount.Size = new System.Drawing.Size(1276, 538);
            this.dtgvAccount.TabIndex = 15;
            // 
            // UserName
            // 
            this.UserName.DataPropertyName = "UserName";
            this.UserName.HeaderText = "Tên Đăng Nhập";
            this.UserName.MinimumWidth = 8;
            this.UserName.Name = "UserName";
            this.UserName.ReadOnly = true;
            // 
            // Pass
            // 
            this.Pass.DataPropertyName = "Pass";
            this.Pass.HeaderText = "Mật Khẩu";
            this.Pass.MinimumWidth = 8;
            this.Pass.Name = "Pass";
            this.Pass.ReadOnly = true;
            // 
            // LoaiTK
            // 
            this.LoaiTK.DataPropertyName = "LoaiTK";
            this.LoaiTK.HeaderText = "Loại Tài Khoản";
            this.LoaiTK.MinimumWidth = 8;
            this.LoaiTK.Name = "LoaiTK";
            this.LoaiTK.ReadOnly = true;
            // 
            // IdNV
            // 
            this.IdNV.DataPropertyName = "IdNV";
            this.IdNV.HeaderText = "Mã Nhân Viên";
            this.IdNV.MinimumWidth = 8;
            this.IdNV.Name = "IdNV";
            this.IdNV.ReadOnly = true;
            // 
            // lbAccUC
            // 
            this.lbAccUC.AutoSize = true;
            this.lbAccUC.Font = new System.Drawing.Font("Segoe UI", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAccUC.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lbAccUC.Location = new System.Drawing.Point(75, 228);
            this.lbAccUC.Name = "lbAccUC";
            this.lbAccUC.Size = new System.Drawing.Size(262, 38);
            this.lbAccUC.TabIndex = 29;
            this.lbAccUC.Text = "OMG Staff Cinema";
            // 
            // btnInsertAccount
            // 
            this.btnInsertAccount.AutoRoundedCorners = true;
            this.btnInsertAccount.BackColor = System.Drawing.Color.Transparent;
            this.btnInsertAccount.BorderColor = System.Drawing.Color.White;
            this.btnInsertAccount.BorderThickness = 2;
            this.btnInsertAccount.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnInsertAccount.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnInsertAccount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnInsertAccount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnInsertAccount.FillColor = System.Drawing.Color.LightSlateGray;
            this.btnInsertAccount.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.btnInsertAccount.ForeColor = System.Drawing.Color.White;
            this.btnInsertAccount.Location = new System.Drawing.Point(489, 283);
            this.btnInsertAccount.Name = "btnInsertAccount";
            this.btnInsertAccount.Size = new System.Drawing.Size(140, 62);
            this.btnInsertAccount.TabIndex = 30;
            this.btnInsertAccount.Text = "Thêm";
            this.btnInsertAccount.Click += new System.EventHandler(this.btnInsertAccount_Click);
            // 
            // btnUpdateAccount
            // 
            this.btnUpdateAccount.AutoRoundedCorners = true;
            this.btnUpdateAccount.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btnUpdateAccount.BorderThickness = 2;
            this.btnUpdateAccount.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdateAccount.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdateAccount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUpdateAccount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUpdateAccount.FillColor = System.Drawing.Color.LightSlateGray;
            this.btnUpdateAccount.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.btnUpdateAccount.ForeColor = System.Drawing.Color.White;
            this.btnUpdateAccount.Location = new System.Drawing.Point(717, 283);
            this.btnUpdateAccount.Name = "btnUpdateAccount";
            this.btnUpdateAccount.Size = new System.Drawing.Size(152, 62);
            this.btnUpdateAccount.TabIndex = 31;
            this.btnUpdateAccount.Text = "Sửa";
            this.btnUpdateAccount.Click += new System.EventHandler(this.btnUpdateAccount_Click);
            // 
            // btnDeleteAccount
            // 
            this.btnDeleteAccount.AutoRoundedCorners = true;
            this.btnDeleteAccount.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btnDeleteAccount.BorderRadius = 30;
            this.btnDeleteAccount.BorderThickness = 2;
            this.btnDeleteAccount.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteAccount.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteAccount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDeleteAccount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDeleteAccount.FillColor = System.Drawing.Color.LightSlateGray;
            this.btnDeleteAccount.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.btnDeleteAccount.ForeColor = System.Drawing.Color.White;
            this.btnDeleteAccount.Location = new System.Drawing.Point(958, 283);
            this.btnDeleteAccount.Name = "btnDeleteAccount";
            this.btnDeleteAccount.Size = new System.Drawing.Size(142, 62);
            this.btnDeleteAccount.TabIndex = 32;
            this.btnDeleteAccount.Text = "Xóa";
            this.btnDeleteAccount.Click += new System.EventHandler(this.btnDeleteAccount_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Location = new System.Drawing.Point(93, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(199, 202);
            this.panel1.TabIndex = 33;
            // 
            // AccountUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnDeleteAccount);
            this.Controls.Add(this.btnUpdateAccount);
            this.Controls.Add(this.btnInsertAccount);
            this.Controls.Add(this.lbAccUC);
            this.Controls.Add(this.grpDetailAcc);
            this.Controls.Add(this.grpAccount);
            this.Name = "AccountUC";
            this.Size = new System.Drawing.Size(1491, 940);
            ((System.ComponentModel.ISupportInitialize)(this.nudAccountType)).EndInit();
            this.grpAccount.ResumeLayout(false);
            this.grpAccount.PerformLayout();
            this.grpDetailAcc.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvAccount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NumericUpDown nudAccountType;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblStaffName_Account;
        private System.Windows.Forms.Label lblAccountType;
        private System.Windows.Forms.Label lblStaffID_Account;
        private System.Windows.Forms.TextBox txt_idNV;
        private System.Windows.Forms.TextBox txt_Pass;
        private System.Windows.Forms.CheckBox Show_MK;
        private Guna.UI2.WinForms.Guna2GroupBox grpAccount;
        private System.Windows.Forms.GroupBox grpDetailAcc;
        private Label lbAccUC;
        private Guna.UI2.WinForms.Guna2Button btnInsertAccount;
        private Guna.UI2.WinForms.Guna2Button btnUpdateAccount;
        private Guna.UI2.WinForms.Guna2Button btnDeleteAccount;
        private Panel panel1;
        private DataGridView dtgvAccount;
        private DataGridViewTextBoxColumn UserName;
        private DataGridViewTextBoxColumn Pass;
        private DataGridViewTextBoxColumn LoaiTK;
        private DataGridViewTextBoxColumn IdNV;
    }
}
