namespace QuanLyRapChieu
{
    partial class frmDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDashboard));
            this.btn_Admin = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Staff = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Close = new Guna.UI2.WinForms.Guna2ImageButton();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblAccountInfo = new System.Windows.Forms.Label();
            this.btnClose = new Guna.UI2.WinForms.Guna2ImageButton();
            this.SuspendLayout();
            // 
            // btn_Admin
            // 
            this.btn_Admin.BorderRadius = 10;
            this.btn_Admin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Admin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Admin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Admin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Admin.FillColor = System.Drawing.Color.Navy;
            this.btn_Admin.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Admin.ForeColor = System.Drawing.Color.White;
            this.btn_Admin.Location = new System.Drawing.Point(72, 254);
            this.btn_Admin.Name = "btn_Admin";
            this.btn_Admin.Size = new System.Drawing.Size(303, 58);
            this.btn_Admin.TabIndex = 14;
            this.btn_Admin.Text = "Quản Lý";
            this.btn_Admin.Click += new System.EventHandler(this.btn_Admin_Click);
            // 
            // btn_Staff
            // 
            this.btn_Staff.BorderRadius = 10;
            this.btn_Staff.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Staff.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Staff.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Staff.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Staff.FillColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_Staff.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Staff.ForeColor = System.Drawing.Color.White;
            this.btn_Staff.Location = new System.Drawing.Point(72, 343);
            this.btn_Staff.Name = "btn_Staff";
            this.btn_Staff.Size = new System.Drawing.Size(303, 58);
            this.btn_Staff.TabIndex = 15;
            this.btn_Staff.Text = "Nhân Viên";
            this.btn_Staff.Click += new System.EventHandler(this.btn_Staff_Click);
            // 
            // btn_Close
            // 
            this.btn_Close.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btn_Close.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.btn_Close.Image = ((System.Drawing.Image)(resources.GetObject("btn_Close.Image")));
            this.btn_Close.ImageOffset = new System.Drawing.Point(0, 0);
            this.btn_Close.ImageRotate = 0F;
            this.btn_Close.ImageSize = new System.Drawing.Size(30, 30);
            this.btn_Close.Location = new System.Drawing.Point(393, 0);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btn_Close.Size = new System.Drawing.Size(51, 48);
            this.btn_Close.TabIndex = 16;
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(107, 111);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(231, 60);
            this.lblWelcome.TabIndex = 17;
            this.lblWelcome.Text = "Welcome!";
            // 
            // lblAccountInfo
            // 
            this.lblAccountInfo.AutoSize = true;
            this.lblAccountInfo.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccountInfo.Location = new System.Drawing.Point(110, 180);
            this.lblAccountInfo.Name = "lblAccountInfo";
            this.lblAccountInfo.Size = new System.Drawing.Size(149, 45);
            this.lblAccountInfo.TabIndex = 18;
            this.lblAccountInfo.Text = "Xin chào,";
            // 
            // btnClose
            // 
            this.btnClose.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnClose.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnClose.ImageRotate = 0F;
            this.btnClose.ImageSize = new System.Drawing.Size(30, 30);
            this.btnClose.Location = new System.Drawing.Point(393, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnClose.Size = new System.Drawing.Size(51, 48);
            this.btnClose.TabIndex = 19;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 481);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblAccountInfo);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.btn_Staff);
            this.Controls.Add(this.btn_Admin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button btn_Admin;
        private Guna.UI2.WinForms.Guna2Button btn_Staff;
        private Guna.UI2.WinForms.Guna2ImageButton btn_Close;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblAccountInfo;
        private Guna.UI2.WinForms.Guna2ImageButton btnClose;
    }
}