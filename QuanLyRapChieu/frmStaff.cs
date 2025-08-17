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
using DAO;
using DTO;

namespace QuanLyRapChieu
{
    public partial class frmStaff : Form
    {

        public frmStaff()
        {
            InitializeComponent();
            //hienThiPhimTheoNgay();
            hienThiPhimTheoThang();
        }

        // Sk khi người dùng thay đổi ngày trong dateTimePicker
        private void dtpThoiGian_ValueChanged(object sender, EventArgs e)
        {
            //1. Nhvien lọc được phim trùng đúng ngày được chọn
            //hienThiPhimTheoNgay();

            //2. Nvien xem được tất cả bộ phim trong tháng được chọn
            hienThiPhimTheoThang();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Tự động gọi lại sk Load để cập nhật dữ liệu (tự động reload dữ liệu theo thời gian)
            this.OnLoad(null);
        }

        // Khi form được load (chạy lần đầu)
        private void frmStaff_Load(object sender, EventArgs e)
        {
            timer1.Start();// Bắt đầu chạy timer, giúp dữ liệu luôn được làm mới sau khoảng thời gian nhất định
        }

        // Khi người dùng chọn một tên phim khác trong cbobox
        private void cboFilmName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboFilmName.SelectedIndex != -1)  // Ktranếu người dùng đã chọn một phim
            {
                hienThiDanhSachCaChieuTheoTenPhim();
            }
        }

        private void btn_ChonVe_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem người dùng đã chọn dòng nào trong bảng chưa
            if (dtv_CaChieu.SelectedCells.Count <= 0)
                return;
            // Lấy mã ca chiếu từ dòng được chọn
            string maCaChieu = dtv_CaChieu.SelectedCells[0].OwningRow.Cells["MaCaChieu"].Value.ToString();
            // Mở form chọn ghế (frmTheatre), truyền vào mã ca chiếu tương ứng
            frmTheatre frmTheatre = new frmTheatre(maCaChieu);
            frmTheatre.ShowDialog();
        }
        // Hiển thị ds các phim thỏa điều kiện ngày được người dùng chọn từ datetimepicker
        public void hienThiPhimTheoNgay()
        {
            DateTime date = dtpThoiGian.Value;
            PhimBUS.Instance.hienThiPhimTheoNgay(cboFilmName, date);

        }
        public void hienThiPhimTheoThang()
        {
            DateTime month = dtpThoiGian.Value;
            PhimBUS.Instance.hienThiPhimTheoThang(cboFilmName, month);
        }

        // Hiển thị danh sách ca chiếu ứng với phim được chọn
        public void hienThiDanhSachCaChieuTheoTenPhim()
        {
  
            string tenPhim = cboFilmName.Text;// Lấy tên phim từ ComboBox
            List<CaChieu_Phim> listCaChieu = CaChieu_PhimBUS.Instance.hienThiDanhSachCaChieuTheoTenPhim(tenPhim);
            dtv_CaChieu.DataSource = listCaChieu; // Gán dữ liệu vào dtgv

        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
   
    }
}
