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
using DAO;


namespace QuanLyRapChieu.frmAdminUserControl.FeatureViewUserControl
{
    public partial class MovieUC : UserControl
    {
        BindingSource movieList = new BindingSource();

        public MovieUC()
        {
            InitializeComponent();
        }

        private void btnAddMovie_Click(object sender, EventArgs e)
        {
            //Lấy dữ liệu từ các control trên form
            string MaPhim = txtMovieID.Text;
            string TenPhim = txtMovieName.Text;
            string MoTa = txtMovieDesc.Text;
            double ThoiLuong = Convert.ToDouble(txtMovieLength.Text);
            DateTime NgayBatDau = dtmMovieStart.Value;
            DateTime NgayKetThuc = dtmMovieEnd.Value;
            string QuocGia = txtMovieCountry.Text;
            string DienVien = txtMovieActor.Text;
            int NamSX = Convert.ToInt32(numericUpDownPhim.Value);
            int GioiHanTuoi = Convert.ToInt32(txtMovieYearLimit.Text);

            // Gọi lớp BUS để thêm phim
            bool success = PhimBUS.Instance.themDanhSachPhim(MaPhim, TenPhim, MoTa, ThoiLuong, NgayBatDau,
                NgayKetThuc, QuocGia, DienVien, NamSX, GioiHanTuoi);

            if (success)
                MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Thêm thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

            // Reload lại ds phim
            PhimBUS.Instance.hienThiPhim(movieList);
        }

        bool formLoad;

        // Load dữ liệu vào lưới và binding dữ liệu
        private void LoadGrid()
        {
            PhimBUS.Instance.hienThiPhim(movieList);
            ClearAndAddBinding();
        }

        public void bindingMovie() // Binding dữ liệu từ dtgv lên các control
        {

            ClearAndAddBinding(); // Gọi(Xóa) biding cũ trước để tránh lỗi khi Add binding mới

            txtMovieID.DataBindings.Add(new Binding("Text", dtgvMovie.DataSource, "MaPhim", true, DataSourceUpdateMode.Never));
            txtMovieName.DataBindings.Add(new Binding("Text", dtgvMovie.DataSource, "TenPhim", true, DataSourceUpdateMode.Never));
            txtMovieDesc.DataBindings.Add(new Binding("Text", dtgvMovie.DataSource, "MoTa", true, DataSourceUpdateMode.Never));
            txtMovieLength.DataBindings.Add(new Binding("Text", dtgvMovie.DataSource, "ThoiLuong", true, DataSourceUpdateMode.Never));
            dtmMovieStart.DataBindings.Add(new Binding("Value", dtgvMovie.DataSource, "NgayKhoiChieu", true, DataSourceUpdateMode.Never));
            dtmMovieEnd.DataBindings.Add(new Binding("Value", dtgvMovie.DataSource, "NgayKetThuc", true, DataSourceUpdateMode.Never));
            txtMovieCountry.DataBindings.Add(new Binding("Text", dtgvMovie.DataSource, "QuocGia", true, DataSourceUpdateMode.Never));
            txtMovieActor.DataBindings.Add(new Binding("Text", dtgvMovie.DataSource, "DaoDien", true, DataSourceUpdateMode.Never));
            txtMovieYearLimit.DataBindings.Add(new Binding("Text", dtgvMovie.DataSource, "GioiHanTuoi", true, DataSourceUpdateMode.Never));
            numericUpDownPhim.DataBindings.Add(new Binding("Value", dtgvMovie.DataSource, "NamSX", true, DataSourceUpdateMode.Never));

            // Load thể loại vào checkedListBox
            clbMovieGenre.SuspendLayout();
            LoadGenreIntoCheckedList(clbMovieGenre);
            clbMovieGenre.ResumeLayout();
        }
        private void ClearAndAddBinding()// Xóa các binding hiện tại
        {
            txtMovieID.DataBindings.Clear();
            txtMovieName.DataBindings.Clear();
            txtMovieDesc.DataBindings.Clear();
            txtMovieLength.DataBindings.Clear();
            dtmMovieStart.DataBindings.Clear();
            dtmMovieEnd.DataBindings.Clear();
            txtMovieCountry.DataBindings.Clear();
            txtMovieActor.DataBindings.Clear();
            txtMovieYearLimit.DataBindings.Clear();
            numericUpDownPhim.DataBindings.Clear();

        }


        public void hienThiDanhSachPhim()
        {

            PhimBUS.Instance.hienThiPhim(movieList);
            bindingMovie();
        }

        // Khi text của txtMovieID thay đổi → thể loại đã chọn sẽ đc update
        private void txtMovieID_TextChanged(object sender, EventArgs e)
        //Use to binding the CheckedListBox the loai phim
        {
            if (formLoad)
                return;

            for (int i = 0; i < clbMovieGenre.Items.Count; i++)
            {
                clbMovieGenre.SetItemChecked(i, false);
                //Uncheck all CheckBox first
            }
            // Lấy danh sách thể loại của phim hiện tại
            List<TheLoai> listGenreOfMovie = TheLoaiDAO.layDanhSachTheLoaiBoPhimID(txtMovieID.Text);
            // So sánh và check lại các thể loại tương ứng
            for (int i = 0; i < clbMovieGenre.Items.Count; i++)
            {
                TheLoai theLoai = (TheLoai)clbMovieGenre.Items[i];
                foreach (TheLoai item in listGenreOfMovie)
                {
                    if (theLoai.MaLoaiPhim == item.MaLoaiPhim)
                    {
                        clbMovieGenre.SetItemChecked(i, true);
                        break;
                    }
                }
            }
            // Lấy thông tin chi tiết phim (nếu có)
            Phim movie = PhimDAO.layMaPhim(txtMovieID.Text);
            if (movie == null)
                return;

        }

        private void btnUpdateMovie_Click(object sender, EventArgs e)
        {
            string MaPhim = dtgvMovie.SelectedCells[0].OwningRow.Cells["MaPhim"].Value.ToString();
            string TenPhim = txtMovieName.Text;
            string MoTa = txtMovieDesc.Text;
            double ThoiLuong = Convert.ToDouble(txtMovieLength.Text);
            DateTime NgayBatDau = dtmMovieStart.Value;
            DateTime NgayKetThuc = dtmMovieEnd.Value;
            string QuocGia = txtMovieCountry.Text;
            string DienVien = txtMovieActor.Text;
            int NamSX = Convert.ToInt32(numericUpDownPhim.Value);
            int GioiHanTuoi = Convert.ToInt32(txtMovieYearLimit.Text);

            // Gọi BUS để cập nhật
            bool success = PhimBUS.Instance.suaDanhSachPhim(MaPhim, TenPhim, MoTa, ThoiLuong, NgayBatDau,
                NgayKetThuc, QuocGia, DienVien, NamSX, GioiHanTuoi);

            if (success)
                MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Sửa thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

            PhimBUS.Instance.hienThiPhim(movieList);
        }

        private void btnDeleteMovie_Click(object sender, EventArgs e)
        {
            string MaPhim = dtgvMovie.SelectedCells[0].OwningRow.Cells["MaPhim"].Value.ToString();

            bool success = PhimBUS.Instance.xoaDanhSachPhim(MaPhim);

            if (success)
                MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Xóa thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

            PhimBUS.Instance.hienThiPhim(movieList);

        }
        void LoadGenreIntoCheckedList(CheckedListBox checkedList)  // Load thể loại vào checkedListBox
        {
            try
            {
                checkedList.DataSource = null;
                List<TheLoai> theloaiList = TheLoaiDAO.Instance.hienThiTheLoaiPhim();
                checkedList.DataSource = theloaiList;
                checkedList.DisplayMember = "TenTheLoai";
                checkedList.ValueMember = "MaTheLoai";
            }
            catch (Exception ex) { 
                Console.WriteLine("Lỗi khi load thể loại phim!" + ex.Message);
            }
        }


        private void MovieUC_Load(object sender, EventArgs e)
        {
            formLoad = true;
            dtgvMovie.DataSource = movieList;
            hienThiDanhSachPhim();
            formLoad = false;

        }

        private void clbMovieGenre_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        
    }
}
