using System.Windows.Forms;

namespace QuanLyXemPhim.frmAdminUserControl.FeatureViewUserControl
{
    partial class TicketsUC
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
            this.dtgvTicket = new System.Windows.Forms.DataGridView();
            this.lsvAllListShowTimes = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel61 = new System.Windows.Forms.Panel();
            this.btnAllListShowTimes = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddTicketsByShowTime = new Guna.UI2.WinForms.Guna2Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTicket)).BeginInit();
            this.panel61.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgvTicket
            // 
            this.dtgvTicket.AllowUserToDeleteRows = false;
            this.dtgvTicket.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvTicket.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvTicket.Location = new System.Drawing.Point(15, 59);
            this.dtgvTicket.Name = "dtgvTicket";
            this.dtgvTicket.RowHeadersWidth = 51;
            this.dtgvTicket.Size = new System.Drawing.Size(445, 454);
            this.dtgvTicket.TabIndex = 21;
            // 
            // lsvAllListShowTimes
            // 
            this.lsvAllListShowTimes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lsvAllListShowTimes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lsvAllListShowTimes.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsvAllListShowTimes.FullRowSelect = true;
            this.lsvAllListShowTimes.GridLines = true;
            this.lsvAllListShowTimes.HideSelection = false;
            this.lsvAllListShowTimes.Location = new System.Drawing.Point(0, 0);
            this.lsvAllListShowTimes.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.lsvAllListShowTimes.Name = "lsvAllListShowTimes";
            this.lsvAllListShowTimes.Size = new System.Drawing.Size(516, 456);
            this.lsvAllListShowTimes.TabIndex = 22;
            this.lsvAllListShowTimes.UseCompatibleStateImageBehavior = false;
            this.lsvAllListShowTimes.View = System.Windows.Forms.View.Details;
            this.lsvAllListShowTimes.Click += new System.EventHandler(this.lsvAllListShowTimes_Click);
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Mã Ca Chiếu";
            this.columnHeader5.Width = 100;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã Phòng Chiếu";
            this.columnHeader1.Width = 89;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên Phim";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Thời Gian Chiếu";
            this.columnHeader3.Width = 87;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Trạng Thái Chiếu";
            this.columnHeader4.Width = 222;
            // 
            // panel61
            // 
            this.panel61.Controls.Add(this.btnAllListShowTimes);
            this.panel61.Controls.Add(this.btnAddTicketsByShowTime);
            this.panel61.Location = new System.Drawing.Point(15, 1);
            this.panel61.Name = "panel61";
            this.panel61.Size = new System.Drawing.Size(287, 52);
            this.panel61.TabIndex = 23;
            // 
            // btnAllListShowTimes
            // 
            this.btnAllListShowTimes.AutoRoundedCorners = true;
            this.btnAllListShowTimes.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btnAllListShowTimes.BorderRadius = 21;
            this.btnAllListShowTimes.BorderThickness = 2;
            this.btnAllListShowTimes.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAllListShowTimes.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAllListShowTimes.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAllListShowTimes.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAllListShowTimes.FillColor = System.Drawing.Color.LightSteelBlue;
            this.btnAllListShowTimes.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAllListShowTimes.ForeColor = System.Drawing.Color.Black;
            this.btnAllListShowTimes.IndicateFocus = true;
            this.btnAllListShowTimes.Location = new System.Drawing.Point(3, 5);
            this.btnAllListShowTimes.Name = "btnAllListShowTimes";
            this.btnAllListShowTimes.Size = new System.Drawing.Size(128, 44);
            this.btnAllListShowTimes.TabIndex = 41;
            this.btnAllListShowTimes.TabStop = false;
            this.btnAllListShowTimes.Text = "Xem Tất Cả Lịch Chiếu";
            this.btnAllListShowTimes.Click += new System.EventHandler(this.btnAllListShowTimes_Click);
            // 
            // btnAddTicketsByShowTime
            // 
            this.btnAddTicketsByShowTime.AutoRoundedCorners = true;
            this.btnAddTicketsByShowTime.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btnAddTicketsByShowTime.BorderRadius = 21;
            this.btnAddTicketsByShowTime.BorderThickness = 2;
            this.btnAddTicketsByShowTime.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddTicketsByShowTime.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddTicketsByShowTime.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddTicketsByShowTime.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddTicketsByShowTime.FillColor = System.Drawing.Color.LightSteelBlue;
            this.btnAddTicketsByShowTime.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTicketsByShowTime.ForeColor = System.Drawing.Color.Black;
            this.btnAddTicketsByShowTime.IndicateFocus = true;
            this.btnAddTicketsByShowTime.Location = new System.Drawing.Point(149, 5);
            this.btnAddTicketsByShowTime.Name = "btnAddTicketsByShowTime";
            this.btnAddTicketsByShowTime.Size = new System.Drawing.Size(128, 44);
            this.btnAddTicketsByShowTime.TabIndex = 42;
            this.btnAddTicketsByShowTime.TabStop = false;
            this.btnAddTicketsByShowTime.Text = "Tạo vé phim";
            this.btnAddTicketsByShowTime.Click += new System.EventHandler(this.btnAddTicketsByShowTime_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel61);
            this.panel1.Controls.Add(this.dtgvTicket);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(994, 611);
            this.panel1.TabIndex = 0;
            this.panel1.TabStop = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lsvAllListShowTimes);
            this.panel2.Location = new System.Drawing.Point(465, 59);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(516, 456);
            this.panel2.TabIndex = 24;
            // 
            // TicketsUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Name = "TicketsUC";
            this.Size = new System.Drawing.Size(994, 611);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTicket)).EndInit();
            this.panel61.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvTicket;
        private System.Windows.Forms.ListView lsvAllListShowTimes;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Panel panel61;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2Button btnAllListShowTimes;
        private Guna.UI2.WinForms.Guna2Button btnAddTicketsByShowTime;
    }
}