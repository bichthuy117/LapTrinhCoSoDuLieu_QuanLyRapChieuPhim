namespace QuanLyRapChieu
{
    partial class frmStaff
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStaff));
            this.el_TestLichChieu = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.pn_LichChieuPhim = new Guna.UI2.WinForms.Guna2Panel();
            this.btnClose = new Guna.UI2.WinForms.Guna2ImageButton();
            this.labelX = new System.Windows.Forms.Label();
            this.el_Backgr = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.gn_Backgr = new Guna.UI2.WinForms.Guna2Panel();
            this.dtpThoiGian = new System.Windows.Forms.DateTimePicker();
            this.cboFilmName = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lbl_Phim = new System.Windows.Forms.Label();
            this.lbl_Tgian = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtv_CaChieu = new System.Windows.Forms.DataGridView();
            this.btn_ChonVe = new System.Windows.Forms.Button();
            this.gn_Sidebar = new Guna.UI2.WinForms.Guna2Panel();
            this.pn_LichChieuPhim.SuspendLayout();
            this.gn_Backgr.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtv_CaChieu)).BeginInit();
            this.gn_Sidebar.SuspendLayout();
            this.SuspendLayout();
            // 
            // el_TestLichChieu
            // 
            this.el_TestLichChieu.BorderRadius = 20;
            this.el_TestLichChieu.TargetControl = this.pn_LichChieuPhim;
            // 
            // pn_LichChieuPhim
            // 
            this.pn_LichChieuPhim.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.pn_LichChieuPhim.Controls.Add(this.btnClose);
            this.pn_LichChieuPhim.Controls.Add(this.labelX);
            this.pn_LichChieuPhim.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn_LichChieuPhim.Location = new System.Drawing.Point(0, 0);
            this.pn_LichChieuPhim.Margin = new System.Windows.Forms.Padding(2);
            this.pn_LichChieuPhim.Name = "pn_LichChieuPhim";
            this.pn_LichChieuPhim.Size = new System.Drawing.Size(1035, 58);
            this.pn_LichChieuPhim.TabIndex = 6;
            // 
            // btnClose
            // 
            this.btnClose.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnClose.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnClose.ImageRotate = 0F;
            this.btnClose.ImageSize = new System.Drawing.Size(30, 30);
            this.btnClose.Location = new System.Drawing.Point(973, 0);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnClose.Name = "btnClose";
            this.btnClose.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnClose.Size = new System.Drawing.Size(62, 58);
            this.btnClose.TabIndex = 20;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // labelX
            // 
            this.labelX.AutoSize = true;
            this.labelX.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX.Location = new System.Drawing.Point(390, 15);
            this.labelX.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelX.Name = "labelX";
            this.labelX.Size = new System.Drawing.Size(261, 26);
            this.labelX.TabIndex = 0;
            this.labelX.Text = "LỊCH CHIẾU PHIM 🎥";
            // 
            // el_Backgr
            // 
            this.el_Backgr.BorderRadius = 20;
            this.el_Backgr.TargetControl = this.gn_Backgr;
            // 
            // gn_Backgr
            // 
            this.gn_Backgr.BackColor = System.Drawing.SystemColors.Control;
            this.gn_Backgr.BorderRadius = 20;
            this.gn_Backgr.Controls.Add(this.dtpThoiGian);
            this.gn_Backgr.Controls.Add(this.cboFilmName);
            this.gn_Backgr.Controls.Add(this.lbl_Phim);
            this.gn_Backgr.Controls.Add(this.lbl_Tgian);
            this.gn_Backgr.Location = new System.Drawing.Point(30, 37);
            this.gn_Backgr.Margin = new System.Windows.Forms.Padding(2);
            this.gn_Backgr.Name = "gn_Backgr";
            this.gn_Backgr.Size = new System.Drawing.Size(240, 194);
            this.gn_Backgr.TabIndex = 0;
            // 
            // dtpThoiGian
            // 
            this.dtpThoiGian.CalendarFont = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpThoiGian.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpThoiGian.Location = new System.Drawing.Point(22, 56);
            this.dtpThoiGian.Margin = new System.Windows.Forms.Padding(2);
            this.dtpThoiGian.Name = "dtpThoiGian";
            this.dtpThoiGian.Size = new System.Drawing.Size(198, 24);
            this.dtpThoiGian.TabIndex = 8;
            this.dtpThoiGian.Value = new System.DateTime(2025, 5, 1, 0, 0, 0, 0);
            this.dtpThoiGian.ValueChanged += new System.EventHandler(this.dtpThoiGian_ValueChanged);
            // 
            // cboFilmName
            // 
            this.cboFilmName.BackColor = System.Drawing.Color.Transparent;
            this.cboFilmName.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboFilmName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFilmName.FillColor = System.Drawing.SystemColors.ScrollBar;
            this.cboFilmName.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboFilmName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboFilmName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboFilmName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboFilmName.ItemHeight = 30;
            this.cboFilmName.Location = new System.Drawing.Point(22, 121);
            this.cboFilmName.Margin = new System.Windows.Forms.Padding(2);
            this.cboFilmName.Name = "cboFilmName";
            this.cboFilmName.Size = new System.Drawing.Size(198, 36);
            this.cboFilmName.TabIndex = 1;
            this.cboFilmName.SelectedIndexChanged += new System.EventHandler(this.cboFilmName_SelectedIndexChanged);
            // 
            // lbl_Phim
            // 
            this.lbl_Phim.AutoSize = true;
            this.lbl_Phim.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Phim.Location = new System.Drawing.Point(20, 97);
            this.lbl_Phim.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Phim.Name = "lbl_Phim";
            this.lbl_Phim.Size = new System.Drawing.Size(63, 19);
            this.lbl_Phim.TabIndex = 1;
            this.lbl_Phim.Text = "Phim 🎬";
            // 
            // lbl_Tgian
            // 
            this.lbl_Tgian.AutoSize = true;
            this.lbl_Tgian.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Tgian.Location = new System.Drawing.Point(20, 32);
            this.lbl_Tgian.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Tgian.Name = "lbl_Tgian";
            this.lbl_Tgian.Size = new System.Drawing.Size(70, 19);
            this.lbl_Tgian.TabIndex = 0;
            this.lbl_Tgian.Text = "Ngày 📅 ";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 30000;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtv_CaChieu);
            this.panel1.Location = new System.Drawing.Point(303, 58);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(732, 616);
            this.panel1.TabIndex = 8;
            // 
            // dtv_CaChieu
            // 
            this.dtv_CaChieu.AllowUserToAddRows = false;
            this.dtv_CaChieu.AllowUserToDeleteRows = false;
            this.dtv_CaChieu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtv_CaChieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtv_CaChieu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtv_CaChieu.Location = new System.Drawing.Point(0, 0);
            this.dtv_CaChieu.Margin = new System.Windows.Forms.Padding(2);
            this.dtv_CaChieu.Name = "dtv_CaChieu";
            this.dtv_CaChieu.ReadOnly = true;
            this.dtv_CaChieu.RowHeadersWidth = 62;
            this.dtv_CaChieu.RowTemplate.Height = 28;
            this.dtv_CaChieu.Size = new System.Drawing.Size(732, 616);
            this.dtv_CaChieu.TabIndex = 1;
            // 
            // btn_ChonVe
            // 
            this.btn_ChonVe.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ChonVe.Location = new System.Drawing.Point(166, 267);
            this.btn_ChonVe.Margin = new System.Windows.Forms.Padding(2);
            this.btn_ChonVe.Name = "btn_ChonVe";
            this.btn_ChonVe.Size = new System.Drawing.Size(104, 35);
            this.btn_ChonVe.TabIndex = 1;
            this.btn_ChonVe.Text = "CHỌN VÉ";
            this.btn_ChonVe.UseVisualStyleBackColor = true;
            this.btn_ChonVe.Click += new System.EventHandler(this.btn_ChonVe_Click);
            // 
            // gn_Sidebar
            // 
            this.gn_Sidebar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.gn_Sidebar.Controls.Add(this.btn_ChonVe);
            this.gn_Sidebar.Controls.Add(this.gn_Backgr);
            this.gn_Sidebar.Location = new System.Drawing.Point(0, 58);
            this.gn_Sidebar.Margin = new System.Windows.Forms.Padding(2);
            this.gn_Sidebar.Name = "gn_Sidebar";
            this.gn_Sidebar.Size = new System.Drawing.Size(304, 616);
            this.gn_Sidebar.TabIndex = 7;
            // 
            // frmStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 640);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gn_Sidebar);
            this.Controls.Add(this.pn_LichChieuPhim);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmStaff";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmStaff";
            this.pn_LichChieuPhim.ResumeLayout(false);
            this.pn_LichChieuPhim.PerformLayout();
            this.gn_Backgr.ResumeLayout(false);
            this.gn_Backgr.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtv_CaChieu)).EndInit();
            this.gn_Sidebar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse el_TestLichChieu;
        private Guna.UI2.WinForms.Guna2Panel pn_LichChieuPhim;
        private System.Windows.Forms.Label labelX;
        private Guna.UI2.WinForms.Guna2Elipse el_Backgr;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dtv_CaChieu;
        private Guna.UI2.WinForms.Guna2Panel gn_Backgr;
        private System.Windows.Forms.DateTimePicker dtpThoiGian;
        private Guna.UI2.WinForms.Guna2ComboBox cboFilmName;
        private System.Windows.Forms.Label lbl_Phim;
        private System.Windows.Forms.Label lbl_Tgian;
        private System.Windows.Forms.Button btn_ChonVe;
        private Guna.UI2.WinForms.Guna2Panel gn_Sidebar;
        private Guna.UI2.WinForms.Guna2ImageButton btnClose;
    }
}