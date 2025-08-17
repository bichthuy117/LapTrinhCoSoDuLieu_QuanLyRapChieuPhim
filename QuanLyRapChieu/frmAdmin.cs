using QuanLyRapChieu.frmAdminUserControl;
using QuanLyXemPhim.frmAdminUserControl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyRapChieu
{
    public partial class frmAdmin : Form
    {
        public frmAdmin()
        {
            InitializeComponent();
        }

        private void btnDataUC_Click(object sender, EventArgs e)
        {
            FeatureViewUC featureViewUC = new FeatureViewUC();
            pnAdmin.Controls.Clear();
            featureViewUC.Dock = DockStyle.Fill;
            pnAdmin.Controls.Add(featureViewUC);
        }

   
        private void btnStaffUC_Click(object sender, EventArgs e)
        {
            StaffUC staffUC = new StaffUC();
            pnAdmin.Controls.Clear();
            staffUC.Dock = DockStyle.Fill;
            pnAdmin.Controls.Add(staffUC);
        }

        private void btnCustomerUC_Click(object sender, EventArgs e)
        {
            CustomerUC customerUC = new CustomerUC();
            pnAdmin.Controls.Clear();
            customerUC.Dock = DockStyle.Fill;
            pnAdmin.Controls.Add(customerUC);
        }

        //Button hien thi thong tin tai khoan Admin, Staff
        private void btnAccountUC_Click(object sender, EventArgs e)
        {
            pnAdmin.Controls.Clear();
            AccountUC accountUC = new AccountUC();
            accountUC.Dock = DockStyle.Fill;
            pnAdmin.Controls.Add(accountUC);
        }

        //Button Thong Ke Doanh thu
        private void button1_Click(object sender, EventArgs e)
        {
            this.Text = "Doanh Thu";
            pnAdmin.Controls.Clear();
            RevenueUC revenueUc = new RevenueUC();
            revenueUc.Dock = DockStyle.Fill;
            pnAdmin.Controls.Add(revenueUc);
        }

        private void frmAdmin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thoát chương trình?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        
    }
}
