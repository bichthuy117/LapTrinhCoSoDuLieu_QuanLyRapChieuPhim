using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyRapChieu.frmAdminUserControl.FeatureViewUserControl
{
    public partial class Cinema : UserControl
    {
        BindingSource cinemaList = new BindingSource();

        public Cinema()
        {
            InitializeComponent();
        }

        void hienThiPhongChieu()
        {
            PhongChieuBUS.Instance.hienThiPhongChieu(cinemaList);
            AddCinemaBinding();
        }
        private void Cinema_Load(object sender, EventArgs e)
        {
            dtgvCinema.DataSource = cinemaList;
            hienThiPhongChieu();
        }

        void AddCinemaBinding()
        {
            // Xóa tất cả liên kết dữ liệu cũ
            txtCinemaID.DataBindings.Clear();
            txtCinemaName.DataBindings.Clear();
            txtCinemaSeats.DataBindings.Clear();
            txtCinemaStatus.DataBindings.Clear();
            txtNumberOfRows.DataBindings.Clear();
            txtSeatsPerRow.DataBindings.Clear();

            // Tạo liên kết dữ liệu mới
            txtCinemaID.DataBindings.Add(new Binding("Text", dtgvCinema.DataSource, "MaPhong", true, DataSourceUpdateMode.Never));
            txtCinemaName.DataBindings.Add(new Binding("Text", dtgvCinema.DataSource, "TenPhong", true, DataSourceUpdateMode.Never));
            txtCinemaSeats.DataBindings.Add(new Binding("Text", dtgvCinema.DataSource, "SoChoNgoi", true, DataSourceUpdateMode.Never));
            txtCinemaStatus.DataBindings.Add(new Binding("Text", dtgvCinema.DataSource, "TinhTrang", true, DataSourceUpdateMode.Never));
            txtNumberOfRows.DataBindings.Add(new Binding("Text", dtgvCinema.DataSource, "SoHangGhe", true, DataSourceUpdateMode.Never));
            txtSeatsPerRow.DataBindings.Add(new Binding("Text", dtgvCinema.DataSource, "SoGheMotHang", true, DataSourceUpdateMode.Never));
        }

        private void btnInsertCinema_Click(object sender, EventArgs e)
        {
            // Kiểm tra đầu vào
            if (string.IsNullOrWhiteSpace(txtCinemaID.Text) || string.IsNullOrWhiteSpace(txtCinemaName.Text) ||
                string.IsNullOrWhiteSpace(txtCinemaSeats.Text) || string.IsNullOrWhiteSpace(txtCinemaStatus.Text) ||
                string.IsNullOrWhiteSpace(txtNumberOfRows.Text) || string.IsNullOrWhiteSpace(txtSeatsPerRow.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Gán biến
            string MaPhong = txtCinemaID.Text;
            string TenPhong = txtCinemaName.Text;
            int SoChoNgoi = Convert.ToInt32(txtCinemaSeats.Text);
            int TinhTrang = Convert.ToInt32(txtCinemaStatus.Text);
            int SoHangGhe = Convert.ToInt32(txtNumberOfRows.Text);
            int SoGheMotHang = Convert.ToInt32(txtSeatsPerRow.Text);

            try
            {
                // Gọi BUS xử lý thêm
                int kq = PhongChieuBUS.Instance.themPhongChieu(MaPhong, TenPhong, SoChoNgoi, TinhTrang, SoHangGhe, SoGheMotHang);
                if (kq > 0)
                {
                    MessageBox.Show("Thêm phòng chiếu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    PhongChieuBUS.Instance.hienThiPhongChieu(cinemaList);   // Load lại danh sách
                    clearCinemaPanel(); // Hàm tự viết để clear input
                }
                else
                {
                    MessageBox.Show("Thêm phòng chiếu thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        // hàm này để reset DL nhập
        private void clearCinemaPanel()
        {
            txtCinemaID.Clear();
            txtCinemaName.Clear();
            txtCinemaSeats.Clear();
            txtCinemaStatus.Clear();
            txtNumberOfRows.Clear();
            txtSeatsPerRow.Clear(); // textbox mới để nhập số ghế mỗi hàng
        }

        private void btnDeleteCinema_Click(object sender, EventArgs e)
        {
            if (dtgvCinema.SelectedCells.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn phòng chiếu cần xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string MaPhong = dtgvCinema.SelectedCells[0].OwningRow.Cells["MaPhong"].Value.ToString();

            DialogResult confirm = MessageBox.Show("Bạn có chắc chắn muốn xóa phòng chiếu này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                int result = PhongChieuBUS.Instance.xoaPhongChieu(MaPhong);
                if (result > 0)
                {
                    MessageBox.Show("Xóa phòng chiếu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    PhongChieuBUS.Instance.hienThiPhongChieu(cinemaList);
                    clearCinemaPanel(); // Gọi hàm clear sau khi xóa
                }
                else
                {
                    MessageBox.Show("Xóa thất bại. Vui lòng kiểm tra lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnUpdateCinema_Click(object sender, EventArgs e)
        {
            // Kiểm tra người dùng đã chọn dòng nào chưa
            if (dtgvCinema.SelectedCells.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn phòng chiếu cần cập nhật.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra dữ liệu đầu vào có đầy đủ không
            if (txtCinemaName.Text == "" || txtCinemaSeats.Text == "" || txtCinemaStatus.Text == "" || txtNumberOfRows.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string MaPhong = dtgvCinema.SelectedCells[0].OwningRow.Cells["MaPhong"].Value.ToString();
                string TenPhong = txtCinemaName.Text;
                int SoChoNgoi = Convert.ToInt32(txtCinemaSeats.Text);
                int TinhTrang = Convert.ToInt32(txtCinemaStatus.Text);
                int SoHangGhe = Convert.ToInt32(txtNumberOfRows.Text);

                // Nếu có txt riêng cho số ghế một hàng, hãy dùng nó. Nếu ko, có thể gán mặc định
                int SoGheMotHang = SoChoNgoi / SoHangGhe;

                int result = PhongChieuBUS.Instance.capNhatPhongChieu(MaPhong, TenPhong, SoChoNgoi, TinhTrang, SoHangGhe, SoGheMotHang);

                if (result > 0)
                {
                    MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    PhongChieuBUS.Instance.hienThiPhongChieu(cinemaList);
                    clearCinemaPanel();
                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại. Vui lòng kiểm tra lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
