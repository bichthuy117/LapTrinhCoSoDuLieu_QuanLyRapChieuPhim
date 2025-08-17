using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

namespace QuanLyRapChieu
{
    public partial class frmRegister : Form
    {
        public frmRegister()
        {
            InitializeComponent();
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            int birth = Int32.Parse(txtBirth.Text);
            string phoneNumber = txtPhoneNumber.Text.Trim();
            int point = 0;
            string address = txtAddress.Text;
            if (CustomerBUS.Instance.addCustomer(name, birth, phoneNumber, point, address))
            {
                MessageBox.Show("Thêm thành viên thành công!");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thoát chương trình?", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Application.Exit(); // Thoát toàn bộ chương trình
            }
        }

      
    }
}
