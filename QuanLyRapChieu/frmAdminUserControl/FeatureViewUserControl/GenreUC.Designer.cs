namespace QuanLyRapChieu.frmAdminUserControl.FeatureViewUserControl
{
    partial class GenreUC
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnUpdateGenre = new Guna.UI2.WinForms.Guna2Button();
            this.btnDeleteGenre = new Guna.UI2.WinForms.Guna2Button();
            this.btnInsertGenre = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel4 = new Guna.UI2.WinForms.Guna2Panel();
            this.txtGenreName = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblGenreName = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.txtGenreID = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblGenreID = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Panel5 = new Guna.UI2.WinForms.Guna2Panel();
            this.dtgvGenre = new System.Windows.Forms.DataGridView();
            this.MaLoaiPhim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenTheLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.guna2Panel4.SuspendLayout();
            this.guna2Panel3.SuspendLayout();
            this.guna2Panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvGenre)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.White;
            this.guna2Panel1.Controls.Add(this.btnUpdateGenre);
            this.guna2Panel1.Controls.Add(this.btnDeleteGenre);
            this.guna2Panel1.Controls.Add(this.btnInsertGenre);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1000, 74);
            this.guna2Panel1.TabIndex = 0;
            // 
            // btnUpdateGenre
            // 
            this.btnUpdateGenre.AutoRoundedCorners = true;
            this.btnUpdateGenre.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btnUpdateGenre.BorderRadius = 16;
            this.btnUpdateGenre.BorderThickness = 2;
            this.btnUpdateGenre.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdateGenre.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdateGenre.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUpdateGenre.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUpdateGenre.FillColor = System.Drawing.Color.LightSteelBlue;
            this.btnUpdateGenre.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateGenre.ForeColor = System.Drawing.Color.Black;
            this.btnUpdateGenre.IndicateFocus = true;
            this.btnUpdateGenre.Location = new System.Drawing.Point(258, 17);
            this.btnUpdateGenre.Name = "btnUpdateGenre";
            this.btnUpdateGenre.Size = new System.Drawing.Size(83, 34);
            this.btnUpdateGenre.TabIndex = 2;
            this.btnUpdateGenre.Text = "Sửa";
            this.btnUpdateGenre.Click += new System.EventHandler(this.btnUpdateGenre_Click);
            // 
            // btnDeleteGenre
            // 
            this.btnDeleteGenre.AutoRoundedCorners = true;
            this.btnDeleteGenre.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btnDeleteGenre.BorderRadius = 16;
            this.btnDeleteGenre.BorderThickness = 2;
            this.btnDeleteGenre.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteGenre.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteGenre.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDeleteGenre.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDeleteGenre.FillColor = System.Drawing.Color.LightSteelBlue;
            this.btnDeleteGenre.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteGenre.ForeColor = System.Drawing.Color.Black;
            this.btnDeleteGenre.IndicateFocus = true;
            this.btnDeleteGenre.Location = new System.Drawing.Point(134, 17);
            this.btnDeleteGenre.Name = "btnDeleteGenre";
            this.btnDeleteGenre.Size = new System.Drawing.Size(83, 34);
            this.btnDeleteGenre.TabIndex = 1;
            this.btnDeleteGenre.Text = "Xóa";
            this.btnDeleteGenre.Click += new System.EventHandler(this.btnDeleteGenre_Click);
            // 
            // btnInsertGenre
            // 
            this.btnInsertGenre.AutoRoundedCorners = true;
            this.btnInsertGenre.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btnInsertGenre.BorderRadius = 16;
            this.btnInsertGenre.BorderThickness = 2;
            this.btnInsertGenre.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnInsertGenre.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnInsertGenre.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnInsertGenre.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnInsertGenre.FillColor = System.Drawing.Color.LightSteelBlue;
            this.btnInsertGenre.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertGenre.ForeColor = System.Drawing.Color.Black;
            this.btnInsertGenre.IndicateFocus = true;
            this.btnInsertGenre.Location = new System.Drawing.Point(15, 17);
            this.btnInsertGenre.Name = "btnInsertGenre";
            this.btnInsertGenre.Size = new System.Drawing.Size(83, 34);
            this.btnInsertGenre.TabIndex = 0;
            this.btnInsertGenre.Text = "Thêm";
            this.btnInsertGenre.Click += new System.EventHandler(this.btnInsertGenre_Click);
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.White;
            this.guna2Panel2.Controls.Add(this.guna2Panel4);
            this.guna2Panel2.Controls.Add(this.guna2Panel3);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.guna2Panel2.Location = new System.Drawing.Point(631, 74);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(369, 537);
            this.guna2Panel2.TabIndex = 1;
            // 
            // guna2Panel4
            // 
            this.guna2Panel4.Controls.Add(this.txtGenreName);
            this.guna2Panel4.Controls.Add(this.lblGenreName);
            this.guna2Panel4.Location = new System.Drawing.Point(0, 57);
            this.guna2Panel4.Name = "guna2Panel4";
            this.guna2Panel4.Size = new System.Drawing.Size(369, 51);
            this.guna2Panel4.TabIndex = 1;
            // 
            // txtGenreName
            // 
            this.txtGenreName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGenreName.DefaultText = "Enter Genre Name";
            this.txtGenreName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtGenreName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtGenreName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGenreName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGenreName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtGenreName.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGenreName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtGenreName.Location = new System.Drawing.Point(126, 11);
            this.txtGenreName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtGenreName.Name = "txtGenreName";
            this.txtGenreName.PlaceholderText = "";
            this.txtGenreName.SelectedText = "";
            this.txtGenreName.Size = new System.Drawing.Size(227, 28);
            this.txtGenreName.TabIndex = 3;
            // 
            // lblGenreName
            // 
            this.lblGenreName.BackColor = System.Drawing.Color.Transparent;
            this.lblGenreName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenreName.Location = new System.Drawing.Point(13, 18);
            this.lblGenreName.Name = "lblGenreName";
            this.lblGenreName.Size = new System.Drawing.Size(98, 21);
            this.lblGenreName.TabIndex = 2;
            this.lblGenreName.Text = "Tên Thể Loại:";
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.Controls.Add(this.txtGenreID);
            this.guna2Panel3.Controls.Add(this.lblGenreID);
            this.guna2Panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel3.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Size = new System.Drawing.Size(369, 51);
            this.guna2Panel3.TabIndex = 0;
            // 
            // txtGenreID
            // 
            this.txtGenreID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGenreID.DefaultText = "Enter Genre No";
            this.txtGenreID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtGenreID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtGenreID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGenreID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGenreID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtGenreID.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGenreID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtGenreID.Location = new System.Drawing.Point(125, 10);
            this.txtGenreID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtGenreID.Name = "txtGenreID";
            this.txtGenreID.PlaceholderText = "";
            this.txtGenreID.SelectedText = "";
            this.txtGenreID.Size = new System.Drawing.Size(228, 31);
            this.txtGenreID.TabIndex = 1;
            // 
            // lblGenreID
            // 
            this.lblGenreID.BackColor = System.Drawing.Color.Transparent;
            this.lblGenreID.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenreID.Location = new System.Drawing.Point(13, 17);
            this.lblGenreID.Name = "lblGenreID";
            this.lblGenreID.Size = new System.Drawing.Size(96, 21);
            this.lblGenreID.TabIndex = 0;
            this.lblGenreID.Text = "Mã Thể Loại:";
            // 
            // guna2Panel5
            // 
            this.guna2Panel5.Controls.Add(this.dtgvGenre);
            this.guna2Panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel5.Location = new System.Drawing.Point(0, 74);
            this.guna2Panel5.Name = "guna2Panel5";
            this.guna2Panel5.Size = new System.Drawing.Size(631, 537);
            this.guna2Panel5.TabIndex = 2;
            // 
            // dtgvGenre
            // 
            this.dtgvGenre.AllowUserToAddRows = false;
            this.dtgvGenre.AllowUserToDeleteRows = false;
            this.dtgvGenre.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvGenre.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvGenre.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dtgvGenre.ColumnHeadersHeight = 50;
            this.dtgvGenre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgvGenre.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaLoaiPhim,
            this.TenTheLoai});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvGenre.DefaultCellStyle = dataGridViewCellStyle5;
            this.dtgvGenre.Location = new System.Drawing.Point(0, 0);
            this.dtgvGenre.Name = "dtgvGenre";
            this.dtgvGenre.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvGenre.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dtgvGenre.RowHeadersWidth = 30;
            this.dtgvGenre.Size = new System.Drawing.Size(631, 547);
            this.dtgvGenre.TabIndex = 22;
            // 
            // MaLoaiPhim
            // 
            this.MaLoaiPhim.DataPropertyName = "MaLoaiPhim";
            this.MaLoaiPhim.HeaderText = "Mã Loại Phim";
            this.MaLoaiPhim.MinimumWidth = 8;
            this.MaLoaiPhim.Name = "MaLoaiPhim";
            this.MaLoaiPhim.ReadOnly = true;
            // 
            // TenTheLoai
            // 
            this.TenTheLoai.DataPropertyName = "TenTheLoai";
            this.TenTheLoai.HeaderText = "Tên Thể Loại";
            this.TenTheLoai.MinimumWidth = 8;
            this.TenTheLoai.Name = "TenTheLoai";
            this.TenTheLoai.ReadOnly = true;
            // 
            // GenreUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Controls.Add(this.guna2Panel5);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel1);
            this.Name = "GenreUC";
            this.Size = new System.Drawing.Size(1000, 611);
            this.Load += new System.EventHandler(this.GenreUC_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel4.ResumeLayout(false);
            this.guna2Panel4.PerformLayout();
            this.guna2Panel3.ResumeLayout(false);
            this.guna2Panel3.PerformLayout();
            this.guna2Panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvGenre)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button btnInsertGenre;
        private Guna.UI2.WinForms.Guna2Button btnUpdateGenre;
        private Guna.UI2.WinForms.Guna2Button btnDeleteGenre;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private Guna.UI2.WinForms.Guna2TextBox txtGenreID;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblGenreID;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel4;
        private Guna.UI2.WinForms.Guna2TextBox txtGenreName;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblGenreName;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel5;
        private System.Windows.Forms.DataGridView dtgvGenre;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLoaiPhim;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenTheLoai;
    }
}
