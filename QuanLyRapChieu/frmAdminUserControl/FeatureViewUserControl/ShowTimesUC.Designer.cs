using System;
using System.Windows.Forms;

namespace QuanLyRapChieu.frmAdminUserControl.FeatureViewUserControl
{
    partial class ShowTimesUC
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolTipCinema = new System.Windows.Forms.ToolTip(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dtgvShowtime = new System.Windows.Forms.DataGridView();
            this.MaCaChieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaRap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenPhim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThoiGianChieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThoiGianKetThuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaVe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.txtMovieName_Showtime = new System.Windows.Forms.TextBox();
            this.cboMovieName_Showtime = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimetimes = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimeDay = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtmShowtimeTime = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.dtmShowtimeDate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.cboRap = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cboCinemaID_Showtime = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTicketPrice_Showtime = new System.Windows.Forms.TextBox();
            this.txtShowtimeID = new System.Windows.Forms.TextBox();
            this.btnUpdateShowtime = new Guna.UI2.WinForms.Guna2Button();
            this.btnDeleteShowtime = new Guna.UI2.WinForms.Guna2Button();
            this.btnInsertShowtime = new Guna.UI2.WinForms.Guna2Button();
            this.panel54 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvShowtime)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel54.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolTipCinema
            // 
            this.toolTipCinema.AutoPopDelay = 5000;
            this.toolTipCinema.InitialDelay = 100;
            this.toolTipCinema.ReshowDelay = 100;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);

            this.panel1.Location = new System.Drawing.Point(0, 91);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1500, 709);

            this.panel1.TabIndex = 13;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dtgvShowtime);

            this.panel3.Location = new System.Drawing.Point(27, 18);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(970, 652);

            this.panel3.TabIndex = 6;
            // 
            // dtgvShowtime
            // 
            this.dtgvShowtime.AllowUserToAddRows = false;
            this.dtgvShowtime.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dtgvShowtime.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvShowtime.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgvShowtime.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.GhostWhite;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvShowtime.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvShowtime.ColumnHeadersHeight = 40;
            this.dtgvShowtime.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaCaChieu,
            this.MaPhong,
            this.MaRap,
            this.TenPhim,
            this.ThoiGianChieu,
            this.ThoiGianKetThuc,
            this.GiaVe});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvShowtime.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtgvShowtime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvShowtime.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgvShowtime.Location = new System.Drawing.Point(0, 0);
            this.dtgvShowtime.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtgvShowtime.Name = "dtgvShowtime";
            this.dtgvShowtime.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvShowtime.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dtgvShowtime.RowHeadersWidth = 51;
            this.dtgvShowtime.RowTemplate.Height = 40;
            this.dtgvShowtime.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;

            this.dtgvShowtime.Size = new System.Drawing.Size(647, 424);
            this.dtgvShowtime.TabIndex = 1;
            this.dtgvShowtime.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvShowtime_CellContentClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.txtMovieName_Showtime);
            this.panel2.Controls.Add(this.cboMovieName_Showtime);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.cboRap);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.cboCinemaID_Showtime);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txtTicketPrice_Showtime);
            this.panel2.Controls.Add(this.txtShowtimeID);
            this.panel2.ForeColor = System.Drawing.Color.LightSlateGray;
            this.panel2.Location = new System.Drawing.Point(670, 11);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(316, 425);
            this.panel2.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 70);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 19);
            this.label9.TabIndex = 32;
            this.label9.Text = "Mã phim";
            // 
            // txtMovieName_Showtime
            // 
            this.txtMovieName_Showtime.Location = new System.Drawing.Point(125, 102);
            this.txtMovieName_Showtime.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMovieName_Showtime.Name = "txtMovieName_Showtime";
            this.txtMovieName_Showtime.ReadOnly = true;
            this.txtMovieName_Showtime.Size = new System.Drawing.Size(163, 20);
            this.txtMovieName_Showtime.TabIndex = 31;
            // 
            // cboMovieName_Showtime
            // 
            this.cboMovieName_Showtime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMovieName_Showtime.FormattingEnabled = true;
            this.cboMovieName_Showtime.Location = new System.Drawing.Point(125, 69);
            this.cboMovieName_Showtime.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboMovieName_Showtime.Name = "cboMovieName_Showtime";
            this.cboMovieName_Showtime.Size = new System.Drawing.Size(163, 21);
            this.cboMovieName_Showtime.TabIndex = 30;
            this.cboMovieName_Showtime.SelectedIndexChanged += new System.EventHandler(this.cboMovieName_Showtime_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimetimes);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dateTimeDay);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.LightSlateGray;
            this.groupBox1.Location = new System.Drawing.Point(15, 306);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(287, 78);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thời gian kết thúc";
            // 
            // dateTimetimes
            // 
            this.dateTimetimes.CalendarFont = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimetimes.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimetimes.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimetimes.Location = new System.Drawing.Point(110, 45);
            this.dateTimetimes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimetimes.Name = "dateTimetimes";
            this.dateTimetimes.ShowUpDown = true;
            this.dateTimetimes.Size = new System.Drawing.Size(163, 26);
            this.dateTimetimes.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 50);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 19);
            this.label3.TabIndex = 12;
            this.label3.Text = "Giờ:";
            // 
            // dateTimeDay
            // 
            this.dateTimeDay.CalendarFont = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeDay.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeDay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeDay.Location = new System.Drawing.Point(110, 16);
            this.dateTimeDay.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimeDay.Name = "dateTimeDay";
            this.dateTimeDay.Size = new System.Drawing.Size(163, 26);
            this.dateTimeDay.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(22, 20);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 19);
            this.label8.TabIndex = 12;
            this.label8.Text = "Ngày:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtmShowtimeTime);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.dtmShowtimeDate);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.LightSlateGray;
            this.groupBox2.Location = new System.Drawing.Point(15, 213);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(287, 80);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thời gian chiếu";
            // 
            // dtmShowtimeTime
            // 
            this.dtmShowtimeTime.CalendarFont = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtmShowtimeTime.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtmShowtimeTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtmShowtimeTime.Location = new System.Drawing.Point(110, 45);
            this.dtmShowtimeTime.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtmShowtimeTime.Name = "dtmShowtimeTime";
            this.dtmShowtimeTime.ShowUpDown = true;
            this.dtmShowtimeTime.Size = new System.Drawing.Size(163, 26);
            this.dtmShowtimeTime.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(22, 50);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 19);
            this.label6.TabIndex = 12;
            this.label6.Text = "Giờ:";
            // 
            // dtmShowtimeDate
            // 
            this.dtmShowtimeDate.CalendarFont = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtmShowtimeDate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtmShowtimeDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtmShowtimeDate.Location = new System.Drawing.Point(110, 16);
            this.dtmShowtimeDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtmShowtimeDate.Name = "dtmShowtimeDate";
            this.dtmShowtimeDate.Size = new System.Drawing.Size(163, 26);
            this.dtmShowtimeDate.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(22, 20);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 19);
            this.label5.TabIndex = 12;
            this.label5.Text = "Ngày:";
            // 
            // cboRap
            // 
            this.cboRap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRap.FormattingEnabled = true;
            this.cboRap.Location = new System.Drawing.Point(125, 172);
            this.cboRap.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboRap.Name = "cboRap";
            this.cboRap.Size = new System.Drawing.Size(163, 21);
            this.cboRap.TabIndex = 27;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(12, 173);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 19);
            this.label10.TabIndex = 21;
            this.label10.Text = "Rạp :";
            // 
            // cboCinemaID_Showtime
            // 
            this.cboCinemaID_Showtime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCinemaID_Showtime.FormattingEnabled = true;
            this.cboCinemaID_Showtime.Location = new System.Drawing.Point(125, 137);
            this.cboCinemaID_Showtime.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboCinemaID_Showtime.Name = "cboCinemaID_Showtime";
            this.cboCinemaID_Showtime.Size = new System.Drawing.Size(163, 21);
            this.cboCinemaID_Showtime.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 138);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 19);
            this.label2.TabIndex = 21;
            this.label2.Text = "Phòng chiếu:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 400);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 19);
            this.label7.TabIndex = 22;
            this.label7.Text = "Giá vé:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 102);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 19);
            this.label4.TabIndex = 24;
            this.label4.Text = "Phim:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 19);
            this.label1.TabIndex = 25;
            this.label1.Text = "Mã lịch chiếu:";
            // 
            // txtTicketPrice_Showtime
            // 
            this.txtTicketPrice_Showtime.Location = new System.Drawing.Point(125, 400);
            this.txtTicketPrice_Showtime.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTicketPrice_Showtime.Name = "txtTicketPrice_Showtime";
            this.txtTicketPrice_Showtime.Size = new System.Drawing.Size(163, 20);
            this.txtTicketPrice_Showtime.TabIndex = 18;
            // 
            // txtShowtimeID
            // 
            this.txtShowtimeID.Location = new System.Drawing.Point(125, 11);
            this.txtShowtimeID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtShowtimeID.Name = "txtShowtimeID";
            this.txtShowtimeID.Size = new System.Drawing.Size(163, 20);
            this.txtShowtimeID.TabIndex = 19;
            // 
            // btnUpdateShowtime
            // 
            this.btnUpdateShowtime.AutoRoundedCorners = true;
            this.btnUpdateShowtime.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btnUpdateShowtime.BorderThickness = 2;
            this.btnUpdateShowtime.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdateShowtime.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdateShowtime.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUpdateShowtime.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUpdateShowtime.FillColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnUpdateShowtime.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.btnUpdateShowtime.ForeColor = System.Drawing.Color.Black;
            this.btnUpdateShowtime.Location = new System.Drawing.Point(193, 10);
            this.btnUpdateShowtime.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnUpdateShowtime.Name = "btnUpdateShowtime";
            this.btnUpdateShowtime.Size = new System.Drawing.Size(107, 46);
            this.btnUpdateShowtime.TabIndex = 4;
            this.btnUpdateShowtime.Text = "Sửa";
            this.btnUpdateShowtime.Click += new System.EventHandler(this.btnUpdateShowtime_Click);
            // 
            // btnDeleteShowtime
            // 
            this.btnDeleteShowtime.AutoRoundedCorners = true;
            this.btnDeleteShowtime.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btnDeleteShowtime.BorderThickness = 2;
            this.btnDeleteShowtime.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteShowtime.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteShowtime.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDeleteShowtime.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDeleteShowtime.FillColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnDeleteShowtime.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.btnDeleteShowtime.ForeColor = System.Drawing.Color.Black;
            this.btnDeleteShowtime.Location = new System.Drawing.Point(347, 10);
            this.btnDeleteShowtime.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDeleteShowtime.Name = "btnDeleteShowtime";
            this.btnDeleteShowtime.Size = new System.Drawing.Size(113, 48);
            this.btnDeleteShowtime.TabIndex = 5;
            this.btnDeleteShowtime.Text = "Xóa";
            this.btnDeleteShowtime.Click += new System.EventHandler(this.btnDeleteShowtime_Click);
            // 
            // btnInsertShowtime
            // 
            this.btnInsertShowtime.AutoRoundedCorners = true;
            this.btnInsertShowtime.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btnInsertShowtime.BorderThickness = 2;
            this.btnInsertShowtime.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnInsertShowtime.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnInsertShowtime.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnInsertShowtime.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnInsertShowtime.FillColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnInsertShowtime.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.btnInsertShowtime.ForeColor = System.Drawing.Color.Black;
            this.btnInsertShowtime.Location = new System.Drawing.Point(43, 12);
            this.btnInsertShowtime.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnInsertShowtime.Name = "btnInsertShowtime";
            this.btnInsertShowtime.Size = new System.Drawing.Size(102, 45);
            this.btnInsertShowtime.TabIndex = 3;
            this.btnInsertShowtime.Text = "Thêm";
            this.btnInsertShowtime.Click += new System.EventHandler(this.btnInsertShowtime_Click);
            // 
            // panel54
            // 
            this.panel54.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel54.Controls.Add(this.panel1);
            this.panel54.Controls.Add(this.btnInsertShowtime);
            this.panel54.Controls.Add(this.btnDeleteShowtime);
            this.panel54.Controls.Add(this.btnUpdateShowtime);
            this.panel54.Location = new System.Drawing.Point(0, 0);
            this.panel54.Name = "panel54";
            this.panel54.Size = new System.Drawing.Size(1000, 515);
            this.panel54.TabIndex = 12;
            // 

            this.dtgvShowtime.Size = new System.Drawing.Size(970, 652);
            this.dtgvShowtime.TabIndex = 1;
            this.dtgvShowtime.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvShowtime_CellContentClick);
            // 

            // MaCaChieu
            // 
            this.MaCaChieu.DataPropertyName = "MaCaChieu";
            this.MaCaChieu.HeaderText = "Mã Ca Chiếu";
            this.MaCaChieu.MinimumWidth = 6;
            this.MaCaChieu.Name = "MaCaChieu";
            this.MaCaChieu.ReadOnly = true;
            this.MaCaChieu.Width = 125;
            // 
            // MaPhong
            // 
            this.MaPhong.DataPropertyName = "MaPhong";
            this.MaPhong.HeaderText = "Mã Phòng";
            this.MaPhong.MinimumWidth = 6;
            this.MaPhong.Name = "MaPhong";
            this.MaPhong.ReadOnly = true;
            this.MaPhong.Width = 85;
            // 
            // MaRap
            // 
            this.MaRap.DataPropertyName = "MaRap";
            this.MaRap.HeaderText = "Mã Rạp";
            this.MaRap.MinimumWidth = 6;
            this.MaRap.Name = "MaRap";
            this.MaRap.ReadOnly = true;
            this.MaRap.Width = 75;
            // 
            // TenPhim
            // 
            this.TenPhim.DataPropertyName = "TenPhim";
            this.TenPhim.HeaderText = "Tên Phim";
            this.TenPhim.MinimumWidth = 6;
            this.TenPhim.Name = "TenPhim";
            this.TenPhim.ReadOnly = true;
            this.TenPhim.Width = 125;
            // 
            // ThoiGianChieu
            // 
            this.ThoiGianChieu.DataPropertyName = "ThoiGianChieu";
            this.ThoiGianChieu.HeaderText = "Thời gian chiếu";
            this.ThoiGianChieu.MinimumWidth = 6;
            this.ThoiGianChieu.Name = "ThoiGianChieu";
            this.ThoiGianChieu.ReadOnly = true;
            this.ThoiGianChieu.Width = 125;
            // 
            // ThoiGianKetThuc
            // 
            this.ThoiGianKetThuc.DataPropertyName = "ThoiGianKetThuc";
            this.ThoiGianKetThuc.HeaderText = "Thời gian kết thúc";
            this.ThoiGianKetThuc.MinimumWidth = 6;
            this.ThoiGianKetThuc.Name = "ThoiGianKetThuc";
            this.ThoiGianKetThuc.ReadOnly = true;
            this.ThoiGianKetThuc.Width = 125;
            // 
            // GiaVe
            // 
            this.GiaVe.DataPropertyName = "GiaVe";
            this.GiaVe.HeaderText = "Giá Vé";
            this.GiaVe.MinimumWidth = 6;
            this.GiaVe.Name = "GiaVe";
            this.GiaVe.ReadOnly = true;
            this.GiaVe.Width = 125;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.txtMovieName_Showtime);
            this.panel2.Controls.Add(this.cboMovieName_Showtime);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.cboRap);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.cboCinemaID_Showtime);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txtTicketPrice_Showtime);
            this.panel2.Controls.Add(this.txtShowtimeID);
            this.panel2.ForeColor = System.Drawing.Color.LightSlateGray;
            this.panel2.Location = new System.Drawing.Point(1005, 17);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(474, 654);
            this.panel2.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(18, 108);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(105, 26);
            this.label9.TabIndex = 32;
            this.label9.Text = "Mã phim";
            // 
            // txtMovieName_Showtime
            // 
            this.txtMovieName_Showtime.Location = new System.Drawing.Point(188, 157);
            this.txtMovieName_Showtime.Name = "txtMovieName_Showtime";
            this.txtMovieName_Showtime.ReadOnly = true;
            this.txtMovieName_Showtime.Size = new System.Drawing.Size(242, 26);
            this.txtMovieName_Showtime.TabIndex = 31;
            // 
            // cboMovieName_Showtime
            // 
            this.cboMovieName_Showtime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMovieName_Showtime.FormattingEnabled = true;
            this.cboMovieName_Showtime.Location = new System.Drawing.Point(188, 106);
            this.cboMovieName_Showtime.Name = "cboMovieName_Showtime";
            this.cboMovieName_Showtime.Size = new System.Drawing.Size(242, 28);
            this.cboMovieName_Showtime.TabIndex = 30;
            this.cboMovieName_Showtime.SelectedIndexChanged += new System.EventHandler(this.cboMovieName_Showtime_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimetimes);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dateTimeDay);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.LightSlateGray;
            this.groupBox1.Location = new System.Drawing.Point(22, 471);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(430, 120);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thời gian kết thúc";
            // 
            // dateTimetimes
            // 
            this.dateTimetimes.CalendarFont = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimetimes.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimetimes.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimetimes.Location = new System.Drawing.Point(165, 69);
            this.dateTimetimes.Name = "dateTimetimes";
            this.dateTimetimes.ShowUpDown = true;
            this.dateTimetimes.Size = new System.Drawing.Size(242, 35);
            this.dateTimetimes.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 26);
            this.label3.TabIndex = 12;
            this.label3.Text = "Giờ:";
            // 
            // dateTimeDay
            // 
            this.dateTimeDay.CalendarFont = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeDay.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeDay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeDay.Location = new System.Drawing.Point(165, 25);
            this.dateTimeDay.Name = "dateTimeDay";
            this.dateTimeDay.Size = new System.Drawing.Size(242, 35);
            this.dateTimeDay.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(33, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 26);
            this.label8.TabIndex = 12;
            this.label8.Text = "Ngày:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtmShowtimeTime);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.dtmShowtimeDate);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.LightSlateGray;
            this.groupBox2.Location = new System.Drawing.Point(22, 328);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(430, 123);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thời gian chiếu";
            // 
            // dtmShowtimeTime
            // 
            this.dtmShowtimeTime.CalendarFont = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtmShowtimeTime.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtmShowtimeTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtmShowtimeTime.Location = new System.Drawing.Point(165, 69);
            this.dtmShowtimeTime.Name = "dtmShowtimeTime";
            this.dtmShowtimeTime.ShowUpDown = true;
            this.dtmShowtimeTime.Size = new System.Drawing.Size(242, 35);
            this.dtmShowtimeTime.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(33, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 26);
            this.label6.TabIndex = 12;
            this.label6.Text = "Giờ:";
            // 
            // dtmShowtimeDate
            // 
            this.dtmShowtimeDate.CalendarFont = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtmShowtimeDate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtmShowtimeDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtmShowtimeDate.Location = new System.Drawing.Point(165, 25);
            this.dtmShowtimeDate.Name = "dtmShowtimeDate";
            this.dtmShowtimeDate.Size = new System.Drawing.Size(242, 35);
            this.dtmShowtimeDate.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(33, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 26);
            this.label5.TabIndex = 12;
            this.label5.Text = "Ngày:";
            // 
            // cboRap
            // 
            this.cboRap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRap.FormattingEnabled = true;
            this.cboRap.Location = new System.Drawing.Point(188, 265);
            this.cboRap.Name = "cboRap";
            this.cboRap.Size = new System.Drawing.Size(242, 28);
            this.cboRap.TabIndex = 27;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(18, 266);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 26);
            this.label10.TabIndex = 21;
            this.label10.Text = "Rạp :";
            // 
            // cboCinemaID_Showtime
            // 
            this.cboCinemaID_Showtime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCinemaID_Showtime.FormattingEnabled = true;
            this.cboCinemaID_Showtime.Location = new System.Drawing.Point(188, 211);
            this.cboCinemaID_Showtime.Name = "cboCinemaID_Showtime";
            this.cboCinemaID_Showtime.Size = new System.Drawing.Size(242, 28);
            this.cboCinemaID_Showtime.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 26);
            this.label2.TabIndex = 21;
            this.label2.Text = "Phòng chiếu:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(18, 615);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 26);
            this.label7.TabIndex = 22;
            this.label7.Text = "Giá vé:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 26);
            this.label4.TabIndex = 24;
            this.label4.Text = "Phim:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 26);
            this.label1.TabIndex = 25;
            this.label1.Text = "Mã lịch chiếu:";
            // 
            // txtTicketPrice_Showtime
            // 
            this.txtTicketPrice_Showtime.Location = new System.Drawing.Point(188, 615);
            this.txtTicketPrice_Showtime.Name = "txtTicketPrice_Showtime";
            this.txtTicketPrice_Showtime.Size = new System.Drawing.Size(242, 26);
            this.txtTicketPrice_Showtime.TabIndex = 18;
            // 
            // txtShowtimeID
            // 
            this.txtShowtimeID.Location = new System.Drawing.Point(188, 17);
            this.txtShowtimeID.Name = "txtShowtimeID";
            this.txtShowtimeID.Size = new System.Drawing.Size(242, 26);
            this.txtShowtimeID.TabIndex = 19;
            // 
            // btnUpdateShowtime
            // 
            this.btnUpdateShowtime.AutoRoundedCorners = true;
            this.btnUpdateShowtime.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btnUpdateShowtime.BorderThickness = 2;
            this.btnUpdateShowtime.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdateShowtime.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdateShowtime.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUpdateShowtime.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUpdateShowtime.FillColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnUpdateShowtime.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.btnUpdateShowtime.ForeColor = System.Drawing.Color.Black;
            this.btnUpdateShowtime.Location = new System.Drawing.Point(290, 15);
            this.btnUpdateShowtime.Name = "btnUpdateShowtime";
            this.btnUpdateShowtime.Size = new System.Drawing.Size(160, 71);
            this.btnUpdateShowtime.TabIndex = 4;
            this.btnUpdateShowtime.Text = "Sửa";
            this.btnUpdateShowtime.Click += new System.EventHandler(this.btnUpdateShowtime_Click);
            // 
            // btnDeleteShowtime
            // 
            this.btnDeleteShowtime.AutoRoundedCorners = true;
            this.btnDeleteShowtime.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btnDeleteShowtime.BorderThickness = 2;
            this.btnDeleteShowtime.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteShowtime.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteShowtime.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDeleteShowtime.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDeleteShowtime.FillColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnDeleteShowtime.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.btnDeleteShowtime.ForeColor = System.Drawing.Color.Black;
            this.btnDeleteShowtime.Location = new System.Drawing.Point(520, 15);
            this.btnDeleteShowtime.Name = "btnDeleteShowtime";
            this.btnDeleteShowtime.Size = new System.Drawing.Size(170, 74);
            this.btnDeleteShowtime.TabIndex = 5;
            this.btnDeleteShowtime.Text = "Xóa";
            this.btnDeleteShowtime.Click += new System.EventHandler(this.btnDeleteShowtime_Click);
            // 
            // btnInsertShowtime
            // 
            this.btnInsertShowtime.AutoRoundedCorners = true;
            this.btnInsertShowtime.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btnInsertShowtime.BorderThickness = 2;
            this.btnInsertShowtime.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnInsertShowtime.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnInsertShowtime.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnInsertShowtime.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnInsertShowtime.FillColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnInsertShowtime.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.btnInsertShowtime.ForeColor = System.Drawing.Color.Black;
            this.btnInsertShowtime.Location = new System.Drawing.Point(64, 18);
            this.btnInsertShowtime.Name = "btnInsertShowtime";
            this.btnInsertShowtime.Size = new System.Drawing.Size(153, 69);
            this.btnInsertShowtime.TabIndex = 3;
            this.btnInsertShowtime.Text = "Thêm";
            this.btnInsertShowtime.Click += new System.EventHandler(this.btnInsertShowtime_Click);
            // 
            // panel54
            // 
            this.panel54.BackColor = System.Drawing.Color.White;
            this.panel54.Controls.Add(this.panel1);
            this.panel54.Controls.Add(this.btnInsertShowtime);
            this.panel54.Controls.Add(this.btnDeleteShowtime);
            this.panel54.Controls.Add(this.btnUpdateShowtime);
            this.panel54.Location = new System.Drawing.Point(0, 0);
            this.panel54.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel54.Name = "panel54";
            this.panel54.Size = new System.Drawing.Size(1500, 792);
            this.panel54.TabIndex = 12;
            // 
            // ShowTimesUC
            // 

            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel54);
            this.Name = "ShowTimesUC";
            this.Size = new System.Drawing.Size(1500, 803);

            this.Load += new System.EventHandler(this.ShowTimesUC_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvShowtime)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel54.ResumeLayout(false);
            this.ResumeLayout(false);

        }


        #endregion
        private ToolTip toolTipCinema;
        private Panel panel1;
        private Panel panel3;
        private DataGridView dtgvShowtime;
        private Panel panel2;
        private Label label9;
        private TextBox txtMovieName_Showtime;
        private ComboBox cboMovieName_Showtime;
        private GroupBox groupBox1;
        private DateTimePicker dateTimetimes;
        private Label label3;
        private DateTimePicker dateTimeDay;
        private Label label8;
        private GroupBox groupBox2;
        private DateTimePicker dtmShowtimeTime;
        private Label label6;
        private DateTimePicker dtmShowtimeDate;
        private Label label5;
        private ComboBox cboRap;
        private Label label10;
        private ComboBox cboCinemaID_Showtime;
        private Label label2;
        private Label label7;
        private Label label4;
        private Label label1;
        private TextBox txtTicketPrice_Showtime;
        private TextBox txtShowtimeID;
        private Guna.UI2.WinForms.Guna2Button btnUpdateShowtime;
        private Guna.UI2.WinForms.Guna2Button btnDeleteShowtime;
        private Guna.UI2.WinForms.Guna2Button btnInsertShowtime;
        private Panel panel54;
        private DataGridViewTextBoxColumn MaCaChieu;
        private DataGridViewTextBoxColumn MaPhong;
        private DataGridViewTextBoxColumn MaRap;
        private DataGridViewTextBoxColumn TenPhim;
        private DataGridViewTextBoxColumn ThoiGianChieu;
        private DataGridViewTextBoxColumn ThoiGianKetThuc;
        private DataGridViewTextBoxColumn GiaVe;
    }
}
