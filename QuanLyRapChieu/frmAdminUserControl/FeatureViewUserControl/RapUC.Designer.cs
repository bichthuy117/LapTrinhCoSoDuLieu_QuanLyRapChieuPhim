namespace QuanLyRapChieu.frmAdminUserControl.FeatureViewUserControl
{
    partial class RapUC
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel38 = new System.Windows.Forms.Panel();
            this.txtTenRap = new System.Windows.Forms.TextBox();
            this.lblGenreName = new System.Windows.Forms.Label();
            this.panel39 = new System.Windows.Forms.Panel();
            this.txtMaRap = new System.Windows.Forms.TextBox();
            this.lblGenreID = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel40 = new System.Windows.Forms.Panel();
            this.btnUpdateRap = new Guna.UI2.WinForms.Guna2Button();
            this.btnDeleteRap = new Guna.UI2.WinForms.Guna2Button();
            this.btnInsertRap = new Guna.UI2.WinForms.Guna2Button();
            this.dtgvRap = new System.Windows.Forms.DataGridView();
            this.MaRap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenRap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            this.panel38.SuspendLayout();
            this.panel39.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel40.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvRap)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel38);
            this.panel2.Controls.Add(this.panel39);
            this.panel2.Location = new System.Drawing.Point(856, 105);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(632, 835);
            this.panel2.TabIndex = 25;
            // 
            // panel38
            // 
            this.panel38.Controls.Add(this.txtTenRap);
            this.panel38.Controls.Add(this.lblGenreName);
            this.panel38.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel38.Location = new System.Drawing.Point(14, 83);
            this.panel38.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel38.Name = "panel38";
            this.panel38.Size = new System.Drawing.Size(592, 68);
            this.panel38.TabIndex = 4;
            // 
            // txtTenRap
            // 
            this.txtTenRap.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenRap.Location = new System.Drawing.Point(165, 15);
            this.txtTenRap.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTenRap.Name = "txtTenRap";
            this.txtTenRap.Size = new System.Drawing.Size(370, 35);
            this.txtTenRap.TabIndex = 1;
            // 
            // lblGenreName
            // 
            this.lblGenreName.AutoSize = true;
            this.lblGenreName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblGenreName.Location = new System.Drawing.Point(4, 20);
            this.lblGenreName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGenreName.Name = "lblGenreName";
            this.lblGenreName.Size = new System.Drawing.Size(107, 26);
            this.lblGenreName.TabIndex = 0;
            this.lblGenreName.Text = "Tên rạp :";
            // 
            // panel39
            // 
            this.panel39.Controls.Add(this.txtMaRap);
            this.panel39.Controls.Add(this.lblGenreID);
            this.panel39.Location = new System.Drawing.Point(14, 5);
            this.panel39.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel39.Name = "panel39";
            this.panel39.Size = new System.Drawing.Size(592, 68);
            this.panel39.TabIndex = 3;
            // 
            // txtMaRap
            // 
            this.txtMaRap.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaRap.Location = new System.Drawing.Point(165, 15);
            this.txtMaRap.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMaRap.Name = "txtMaRap";
            this.txtMaRap.Size = new System.Drawing.Size(370, 35);
            this.txtMaRap.TabIndex = 1;
            // 
            // lblGenreID
            // 
            this.lblGenreID.AutoSize = true;
            this.lblGenreID.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblGenreID.Location = new System.Drawing.Point(4, 18);
            this.lblGenreID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGenreID.Name = "lblGenreID";
            this.lblGenreID.Size = new System.Drawing.Size(103, 26);
            this.lblGenreID.TabIndex = 0;
            this.lblGenreID.Text = "Mã rạp :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel40);
            this.panel1.Controls.Add(this.dtgvRap);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1491, 940);
            this.panel1.TabIndex = 16;
            // 
            // panel40
            // 
            this.panel40.BackColor = System.Drawing.Color.White;
            this.panel40.Controls.Add(this.btnUpdateRap);
            this.panel40.Controls.Add(this.btnDeleteRap);
            this.panel40.Controls.Add(this.btnInsertRap);
            this.panel40.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel40.Location = new System.Drawing.Point(0, 0);
            this.panel40.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel40.Name = "panel40";
            this.panel40.Size = new System.Drawing.Size(1491, 82);
            this.panel40.TabIndex = 26;
            // 
            // btnUpdateRap
            // 
            this.btnUpdateRap.AutoRoundedCorners = true;
            this.btnUpdateRap.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btnUpdateRap.BorderRadius = 25;
            this.btnUpdateRap.BorderThickness = 2;
            this.btnUpdateRap.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdateRap.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdateRap.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUpdateRap.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUpdateRap.FillColor = System.Drawing.Color.LightSteelBlue;
            this.btnUpdateRap.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateRap.ForeColor = System.Drawing.Color.Black;
            this.btnUpdateRap.IndicateFocus = true;
            this.btnUpdateRap.Location = new System.Drawing.Point(374, 18);
            this.btnUpdateRap.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUpdateRap.Name = "btnUpdateRap";
            this.btnUpdateRap.Size = new System.Drawing.Size(124, 52);
            this.btnUpdateRap.TabIndex = 42;
            this.btnUpdateRap.Text = "Sửa";
            this.btnUpdateRap.Click += new System.EventHandler(this.btnUpdateRap_Click);
            // 
            // btnDeleteRap
            // 
            this.btnDeleteRap.AutoRoundedCorners = true;
            this.btnDeleteRap.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btnDeleteRap.BorderRadius = 25;
            this.btnDeleteRap.BorderThickness = 2;
            this.btnDeleteRap.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteRap.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteRap.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDeleteRap.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDeleteRap.FillColor = System.Drawing.Color.LightSteelBlue;
            this.btnDeleteRap.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.btnDeleteRap.ForeColor = System.Drawing.Color.Black;
            this.btnDeleteRap.IndicateFocus = true;
            this.btnDeleteRap.Location = new System.Drawing.Point(194, 18);
            this.btnDeleteRap.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDeleteRap.Name = "btnDeleteRap";
            this.btnDeleteRap.Size = new System.Drawing.Size(124, 52);
            this.btnDeleteRap.TabIndex = 41;
            this.btnDeleteRap.Text = "Xóa";
            this.btnDeleteRap.Click += new System.EventHandler(this.btnDeleteRap_Click);
            // 
            // btnInsertRap
            // 
            this.btnInsertRap.AutoRoundedCorners = true;
            this.btnInsertRap.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btnInsertRap.BorderRadius = 25;
            this.btnInsertRap.BorderThickness = 2;
            this.btnInsertRap.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnInsertRap.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnInsertRap.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnInsertRap.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnInsertRap.FillColor = System.Drawing.Color.LightSteelBlue;
            this.btnInsertRap.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertRap.ForeColor = System.Drawing.Color.Black;
            this.btnInsertRap.IndicateFocus = true;
            this.btnInsertRap.Location = new System.Drawing.Point(20, 18);
            this.btnInsertRap.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnInsertRap.Name = "btnInsertRap";
            this.btnInsertRap.Size = new System.Drawing.Size(124, 52);
            this.btnInsertRap.TabIndex = 40;
            this.btnInsertRap.Text = "Thêm";
            this.btnInsertRap.Click += new System.EventHandler(this.btnInsertRap_Click);
            // 
            // dtgvRap
            // 
            this.dtgvRap.AllowUserToAddRows = false;
            this.dtgvRap.AllowUserToDeleteRows = false;
            this.dtgvRap.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtgvRap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvRap.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvRap.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvRap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvRap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaRap,
            this.TenRap});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvRap.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvRap.Location = new System.Drawing.Point(0, 92);
            this.dtgvRap.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtgvRap.Name = "dtgvRap";
            this.dtgvRap.ReadOnly = true;
            this.dtgvRap.RowHeadersWidth = 51;
            this.dtgvRap.Size = new System.Drawing.Size(849, 848);
            this.dtgvRap.TabIndex = 1;
            this.dtgvRap.Click += new System.EventHandler(this.RapUC_Load);
            // 
            // MaRap
            // 
            this.MaRap.DataPropertyName = "MaRap";
            this.MaRap.HeaderText = "Mã Rạp";
            this.MaRap.MinimumWidth = 8;
            this.MaRap.Name = "MaRap";
            this.MaRap.ReadOnly = true;
            // 
            // TenRap
            // 
            this.TenRap.DataPropertyName = "TenRap";
            this.TenRap.HeaderText = "Tên Rạp";
            this.TenRap.MinimumWidth = 8;
            this.TenRap.Name = "TenRap";
            this.TenRap.ReadOnly = true;
            // 
            // RapUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Controls.Add(this.panel1);
            this.Name = "RapUC";
            this.Size = new System.Drawing.Size(1491, 940);
            this.panel2.ResumeLayout(false);
            this.panel38.ResumeLayout(false);
            this.panel38.PerformLayout();
            this.panel39.ResumeLayout(false);
            this.panel39.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel40.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvRap)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel38;
        private System.Windows.Forms.TextBox txtTenRap;
        private System.Windows.Forms.Label lblGenreName;
        private System.Windows.Forms.Panel panel39;
        private System.Windows.Forms.TextBox txtMaRap;
        private System.Windows.Forms.Label lblGenreID;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel40;
        private System.Windows.Forms.DataGridView dtgvRap;
        private Guna.UI2.WinForms.Guna2Button btnUpdateRap;
        private Guna.UI2.WinForms.Guna2Button btnDeleteRap;
        private Guna.UI2.WinForms.Guna2Button btnInsertRap;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaRap;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenRap;
    }
}