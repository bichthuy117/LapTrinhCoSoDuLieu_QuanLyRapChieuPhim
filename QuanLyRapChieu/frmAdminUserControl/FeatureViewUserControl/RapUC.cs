using System;
using System.Windows.Forms;
using BUS;

namespace QuanLyRapChieu.frmAdminUserControl.FeatureViewUserControl
{
    public partial class RapUC : UserControl
    {
        // Tạo 1 đối tượng BindingSource để làm trung gian giữa dữ liệu và giao diện
        BindingSource rapList = new BindingSource(); 

        public RapUC()
        {
            InitializeComponent();
        }

        private void RapUC_Load(object sender, EventArgs e)
        {
            dtgvRap.DataSource = rapList; //Gán nguồn dữ liệu cho dtgv là BindingSource
            LoadGrid();
        }

        private void LoadGrid()
        {
            RapBUS.Instance.hienThiRapPhim(rapList);//Gọi phương thức từ BUS để gán dữ liệu danh sách rạp vào BindingSource
            dtgvRap.DataSource = rapList; //Gán lại BindingSource cho dtgv (đảm bảo luôn đúng)
            ClearAndAddBinding();//Thiết lập binding cho các txt
        }

        //Tạo binding giữa txt và nguồn dữ liệu:
        private void AddBinding()
        {
            txtMaRap.DataBindings.Add(new Binding("Text", dtgvRap.DataSource, "MaRap", true, DataSourceUpdateMode.Never));
            txtTenRap.DataBindings.Add(new Binding("Text", dtgvRap.DataSource, "TenRap", true, DataSourceUpdateMode.Never));
        }

        //Xóa binding cũ và gán lại binding mới cho các txt:
        private void ClearAndAddBinding()
        {
            txtMaRap.DataBindings.Clear();
            txtTenRap.DataBindings.Clear();

            txtMaRap.DataBindings.Add(new Binding("Text", dtgvRap.DataSource, "MaRap", true, DataSourceUpdateMode.Never));
            txtTenRap.DataBindings.Add(new Binding("Text", dtgvRap.DataSource, "TenRap", true, DataSourceUpdateMode.Never));
        }

        //Thêm rạp:
        private void btnInsertRap_Click(object sender, EventArgs e)
        {
            //Lấy ttin người dùng nhập vào
            string maRap = txtMaRap.Text.Trim();
            string tenRap = txtTenRap.Text.Trim();

            //Kiểm tra nếu chưa nhập đủ thì tbao
            if (string.IsNullOrEmpty(maRap) || string.IsNullOrEmpty(tenRap))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //Gọi BUS để thêm rạp vào db
            bool success = RapBUS.Instance.themRap(maRap, tenRap);

            if (success)
            {
                MessageBox.Show("Thêm rạp thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Thêm rạp thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //Cập nhật lại danh sách hiển thị
            RapBUS.Instance.hienThiRapPhim(rapList);
            LoadGrid(); //Reload lại data từ db
        }

        //Xóa rạp:
        private void btnDeleteRap_Click(object sender, EventArgs e)
        {

            if (dtgvRap.SelectedCells.Count > 0)
            {
                //Lấy mã rạp từ dòng được chọn
                string maRap = dtgvRap.SelectedCells[0].OwningRow.Cells["MaRap"].Value.ToString();
                //Xác nhận hành động xóa
                DialogResult confirm = MessageBox.Show("Bạn có chắc muốn xóa rạp này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                //Gọi BUS để xóa và kiểm tra kết quả
                bool success = RapBUS.Instance.xoaRap(maRap);

                if (success)
                {
                    MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Xóa thất bại", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }

                RapBUS.Instance.hienThiRapPhim(rapList);
                LoadGrid();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        //Cập nhật rạp:
        private void btnUpdateRap_Click(object sender, EventArgs e)
        {
            string maRap = dtgvRap.SelectedCells[0].OwningRow.Cells["MaRap"].Value.ToString();
            string tenRap = txtTenRap.Text;

            //Kiểm tra dữ liệu hợp lệ
            if (maRap == "" || tenRap == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //Gọi hàm sửa và kiểm tra kết quả
            bool success = RapBUS.Instance.suaRap(maRap, tenRap);

            if (success)
            {
                MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Sửa thất bại", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
            //Load lại dữ liệu mới
            RapBUS.Instance.hienThiRapPhim(rapList);
            LoadGrid();
        }       
    }
}
