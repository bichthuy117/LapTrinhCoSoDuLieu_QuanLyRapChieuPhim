using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAO;
using BUS;

namespace QuanLyRapChieu.frmAdminUserControl
{
    public partial class CustomerUC : UserControl
    {
        BindingSource customerList = new BindingSource();
        public CustomerUC()
        {
            InitializeComponent();
            LoadCustomer();
        }

        void LoadCustomer()
        {

            DataTable dt = CustomerBUS.Instance.getListCustomer();
            if (dt == null)
            {
                MessageBox.Show("Error when load data");
            }
            else
            {
                dtgvCustomer.DataSource = dt;
            }

        }

        private void dtgvCustomer_SelectionChanged(object sender, EventArgs e)
        {

            foreach (DataGridViewRow row in dtgvCustomer.SelectedRows)
            {
                txtCusId.Text = row.Cells[0].Value.ToString();
                txtCusName.Text = row.Cells[1].Value.ToString();
                txtAddress.Text = row.Cells[2].Value.ToString();
                numericUpDownNamSinh.Text = row.Cells[3].Value.ToString();
                txtCusPhone.Text = row.Cells[4].Value.ToString();
                nudPoint.Value = (int)row.Cells[5].Value;
            }
        }
        private void clearCustomerInfoPanel()
        {
            txtCusName.Clear();
            txtAddress.Clear();
            txtCusPhone.Clear();
            nudPoint.Value = 0;
            txtCusId.Clear();
        }
        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            // Kiểm tra dữ liệu đầu vào
            if (string.IsNullOrWhiteSpace(txtCusName.Text) ||
                string.IsNullOrWhiteSpace(txtCusPhone.Text) ||
                string.IsNullOrWhiteSpace(txtAddress.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Lấy dữ liệu từ giao diện
            string name = txtCusName.Text.Trim();
            int birth = (int)numericUpDownNamSinh.Value;
            string phoneNumber = txtCusPhone.Text.Trim();
            int point = (int)nudPoint.Value;
            string address = txtAddress.Text.Trim();

            // Gọi xử lý thêm khách hàng
            bool result = CustomerBUS.Instance.addCustomer(name, birth, phoneNumber, point, address);

            if (result)
            {
                MessageBox.Show("Thêm khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadCustomer();
                clearCustomerInfoPanel();
            }
            else
            {
                MessageBox.Show("Thêm khách hàng thất bại. Vui lòng kiểm tra lại dữ liệu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            //check xem đã chọn KH chưa
            if (string.IsNullOrWhiteSpace(txtCusId.Text))
            {
                MessageBox.Show("Vui lòng chọn khách hàng cần xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //check mã KH có phù hợp?
            if (!int.TryParse(txtCusId.Text, out int customerId))
            {
                MessageBox.Show("Mã khách hàng không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Tiến hành xử lý Xóa
            DialogResult confirm = MessageBox.Show("Bạn có chắc muốn xóa khách hàng này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                int result = CustomerBUS.Instance.deleteCustomer(customerId);
                if (result > 0)
                {
                    MessageBox.Show("Xóa khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadCustomer();
                    clearCustomerInfoPanel();
                }
                else
                {
                    MessageBox.Show("Xóa khách hàng thất bại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnUpdateCustomer_Click(object sender, EventArgs e)
        {
            if (txtCusId.Text == "")
            {
                MessageBox.Show("Vui lòng chọn khách hàng cần cập nhật!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                int id = int.Parse(txtCusId.Text);
                string name = txtCusName.Text.Trim();
                string address = txtAddress.Text.Trim();
                int birth = (int)numericUpDownNamSinh.Value;
                string phone = txtCusPhone.Text.Trim();
                int point = (int)nudPoint.Value;

                // Kiểm tra dữ liệu đầu vào
                if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(address) || string.IsNullOrEmpty(phone))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int result = CustomerBUS.Instance.updateCustomerBUS(id, name, address, birth, phone, point);
                if (result > 0)
                {
                    MessageBox.Show("Cập nhật khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadCustomer();
                    clearCustomerInfoPanel();
                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại. Vui lòng thử lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Dữ liệu nhập không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
