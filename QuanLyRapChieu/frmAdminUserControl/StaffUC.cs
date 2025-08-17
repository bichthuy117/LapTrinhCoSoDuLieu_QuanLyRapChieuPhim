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

namespace QuanLyXemPhim.frmAdminUserControl
{
    public partial class StaffUC : UserControl
    {
        public StaffUC()
        {
            InitializeComponent();
            LoadDanhSachNhanVien();
        }
        private void LoadDanhSachNhanVien()
        {
            DataTable danhSach = StaffBUS.Instance.getListStaff();

            if (danhSach == null || danhSach.Rows.Count == 0)
            {
                MessageBox.Show("Không thể tải danh sách nhân viên.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            dtgvStaff.DataSource = null;
            dtgvStaff.DataSource = danhSach;
        }

        private void ResetForm()
        {
            txtStaffId.Clear();
            txtStaffName.Clear();
            txtStaffAddress.Clear();
            txtStaffPhone.Clear();
            txtStaffINumber.Clear();
            dtpNgaySinh.Value = DateTime.Now;
        }

        private void btnAddStaff_Click(object sender, EventArgs e)
        {
            if (!KiemTraThongTinDauVao()) return;

            string id = txtStaffId.Text.Trim();
            string name = txtStaffName.Text.Trim();
            string address = txtStaffAddress.Text.Trim();
            string phone = txtStaffPhone.Text.Trim();
            DateTime birth = dtpNgaySinh.Value;
            bool isInt = int.TryParse(txtStaffINumber.Text.Trim(), out int cmnd);

            if (!isInt)
            {
                MessageBox.Show("CMND phải là số.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool result = StaffBUS.Instance.addStaff(id, name, birth, address, phone, cmnd);

            if (result)
            {
                MessageBox.Show("Thêm nhân viên thành công.", "Thông báo");
                LoadDanhSachNhanVien();
                ResetForm();
            }
            else
            {
                MessageBox.Show("Thêm thất bại.", "Lỗi");
            }
        }

        private void btnUpdateStaff_Click(object sender, EventArgs e)
        {
            if (!KiemTraThongTinDauVao()) return;

            String id = txtStaffId.Text;
            String name = txtStaffName.Text;
            DateTime birth = dtpNgaySinh.Value;
            String address = txtStaffAddress.Text;
            String phone = txtStaffPhone.Text;
            int cmnd = Int32.Parse(txtStaffINumber.Text);

            bool result = StaffBUS.Instance.updateStaffBUS(id, name, birth, address, phone, cmnd);

            if (result)
            {
                MessageBox.Show("Cập nhật thành công.", "Thông báo");
                LoadDanhSachNhanVien();
                ResetForm();
            }
            else
            {
                MessageBox.Show("Cập nhật thất bại.", "Lỗi");
            }
        }

        private void btnDeleteStaff_Click(object sender, EventArgs e)
        {
            string id = txtStaffId.Text.Trim();
            if (string.IsNullOrEmpty(id))
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần xóa.", "Cảnh báo");
                return;
            }

            var confirm = MessageBox.Show("Bạn có chắc muốn xóa nhân viên này?", "Xác nhận", MessageBoxButtons.YesNo);
            if (confirm != DialogResult.Yes) return;

            bool result = StaffBUS.Instance.deleteStaffBUS(id);

            if (result)
            {
                MessageBox.Show("Xóa thành công.", "Thông báo");
                LoadDanhSachNhanVien();
                ResetForm();
            }
            else
            {
                MessageBox.Show("Xóa thất bại.", "Lỗi");
            }
        }

        private void dtgvStaff_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dtgvStaff.SelectedRows)
            {
                txtStaffId.Text = row.Cells[0].Value.ToString();
                txtStaffName.Text = row.Cells[1].Value.ToString();
                dtpNgaySinh.Value = (DateTime)row.Cells[2].Value;
                txtStaffAddress.Text = row.Cells[3].Value.ToString();
                txtStaffPhone.Text = row.Cells[4].Value.ToString();
                txtStaffINumber.Text = row.Cells[5].Value.ToString();
            }
        }

        private bool KiemTraThongTinDauVao()
        {
            if (string.IsNullOrWhiteSpace(txtStaffId.Text) ||
                string.IsNullOrWhiteSpace(txtStaffName.Text) ||
                string.IsNullOrWhiteSpace(txtStaffINumber.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ các thông tin bắt buộc.", "Cảnh báo");
                return false;
            }
            return true;
        }
    }
}
