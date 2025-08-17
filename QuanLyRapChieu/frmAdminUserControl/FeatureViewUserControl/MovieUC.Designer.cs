namespace QuanLyRapChieu.frmAdminUserControl.FeatureViewUserControl
{
    partial class MovieUC
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel47 = new System.Windows.Forms.Panel();
            this.UpdateMovie = new Guna.UI2.WinForms.Guna2Button();
            this.btnDeleteMovie = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddMovie = new Guna.UI2.WinForms.Guna2Button();
            this.numericUpDownPhim = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.dtmMovieEnd = new System.Windows.Forms.DateTimePicker();
            this.dtmMovieStart = new System.Windows.Forms.DateTimePicker();
            this.txtMovieYearLimit = new System.Windows.Forms.TextBox();
            this.txtMovieActor = new System.Windows.Forms.TextBox();
            this.txtMovieCountry = new System.Windows.Forms.TextBox();
            this.txtMovieLength = new System.Windows.Forms.TextBox();
            this.lblMovieEndDate = new System.Windows.Forms.Label();
            this.lblMovieStartDate = new System.Windows.Forms.Label();
            this.lblMovieLength = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lblMovieYearLimit = new System.Windows.Forms.Label();
            this.lblMovieCountry = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dtgvMovie = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.clbMovieGenre = new System.Windows.Forms.CheckedListBox();
            this.txtMovieDesc = new System.Windows.Forms.TextBox();
            this.lblMovieGenre = new System.Windows.Forms.Label();
            this.lblMovieDesc = new System.Windows.Forms.Label();
            this.txtMovieName = new System.Windows.Forms.TextBox();
            this.lblMovieName = new System.Windows.Forms.Label();
            this.txtMovieID = new System.Windows.Forms.TextBox();
            this.lblMovieID = new System.Windows.Forms.Label();
            this.lblMovieActor = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel47.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPhim)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvMovie)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel47
            // 
            this.panel47.BackColor = System.Drawing.Color.White;
            this.panel47.Controls.Add(this.UpdateMovie);
            this.panel47.Controls.Add(this.btnDeleteMovie);
            this.panel47.Controls.Add(this.btnAddMovie);
            this.panel47.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel47.Location = new System.Drawing.Point(0, 224);
            this.panel47.Name = "panel47";
            this.panel47.Size = new System.Drawing.Size(994, 46);
            this.panel47.TabIndex = 10;
            // 
            // UpdateMovie
            // 
            this.UpdateMovie.AutoRoundedCorners = true;
            this.UpdateMovie.BorderColor = System.Drawing.Color.MidnightBlue;
            this.UpdateMovie.BorderRadius = 16;
            this.UpdateMovie.BorderThickness = 2;
            this.UpdateMovie.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.UpdateMovie.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.UpdateMovie.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.UpdateMovie.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.UpdateMovie.FillColor = System.Drawing.Color.LightSteelBlue;
            this.UpdateMovie.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.UpdateMovie.ForeColor = System.Drawing.Color.Black;
            this.UpdateMovie.IndicateFocus = true;
            this.UpdateMovie.Location = new System.Drawing.Point(223, 8);
            this.UpdateMovie.Name = "UpdateMovie";
            this.UpdateMovie.Size = new System.Drawing.Size(83, 34);
            this.UpdateMovie.TabIndex = 39;
            this.UpdateMovie.Text = "Sửa";
            this.UpdateMovie.Click += new System.EventHandler(this.btnUpdateMovie_Click);
            // 
            // btnDeleteMovie
            // 
            this.btnDeleteMovie.AutoRoundedCorners = true;
            this.btnDeleteMovie.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btnDeleteMovie.BorderRadius = 16;
            this.btnDeleteMovie.BorderThickness = 2;
            this.btnDeleteMovie.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteMovie.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteMovie.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDeleteMovie.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDeleteMovie.FillColor = System.Drawing.Color.LightSteelBlue;
            this.btnDeleteMovie.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteMovie.ForeColor = System.Drawing.Color.Black;
            this.btnDeleteMovie.IndicateFocus = true;
            this.btnDeleteMovie.Location = new System.Drawing.Point(117, 8);
            this.btnDeleteMovie.Name = "btnDeleteMovie";
            this.btnDeleteMovie.Size = new System.Drawing.Size(83, 34);
            this.btnDeleteMovie.TabIndex = 38;
            this.btnDeleteMovie.Text = "Xóa";
            this.btnDeleteMovie.Click += new System.EventHandler(this.btnDeleteMovie_Click);
            // 
            // btnAddMovie
            // 
            this.btnAddMovie.AutoRoundedCorners = true;
            this.btnAddMovie.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btnAddMovie.BorderRadius = 16;
            this.btnAddMovie.BorderThickness = 2;
            this.btnAddMovie.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddMovie.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddMovie.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddMovie.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddMovie.FillColor = System.Drawing.Color.LightSteelBlue;
            this.btnAddMovie.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddMovie.ForeColor = System.Drawing.Color.Black;
            this.btnAddMovie.IndicateFocus = true;
            this.btnAddMovie.Location = new System.Drawing.Point(9, 8);
            this.btnAddMovie.Name = "btnAddMovie";
            this.btnAddMovie.Size = new System.Drawing.Size(83, 34);
            this.btnAddMovie.TabIndex = 37;
            this.btnAddMovie.Text = "Thêm";
            this.btnAddMovie.Click += new System.EventHandler(this.btnAddMovie_Click);
            // 
            // numericUpDownPhim
            // 
            this.numericUpDownPhim.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownPhim.Location = new System.Drawing.Point(692, 159);
            this.numericUpDownPhim.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDownPhim.Maximum = new decimal(new int[] {
            2022,
            0,
            0,
            0});
            this.numericUpDownPhim.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.numericUpDownPhim.Name = "numericUpDownPhim";
            this.numericUpDownPhim.Size = new System.Drawing.Size(184, 26);
            this.numericUpDownPhim.TabIndex = 3;
            this.numericUpDownPhim.Value = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(563, 164);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 19);
            this.label1.TabIndex = 57;
            this.label1.Text = "Năm SX:";
            // 
            // dtmMovieEnd
            // 
            this.dtmMovieEnd.CalendarFont = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtmMovieEnd.CustomFormat = "yyyy/MM/dd";
            this.dtmMovieEnd.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtmMovieEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtmMovieEnd.Location = new System.Drawing.Point(692, 65);
            this.dtmMovieEnd.Margin = new System.Windows.Forms.Padding(2);
            this.dtmMovieEnd.Name = "dtmMovieEnd";
            this.dtmMovieEnd.Size = new System.Drawing.Size(185, 26);
            this.dtmMovieEnd.TabIndex = 53;
            // 
            // dtmMovieStart
            // 
            this.dtmMovieStart.CalendarFont = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtmMovieStart.CustomFormat = "yyyy/MM/dd";
            this.dtmMovieStart.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtmMovieStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtmMovieStart.Location = new System.Drawing.Point(692, 37);
            this.dtmMovieStart.Margin = new System.Windows.Forms.Padding(2);
            this.dtmMovieStart.Name = "dtmMovieStart";
            this.dtmMovieStart.Size = new System.Drawing.Size(185, 26);
            this.dtmMovieStart.TabIndex = 52;
            // 
            // txtMovieYearLimit
            // 
            this.txtMovieYearLimit.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMovieYearLimit.Location = new System.Drawing.Point(692, 190);
            this.txtMovieYearLimit.Margin = new System.Windows.Forms.Padding(2);
            this.txtMovieYearLimit.Name = "txtMovieYearLimit";
            this.txtMovieYearLimit.Size = new System.Drawing.Size(185, 26);
            this.txtMovieYearLimit.TabIndex = 50;
            // 
            // txtMovieActor
            // 
            this.txtMovieActor.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMovieActor.Location = new System.Drawing.Point(692, 128);
            this.txtMovieActor.Margin = new System.Windows.Forms.Padding(2);
            this.txtMovieActor.Name = "txtMovieActor";
            this.txtMovieActor.Size = new System.Drawing.Size(185, 26);
            this.txtMovieActor.TabIndex = 49;
            // 
            // txtMovieCountry
            // 
            this.txtMovieCountry.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMovieCountry.Location = new System.Drawing.Point(692, 99);
            this.txtMovieCountry.Margin = new System.Windows.Forms.Padding(2);
            this.txtMovieCountry.Name = "txtMovieCountry";
            this.txtMovieCountry.Size = new System.Drawing.Size(185, 26);
            this.txtMovieCountry.TabIndex = 48;
            // 
            // txtMovieLength
            // 
            this.txtMovieLength.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMovieLength.Location = new System.Drawing.Point(692, 8);
            this.txtMovieLength.Margin = new System.Windows.Forms.Padding(2);
            this.txtMovieLength.Name = "txtMovieLength";
            this.txtMovieLength.Size = new System.Drawing.Size(185, 26);
            this.txtMovieLength.TabIndex = 47;
            // 
            // lblMovieEndDate
            // 
            this.lblMovieEndDate.AutoSize = true;
            this.lblMovieEndDate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMovieEndDate.Location = new System.Drawing.Point(563, 70);
            this.lblMovieEndDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMovieEndDate.Name = "lblMovieEndDate";
            this.lblMovieEndDate.Size = new System.Drawing.Size(75, 19);
            this.lblMovieEndDate.TabIndex = 44;
            this.lblMovieEndDate.Text = "Ngày KT:";
            // 
            // lblMovieStartDate
            // 
            this.lblMovieStartDate.AutoSize = true;
            this.lblMovieStartDate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMovieStartDate.Location = new System.Drawing.Point(563, 43);
            this.lblMovieStartDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMovieStartDate.Name = "lblMovieStartDate";
            this.lblMovieStartDate.Size = new System.Drawing.Size(77, 19);
            this.lblMovieStartDate.TabIndex = 42;
            this.lblMovieStartDate.Text = "Ngày KC:";
            // 
            // lblMovieLength
            // 
            this.lblMovieLength.AutoSize = true;
            this.lblMovieLength.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMovieLength.Location = new System.Drawing.Point(563, 14);
            this.lblMovieLength.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMovieLength.Name = "lblMovieLength";
            this.lblMovieLength.Size = new System.Drawing.Size(88, 19);
            this.lblMovieLength.TabIndex = 35;
            this.lblMovieLength.Text = "Thời lượng:";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // lblMovieYearLimit
            // 
            this.lblMovieYearLimit.AutoSize = true;
            this.lblMovieYearLimit.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMovieYearLimit.Location = new System.Drawing.Point(563, 194);
            this.lblMovieYearLimit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMovieYearLimit.Name = "lblMovieYearLimit";
            this.lblMovieYearLimit.Size = new System.Drawing.Size(108, 19);
            this.lblMovieYearLimit.TabIndex = 41;
            this.lblMovieYearLimit.Text = "Giới Hạn Tuổi:";
            // 
            // lblMovieCountry
            // 
            this.lblMovieCountry.AutoSize = true;
            this.lblMovieCountry.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMovieCountry.Location = new System.Drawing.Point(563, 103);
            this.lblMovieCountry.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMovieCountry.Name = "lblMovieCountry";
            this.lblMovieCountry.Size = new System.Drawing.Size(77, 19);
            this.lblMovieCountry.TabIndex = 38;
            this.lblMovieCountry.Text = "Quốc Gia:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel47);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(994, 611);
            this.panel1.TabIndex = 13;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dtgvMovie);
            this.panel3.Location = new System.Drawing.Point(0, 270);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1009, 341);
            this.panel3.TabIndex = 11;
            // 
            // dtgvMovie
            // 
            this.dtgvMovie.AllowUserToAddRows = false;
            this.dtgvMovie.AllowUserToDeleteRows = false;
            this.dtgvMovie.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvMovie.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvMovie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvMovie.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvMovie.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvMovie.Location = new System.Drawing.Point(9, 0);
            this.dtgvMovie.Name = "dtgvMovie";
            this.dtgvMovie.ReadOnly = true;
            this.dtgvMovie.RowHeadersWidth = 51;
            this.dtgvMovie.Size = new System.Drawing.Size(982, 341);
            this.dtgvMovie.TabIndex = 2;
            this.dtgvMovie.Click += new System.EventHandler(this.MovieUC_Load);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.clbMovieGenre);
            this.panel2.Controls.Add(this.numericUpDownPhim);
            this.panel2.Controls.Add(this.txtMovieDesc);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.lblMovieGenre);
            this.panel2.Controls.Add(this.lblMovieDesc);
            this.panel2.Controls.Add(this.txtMovieYearLimit);
            this.panel2.Controls.Add(this.txtMovieName);
            this.panel2.Controls.Add(this.lblMovieYearLimit);
            this.panel2.Controls.Add(this.lblMovieName);
            this.panel2.Controls.Add(this.lblMovieCountry);
            this.panel2.Controls.Add(this.txtMovieID);
            this.panel2.Controls.Add(this.dtmMovieEnd);
            this.panel2.Controls.Add(this.lblMovieID);
            this.panel2.Controls.Add(this.lblMovieActor);
            this.panel2.Controls.Add(this.txtMovieLength);
            this.panel2.Controls.Add(this.dtmMovieStart);
            this.panel2.Controls.Add(this.lblMovieEndDate);
            this.panel2.Controls.Add(this.lblMovieLength);
            this.panel2.Controls.Add(this.txtMovieCountry);
            this.panel2.Controls.Add(this.txtMovieActor);
            this.panel2.Controls.Add(this.lblMovieStartDate);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(994, 224);
            this.panel2.TabIndex = 0;
            // 
            // clbMovieGenre
            // 
            this.clbMovieGenre.CheckOnClick = true;
            this.clbMovieGenre.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clbMovieGenre.FormattingEnabled = true;
            this.clbMovieGenre.Location = new System.Drawing.Point(33, 128);
            this.clbMovieGenre.Margin = new System.Windows.Forms.Padding(2);
            this.clbMovieGenre.MultiColumn = true;
            this.clbMovieGenre.Name = "clbMovieGenre";
            this.clbMovieGenre.Size = new System.Drawing.Size(244, 84);
            this.clbMovieGenre.TabIndex = 58;
            this.clbMovieGenre.SelectedIndexChanged += new System.EventHandler(this.clbMovieGenre_SelectedIndexChanged);
            // 
            // txtMovieDesc
            // 
            this.txtMovieDesc.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMovieDesc.Location = new System.Drawing.Point(125, 70);
            this.txtMovieDesc.Margin = new System.Windows.Forms.Padding(2);
            this.txtMovieDesc.Multiline = true;
            this.txtMovieDesc.Name = "txtMovieDesc";
            this.txtMovieDesc.Size = new System.Drawing.Size(152, 25);
            this.txtMovieDesc.TabIndex = 46;
            // 
            // lblMovieGenre
            // 
            this.lblMovieGenre.AutoSize = true;
            this.lblMovieGenre.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMovieGenre.Location = new System.Drawing.Point(30, 100);
            this.lblMovieGenre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMovieGenre.Name = "lblMovieGenre";
            this.lblMovieGenre.Size = new System.Drawing.Size(68, 19);
            this.lblMovieGenre.TabIndex = 40;
            this.lblMovieGenre.Text = "Thể loại:";
            // 
            // lblMovieDesc
            // 
            this.lblMovieDesc.AutoSize = true;
            this.lblMovieDesc.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMovieDesc.Location = new System.Drawing.Point(30, 75);
            this.lblMovieDesc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMovieDesc.Name = "lblMovieDesc";
            this.lblMovieDesc.Size = new System.Drawing.Size(55, 19);
            this.lblMovieDesc.TabIndex = 37;
            this.lblMovieDesc.Text = "Mô tả:";
            // 
            // txtMovieName
            // 
            this.txtMovieName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMovieName.Location = new System.Drawing.Point(125, 41);
            this.txtMovieName.Margin = new System.Windows.Forms.Padding(2);
            this.txtMovieName.Name = "txtMovieName";
            this.txtMovieName.Size = new System.Drawing.Size(152, 26);
            this.txtMovieName.TabIndex = 51;
            // 
            // lblMovieName
            // 
            this.lblMovieName.AutoSize = true;
            this.lblMovieName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMovieName.Location = new System.Drawing.Point(30, 46);
            this.lblMovieName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMovieName.Name = "lblMovieName";
            this.lblMovieName.Size = new System.Drawing.Size(76, 19);
            this.lblMovieName.TabIndex = 36;
            this.lblMovieName.Text = "Tên phim:";
            // 
            // txtMovieID
            // 
            this.txtMovieID.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMovieID.Location = new System.Drawing.Point(125, 10);
            this.txtMovieID.Margin = new System.Windows.Forms.Padding(2);
            this.txtMovieID.Name = "txtMovieID";
            this.txtMovieID.Size = new System.Drawing.Size(152, 26);
            this.txtMovieID.TabIndex = 45;
            this.txtMovieID.Click += new System.EventHandler(this.txtMovieID_TextChanged);
            // 
            // lblMovieID
            // 
            this.lblMovieID.AutoSize = true;
            this.lblMovieID.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMovieID.Location = new System.Drawing.Point(30, 14);
            this.lblMovieID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMovieID.Name = "lblMovieID";
            this.lblMovieID.Size = new System.Drawing.Size(74, 19);
            this.lblMovieID.TabIndex = 43;
            this.lblMovieID.Text = "Mã phim:";
            // 
            // lblMovieActor
            // 
            this.lblMovieActor.AutoSize = true;
            this.lblMovieActor.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMovieActor.Location = new System.Drawing.Point(563, 134);
            this.lblMovieActor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMovieActor.Name = "lblMovieActor";
            this.lblMovieActor.Size = new System.Drawing.Size(78, 19);
            this.lblMovieActor.TabIndex = 39;
            this.lblMovieActor.Text = "Đạo Diễn:";
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MaPhim";
            this.Column1.FillWeight = 39.66636F;
            this.Column1.HeaderText = "Mã Phim";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TenPhim";
            this.Column2.FillWeight = 59.55287F;
            this.Column2.HeaderText = "Tên Phim";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "MoTa";
            this.Column3.FillWeight = 18.80793F;
            this.Column3.HeaderText = "Mô Tả";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "ThoiLuong";
            this.Column4.FillWeight = 39.00525F;
            this.Column4.HeaderText = "Thời Lượng";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "NgayKhoiChieu";
            this.Column5.FillWeight = 39.00525F;
            this.Column5.HeaderText = "Ngày Khởi Chiếu";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "NgayKetThuc";
            this.Column6.FillWeight = 39.00525F;
            this.Column6.HeaderText = "Ngày Kết Thúc";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "QuocGia";
            this.Column7.FillWeight = 39.00525F;
            this.Column7.HeaderText = "Quốc Gia";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "DaoDien";
            this.Column8.FillWeight = 39.00525F;
            this.Column8.HeaderText = "Đạo Diễn";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "GioiHanTuoi";
            this.Column9.FillWeight = 39.00525F;
            this.Column9.HeaderText = "Giới Hạn Tuổi";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "NamSX";
            this.Column10.FillWeight = 39.00525F;
            this.Column10.HeaderText = "Năm SX";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            // 
            // MovieUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MovieUC";
            this.Size = new System.Drawing.Size(994, 611);
            this.panel47.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPhim)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvMovie)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel47;
        private System.Windows.Forms.NumericUpDown numericUpDownPhim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtmMovieEnd;
        private System.Windows.Forms.DateTimePicker dtmMovieStart;
        private System.Windows.Forms.TextBox txtMovieYearLimit;
        private System.Windows.Forms.TextBox txtMovieActor;
        private System.Windows.Forms.TextBox txtMovieCountry;
        private System.Windows.Forms.TextBox txtMovieLength;
        private System.Windows.Forms.Label lblMovieEndDate;
        private System.Windows.Forms.Label lblMovieStartDate;
        private System.Windows.Forms.Label lblMovieLength;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label lblMovieYearLimit;
        private System.Windows.Forms.Label lblMovieCountry;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblMovieActor;
        private Guna.UI2.WinForms.Guna2Button UpdateMovie;
        private Guna.UI2.WinForms.Guna2Button btnDeleteMovie;
        private Guna.UI2.WinForms.Guna2Button btnAddMovie;
        private System.Windows.Forms.TextBox txtMovieDesc;
        private System.Windows.Forms.Label lblMovieGenre;
        private System.Windows.Forms.Label lblMovieDesc;
        private System.Windows.Forms.TextBox txtMovieName;
        private System.Windows.Forms.Label lblMovieName;
        private System.Windows.Forms.TextBox txtMovieID;
        private System.Windows.Forms.Label lblMovieID;
        private System.Windows.Forms.CheckedListBox clbMovieGenre;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dtgvMovie;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
    }
}
