using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace QuanLyRapChieu
{
    partial class frmTheatre
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
            this.flpSeat = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblInformation = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.grpTicketType = new System.Windows.Forms.GroupBox();
            this.rdoFree = new System.Windows.Forms.RadioButton();
            this.rdoStudent = new System.Windows.Forms.RadioButton();
            this.rdoAdult = new System.Windows.Forms.RadioButton();
            this.rdoChild = new System.Windows.Forms.RadioButton();
            this.pnCustomer = new System.Windows.Forms.Panel();
            this.btnUsePoint = new System.Windows.Forms.Button();
            this.numBonusPoint = new System.Windows.Forms.NumericUpDown();
            this.txtCustomerName = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.txtPoint = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.chkCustomer = new System.Windows.Forms.CheckBox();
            this.pnlRefund = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtRefund = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtTotal = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDiscount = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panelScreen = new System.Windows.Forms.Panel();
            this.lbScreen = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel7.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.grpTicketType.SuspendLayout();
            this.pnCustomer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numBonusPoint)).BeginInit();
            this.pnlRefund.SuspendLayout();
            this.panelScreen.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // flpSeat
            // 
            this.flpSeat.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flpSeat.AutoScroll = true;
            this.flpSeat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flpSeat.Location = new System.Drawing.Point(27, 155);
            this.flpSeat.Margin = new System.Windows.Forms.Padding(0);
            this.flpSeat.Name = "flpSeat";
            this.flpSeat.Size = new System.Drawing.Size(1022, 372);
            this.flpSeat.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.AliceBlue;
            this.panel4.Controls.Add(this.panel3);
            this.panel4.Controls.Add(this.lblTime);
            this.panel4.Controls.Add(this.lblInformation);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1362, 71);
            this.panel4.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(1054, 69);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(216, 51);
            this.panel3.TabIndex = 8;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.Maroon;
            this.lblTime.Location = new System.Drawing.Point(13, 39);
            this.lblTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(85, 18);
            this.lblTime.TabIndex = 2;
            this.lblTime.Text = "Giờ chiếu:";
            // 
            // lblInformation
            // 
            this.lblInformation.AutoSize = true;
            this.lblInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInformation.ForeColor = System.Drawing.Color.Maroon;
            this.lblInformation.Location = new System.Drawing.Point(13, 9);
            this.lblInformation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInformation.Name = "lblInformation";
            this.lblInformation.Size = new System.Drawing.Size(124, 18);
            this.lblInformation.TabIndex = 1;
            this.lblInformation.Text = "Thông tin phim:";
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.panel7);
            this.panel5.Controls.Add(this.pnlRefund);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 547);
            this.panel5.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1362, 202);
            this.panel5.TabIndex = 6;
            // 
            // panel7
            // 
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.groupBox2);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(876, 200);
            this.panel7.TabIndex = 17;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox2.Controls.Add(this.grpTicketType);
            this.groupBox2.Controls.Add(this.pnCustomer);
            this.groupBox2.Controls.Add(this.chkCustomer);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(-1, 1);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.groupBox2.Size = new System.Drawing.Size(884, 198);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thành Viên:";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // grpTicketType
            // 
            this.grpTicketType.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.grpTicketType.Controls.Add(this.rdoFree);
            this.grpTicketType.Controls.Add(this.rdoStudent);
            this.grpTicketType.Controls.Add(this.rdoAdult);
            this.grpTicketType.Controls.Add(this.rdoChild);
            this.grpTicketType.ForeColor = System.Drawing.Color.Black;
            this.grpTicketType.Location = new System.Drawing.Point(539, 0);
            this.grpTicketType.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.grpTicketType.Name = "grpTicketType";
            this.grpTicketType.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.grpTicketType.Size = new System.Drawing.Size(381, 200);
            this.grpTicketType.TabIndex = 19;
            this.grpTicketType.TabStop = false;
            this.grpTicketType.Text = "Loại vé";
            // 
            // rdoFree
            // 
            this.rdoFree.AutoSize = true;
            this.rdoFree.Location = new System.Drawing.Point(52, 151);
            this.rdoFree.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.rdoFree.Name = "rdoFree";
            this.rdoFree.Size = new System.Drawing.Size(113, 22);
            this.rdoFree.TabIndex = 9;
            this.rdoFree.Text = "Vé miễn phí";
            this.rdoFree.UseVisualStyleBackColor = true;
            // 
            // rdoStudent
            // 
            this.rdoStudent.AutoSize = true;
            this.rdoStudent.Location = new System.Drawing.Point(52, 114);
            this.rdoStudent.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.rdoStudent.Name = "rdoStudent";
            this.rdoStudent.Size = new System.Drawing.Size(203, 22);
            this.rdoStudent.TabIndex = 8;
            this.rdoStudent.Text = "Sinh Viên (Trên 18 tuổi)";
            this.rdoStudent.UseVisualStyleBackColor = true;
            // 
            // rdoAdult
            // 
            this.rdoAdult.AutoSize = true;
            this.rdoAdult.Checked = true;
            this.rdoAdult.Location = new System.Drawing.Point(52, 41);
            this.rdoAdult.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.rdoAdult.Name = "rdoAdult";
            this.rdoAdult.Size = new System.Drawing.Size(103, 22);
            this.rdoAdult.TabIndex = 7;
            this.rdoAdult.TabStop = true;
            this.rdoAdult.Text = "Người Lớn";
            this.rdoAdult.UseVisualStyleBackColor = true;
            // 
            // rdoChild
            // 
            this.rdoChild.AutoSize = true;
            this.rdoChild.Location = new System.Drawing.Point(52, 77);
            this.rdoChild.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.rdoChild.Name = "rdoChild";
            this.rdoChild.Size = new System.Drawing.Size(202, 22);
            this.rdoChild.TabIndex = 6;
            this.rdoChild.Text = "Học Sinh (Trên 12 tuổi)";
            this.rdoChild.UseVisualStyleBackColor = true;
            // 
            // pnCustomer
            // 
            this.pnCustomer.Controls.Add(this.btnUsePoint);
            this.pnCustomer.Controls.Add(this.numBonusPoint);
            this.pnCustomer.Controls.Add(this.txtCustomerName);
            this.pnCustomer.Controls.Add(this.label7);
            this.pnCustomer.Controls.Add(this.label4);
            this.pnCustomer.Controls.Add(this.lblCustomerName);
            this.pnCustomer.Controls.Add(this.txtPoint);
            this.pnCustomer.Controls.Add(this.label11);
            this.pnCustomer.Location = new System.Drawing.Point(7, 59);
            this.pnCustomer.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.pnCustomer.Name = "pnCustomer";
            this.pnCustomer.Size = new System.Drawing.Size(527, 136);
            this.pnCustomer.TabIndex = 16;
            // 
            // btnUsePoint
            // 
            this.btnUsePoint.BackColor = System.Drawing.Color.SlateGray;
            this.btnUsePoint.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsePoint.ForeColor = System.Drawing.Color.MintCream;
            this.btnUsePoint.Location = new System.Drawing.Point(370, 55);
            this.btnUsePoint.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnUsePoint.Name = "btnUsePoint";
            this.btnUsePoint.Size = new System.Drawing.Size(126, 40);
            this.btnUsePoint.TabIndex = 17;
            this.btnUsePoint.Text = "Sử dụng";
            this.btnUsePoint.UseVisualStyleBackColor = false;
            this.btnUsePoint.Click += new System.EventHandler(this.btnUsePoint_Click);
            // 
            // numBonusPoint
            // 
            this.numBonusPoint.Location = new System.Drawing.Point(220, 99);
            this.numBonusPoint.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.numBonusPoint.Name = "numBonusPoint";
            this.numBonusPoint.Size = new System.Drawing.Size(116, 24);
            this.numBonusPoint.TabIndex = 27;
            this.numBonusPoint.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numBonusPoint.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCustomerName.BackColor = System.Drawing.Color.White;
            this.txtCustomerName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerName.ForeColor = System.Drawing.Color.Red;
            this.txtCustomerName.Location = new System.Drawing.Point(220, 12);
            this.txtCustomerName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(276, 31);
            this.txtCustomerName.TabIndex = 26;
            this.txtCustomerName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 18);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 18);
            this.label7.TabIndex = 25;
            this.label7.Text = "Tên Khách Hàng:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 101);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 18);
            this.label4.TabIndex = 20;
            this.label4.Text = "Điểm Cộng Thêm:";
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.Location = new System.Drawing.Point(187, 2);
            this.lblCustomerName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(209, 25);
            this.lblCustomerName.TabIndex = 19;
            // 
            // txtPoint
            // 
            this.txtPoint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPoint.BackColor = System.Drawing.Color.White;
            this.txtPoint.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtPoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPoint.ForeColor = System.Drawing.Color.Red;
            this.txtPoint.Location = new System.Drawing.Point(220, 57);
            this.txtPoint.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtPoint.Name = "txtPoint";
            this.txtPoint.Size = new System.Drawing.Size(130, 31);
            this.txtPoint.TabIndex = 17;
            this.txtPoint.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 57);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(120, 18);
            this.label11.TabIndex = 16;
            this.label11.Text = "Điểm Tích Lũy:";
            // 
            // chkCustomer
            // 
            this.chkCustomer.AutoSize = true;
            this.chkCustomer.Location = new System.Drawing.Point(17, 26);
            this.chkCustomer.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.chkCustomer.Name = "chkCustomer";
            this.chkCustomer.Size = new System.Drawing.Size(206, 22);
            this.chkCustomer.TabIndex = 0;
            this.chkCustomer.Text = "Khách Hàng Thành Viên";
            this.chkCustomer.UseVisualStyleBackColor = true;
            this.chkCustomer.CheckedChanged += new System.EventHandler(this.chkCustomer_CheckedChanged);
            // 
            // pnlRefund
            // 
            this.pnlRefund.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.pnlRefund.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlRefund.Controls.Add(this.label14);
            this.pnlRefund.Controls.Add(this.label12);
            this.pnlRefund.Controls.Add(this.label13);
            this.pnlRefund.Controls.Add(this.txtRefund);
            this.pnlRefund.Controls.Add(this.btnCancel);
            this.pnlRefund.Controls.Add(this.txtTotal);
            this.pnlRefund.Controls.Add(this.btnNext);
            this.pnlRefund.Controls.Add(this.label5);
            this.pnlRefund.Controls.Add(this.label8);
            this.pnlRefund.Controls.Add(this.label9);
            this.pnlRefund.Controls.Add(this.txtDiscount);
            this.pnlRefund.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlRefund.ForeColor = System.Drawing.Color.White;
            this.pnlRefund.Location = new System.Drawing.Point(876, 0);
            this.pnlRefund.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.pnlRefund.Name = "pnlRefund";
            this.pnlRefund.Size = new System.Drawing.Size(484, 200);
            this.pnlRefund.TabIndex = 14;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Maroon;
            this.label14.Location = new System.Drawing.Point(420, 97);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(43, 20);
            this.label14.TabIndex = 51;
            this.label14.Text = "VNĐ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Maroon;
            this.label12.Location = new System.Drawing.Point(420, 57);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(43, 20);
            this.label12.TabIndex = 50;
            this.label12.Text = "VNĐ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Maroon;
            this.label13.Location = new System.Drawing.Point(420, 15);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(43, 20);
            this.label13.TabIndex = 49;
            this.label13.Text = "VNĐ";
            // 
            // txtRefund
            // 
            this.txtRefund.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRefund.BackColor = System.Drawing.SystemColors.Window;
            this.txtRefund.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtRefund.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRefund.ForeColor = System.Drawing.Color.Maroon;
            this.txtRefund.Location = new System.Drawing.Point(196, 91);
            this.txtRefund.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtRefund.Name = "txtRefund";
            this.txtRefund.Size = new System.Drawing.Size(223, 31);
            this.txtRefund.TabIndex = 13;
            this.txtRefund.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnCancel
            // 
            this.btnCancel.AutoSize = true;
            this.btnCancel.BackColor = System.Drawing.Color.Brown;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(112, 146);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(136, 42);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtTotal
            // 
            this.txtTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTotal.BackColor = System.Drawing.SystemColors.Window;
            this.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.ForeColor = System.Drawing.Color.Maroon;
            this.txtTotal.Location = new System.Drawing.Point(196, 9);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(223, 31);
            this.txtTotal.TabIndex = 9;
            this.txtTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.SteelBlue;
            this.btnNext.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.Color.Transparent;
            this.btnNext.Location = new System.Drawing.Point(288, 145);
            this.btnNext.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(144, 40);
            this.btnNext.TabIndex = 11;
            this.btnNext.Text = "Tiếp tục";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Maroon;
            this.label5.Location = new System.Drawing.Point(5, 55);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Số tiền giảm:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Maroon;
            this.label8.Location = new System.Drawing.Point(5, 12);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "Tổng Tiền:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Maroon;
            this.label9.Location = new System.Drawing.Point(5, 95);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(132, 20);
            this.label9.TabIndex = 8;
            this.label9.Text = "Số tiền cần trả:";
            // 
            // txtDiscount
            // 
            this.txtDiscount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDiscount.BackColor = System.Drawing.SystemColors.Window;
            this.txtDiscount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiscount.ForeColor = System.Drawing.Color.Maroon;
            this.txtDiscount.Location = new System.Drawing.Point(196, 51);
            this.txtDiscount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(223, 31);
            this.txtDiscount.TabIndex = 10;
            this.txtDiscount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Brown;
            this.label10.Location = new System.Drawing.Point(1103, 100);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(113, 29);
            this.label10.TabIndex = 8;
            this.label10.Text = "LỐI VÀO";
            // 
            // panelScreen
            // 
            this.panelScreen.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panelScreen.Controls.Add(this.lbScreen);
            this.panelScreen.Location = new System.Drawing.Point(30, 82);
            this.panelScreen.Name = "panelScreen";
            this.panelScreen.Size = new System.Drawing.Size(1032, 58);
            this.panelScreen.TabIndex = 9;
            // 
            // lbScreen
            // 
            this.lbScreen.AutoSize = true;
            this.lbScreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbScreen.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbScreen.Location = new System.Drawing.Point(357, 8);
            this.lbScreen.Name = "lbScreen";
            this.lbScreen.Size = new System.Drawing.Size(256, 31);
            this.lbScreen.TabIndex = 0;
            this.lbScreen.Text = "MÀN HÌNH CHIẾU";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Brown;
            this.label3.Location = new System.Drawing.Point(60, 59);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ghế đang chọn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Brown;
            this.label2.Location = new System.Drawing.Point(60, 99);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ghế đã mua";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button4.Enabled = false;
            this.button4.Location = new System.Drawing.Point(19, 59);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(33, 31);
            this.button4.TabIndex = 7;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gray;
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(19, 95);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(33, 31);
            this.button1.TabIndex = 8;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Brown;
            this.label6.Location = new System.Drawing.Point(60, 20);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 18);
            this.label6.TabIndex = 9;
            this.label6.Text = "Ghế trống";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightGray;
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(19, 20);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(33, 31);
            this.button2.TabIndex = 10;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(1074, 155);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(236, 149);
            this.panel2.TabIndex = 4;
            // 
            // frmTheatre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1362, 749);
            this.Controls.Add(this.flpSeat);
            this.Controls.Add(this.panelScreen);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmTheatre";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đặt vé";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmTheatre_FormClosing);
            this.Load += new System.EventHandler(this.frmTheatre_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.grpTicketType.ResumeLayout(false);
            this.grpTicketType.PerformLayout();
            this.pnCustomer.ResumeLayout(false);
            this.pnCustomer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numBonusPoint)).EndInit();
            this.pnlRefund.ResumeLayout(false);
            this.pnlRefund.PerformLayout();
            this.panelScreen.ResumeLayout(false);
            this.panelScreen.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

       

        #endregion
        private System.Windows.Forms.Panel panelScreen;
        private System.Windows.Forms.Label lbScreen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblInformation;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel pnlRefund;
        private System.Windows.Forms.Label txtTotal;
        private System.Windows.Forms.Label txtDiscount;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel pnCustomer;
        private System.Windows.Forms.Button btnUsePoint;
        private System.Windows.Forms.NumericUpDown numBonusPoint;
        private System.Windows.Forms.Label txtCustomerName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Label txtPoint;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox chkCustomer;
        private System.Windows.Forms.GroupBox grpTicketType;
        private System.Windows.Forms.RadioButton rdoStudent;
        private System.Windows.Forms.RadioButton rdoAdult;
        private System.Windows.Forms.RadioButton rdoChild;
        private System.Windows.Forms.RadioButton rdoFree;
        private Label txtRefund;
        private FlowLayoutPanel flpSeat;
        private Label label3;
        private Label label2;
        private Button button4;
        private Button button1;
        private Label label6;
        private Button button2;
        private Panel panel2;
        private Label label14;
        private Label label12;
        private Label label13;
    }
}