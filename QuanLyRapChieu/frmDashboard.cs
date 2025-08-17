using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;

namespace QuanLyRapChieu
{
    public partial class frmDashboard : Form
    {
        private TaiKhoan taiKhoan;
        public frmDashboard(TaiKhoan taiKhoan)
        {
            this.taiKhoan = taiKhoan;
            InitializeComponent();

            handleAccessPermissions(this.taiKhoan);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }




        public void handleAccessPermissions(TaiKhoan taiKhoan)
        {
            lblAccountInfo.Text += taiKhoan.UserName;
            if (taiKhoan.LoaiTK != 1) // Admin
            {
                btn_Admin.Enabled = false;
            }
        }
        private void btn_Admin_Click(object sender, EventArgs e)
        {
            frmAdmin frmAdmin = new frmAdmin();
            frmAdmin.ShowDialog();
        }

        private void btn_Staff_Click(object sender, EventArgs e)
        {
            frmStaff frmStaff = new frmStaff();
            frmStaff.ShowDialog();
        }

    }
}
