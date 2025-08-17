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

namespace QuanLyRapChieu.frmAdminUserControl
{
    public partial class AccountUC : UserControl
    {
        BindingSource accountList = new BindingSource();

        public AccountUC()
        {
            InitializeComponent();
            dtgvAccount.DataSource = accountList;
            LoadAccount();
        }
        void LoadAccount()
        {
            TaiKhoanBUS.Instance.hienThiTaiKhoan(accountList);
            bindingTaiKhoan();
        }
        void LoadAccountList()
        {

        }
        private void btnShowAccount_Click(object sender, EventArgs e)
        {
            LoadAccountList();
        }

        public void bindingTaiKhoan()
        {
            txtUsername.DataBindings.Add(new Binding("Text", dtgvAccount.DataSource, "UserName", true, DataSourceUpdateMode.Never));
            txt_Pass.DataBindings.Add(new Binding("Text", dtgvAccount.DataSource, "Pass", true, DataSourceUpdateMode.Never));
            nudAccountType.DataBindings.Add(new Binding("Value", dtgvAccount.DataSource, "LoaiTK", true, DataSourceUpdateMode.Never));
            txt_idNV.DataBindings.Add(new Binding("Text", dtgvAccount.DataSource, "idNV", true, DataSourceUpdateMode.Never));
        }
        private void btnInsertAccount_Click(object sender, EventArgs e)
        {
            string UserName = txtUsername.Text;
            string Pass = txt_Pass.Text;
            int LoaiTK = Convert.ToInt32(nudAccountType.Text);
            string idNV = txt_idNV.Text;
            // Gọi hàm và lấy kết quả
            int result = TaiKhoanBUS.Instance.themDanhSachTaiKhoan(UserName, Pass, LoaiTK, idNV);

            if (result > 0)
            {
                MessageBox.Show("Thêm tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TaiKhoanBUS.Instance.hienThiTaiKhoan(accountList); // Chỉ load lại khi thành công
            }
            else
            {
                MessageBox.Show("Thêm tài khoản thất bại. Vui lòng kiểm tra lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Show_MK_CheckedChanged(object sender, EventArgs e)
        {
            if (Show_MK.Checked)
            {
                txt_Pass.UseSystemPasswordChar = true;
            }
            else
            {
                txt_Pass.UseSystemPasswordChar = false;
            }
        }

        private void btnUpdateAccount_Click(object sender, EventArgs e)
        {
            string UserName = txtUsername.Text;
            string Pass = txt_Pass.Text;
            int LoaiTK = Convert.ToInt32(nudAccountType.Text);
            string idNV = txt_idNV.Text;

            int result = TaiKhoanBUS.Instance.suaDanhSachTaiKhoan(UserName, Pass, LoaiTK, idNV);

            if (result > 0)
            {
                MessageBox.Show("Cập nhật tài khoản thành công!");
                TaiKhoanBUS.Instance.hienThiTaiKhoan(accountList); // Chỉ load lại khi thành công
            }
            else
                MessageBox.Show("Cập nhật tài khoản thất bại!");
        }

        private void btnDeleteAccount_Click(object sender, EventArgs e)
        {
            if (dtgvAccount.SelectedCells.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn tài khoản cần xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string idNV = dtgvAccount.SelectedCells[0].OwningRow.Cells["idNV"].Value.ToString();

            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa tài khoản này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                int kq = TaiKhoanBUS.Instance.xoaDanhSachTaiKhoan(idNV);
                if (kq > 0)
                {
                    MessageBox.Show("Xóa tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TaiKhoanBUS.Instance.hienThiTaiKhoan(accountList);
                }
                else
                {
                    MessageBox.Show("Xóa tài khoản thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
