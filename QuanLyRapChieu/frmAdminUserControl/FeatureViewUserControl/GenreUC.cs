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
    public partial class GenreUC : UserControl
    {
        BindingSource genreList = new BindingSource();
        public GenreUC()
        {
            InitializeComponent();
        }

        void LoadGenre()
        {
            TheLoaiBUS.Instance.hienThiTheLoaiPhim(genreList);
            AddGenreBinding();
        }

        //liên kết DL giữa (dtgvGenre) và (txtGenreID, txtGenreName)
        void AddGenreBinding()
        {
            // Xóa tất cả liên kết dữ liệu cũ
            txtGenreID.DataBindings.Clear();
            txtGenreName.DataBindings.Clear();

            // Tạo liên kết dữ liệu mới
            txtGenreID.DataBindings.Add(new Binding("Text", dtgvGenre.DataSource, "MaLoaiPhim", true, DataSourceUpdateMode.Never));
            txtGenreName.DataBindings.Add(new Binding("Text", dtgvGenre.DataSource, "TenTheLoai", true, DataSourceUpdateMode.Never));
        }

        private void GenreUC_Load(object sender, EventArgs e)
        {
            dtgvGenre.DataSource = genreList;
            LoadGenre();
        }

        private void btnInsertGenre_Click(object sender, EventArgs e)
        {
            string MaLoaiPhim = txtGenreID.Text.Trim();
            string TenTheLoai = txtGenreName.Text.Trim();

            // Kiểm tra đầu vào
            if (string.IsNullOrEmpty(MaLoaiPhim) || string.IsNullOrEmpty(TenTheLoai))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin thể loại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                int result = TheLoaiBUS.Instance.themTheLoai(MaLoaiPhim, TenTheLoai);
                if (result > 0)
                {
                    MessageBox.Show("Thêm thể loại phim thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TheLoaiBUS.Instance.hienThiTheLoaiPhim(genreList);
                    clearGenrePanel(); // Hàm này để xóa txt
                }
                else
                {
                    MessageBox.Show("Thêm thể loại thất bại. Vui lòng thử lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeleteGenre_Click(object sender, EventArgs e)
        {
            //ktra xem đã chọn dòng xóa chưa?
            if (dtgvGenre.SelectedCells.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn thể loại cần xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string maLoaiPhim = dtgvGenre.SelectedCells[0].OwningRow.Cells["MaLoaiPhim"].Value.ToString();

            //ktra có chắc chắn xóa?
            DialogResult confirm = MessageBox.Show("Bạn có chắc muốn xóa thể loại này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                int result = TheLoaiBUS.Instance.xoaTheLoai(maLoaiPhim);

                if (result > 0)
                {
                    MessageBox.Show("Xóa thể loại thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TheLoaiBUS.Instance.hienThiTheLoaiPhim(genreList);
                }
                else
                {
                    MessageBox.Show("Xóa thất bại. Vui lòng kiểm tra lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnUpdateGenre_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có dòng nào được chọn chưa
            if (dtgvGenre.SelectedCells.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn thể loại cần cập nhật.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string maLoaiPhim = dtgvGenre.SelectedCells[0].OwningRow.Cells["MaLoaiPhim"].Value.ToString();
            string tenTheLoai = txtGenreName.Text.Trim();

            if (string.IsNullOrEmpty(tenTheLoai))
            {
                MessageBox.Show("Vui lòng nhập tên thể loại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirm = MessageBox.Show("Bạn có chắc muốn cập nhật thông tin thể loại này?",
                                                    "Xác nhận cập nhật",
                                                    MessageBoxButtons.YesNo,
                                                    MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                int result = TheLoaiBUS.Instance.suaTheLoai(maLoaiPhim, tenTheLoai);

                if (result > 0)
                {
                    MessageBox.Show("Cập nhật thể loại thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TheLoaiBUS.Instance.hienThiTheLoaiPhim(genreList);
                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại. Vui lòng kiểm tra lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        //hàm xóa txt sau khi đã thêm
        private void clearGenrePanel()
        {
            txtGenreID.Text = "";
            txtGenreName.Text = "";
        }

        
    }
}
