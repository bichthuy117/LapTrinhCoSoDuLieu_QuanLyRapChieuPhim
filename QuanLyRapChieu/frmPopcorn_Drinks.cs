using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DTO.ComBoBapNuoc_Chon;

namespace QuanLyRapChieu
{
    public partial class frmPopcorn_Drinks : Form
    {

        private decimal tienVe;
        private decimal diemDaDung;
        private Dictionary<int, TextBox> textBoxSoLuongMap = new Dictionary<int, TextBox>();

        //Constructor có tham số – dùng để truyền tiền vé từ frmTheatre
        public frmTheatre previousForm; //ở đầu class để lưu tham chiếu

        public frmPopcorn_Drinks(decimal tienVeTruyenVao, decimal diemDaDungTruyenVao, frmTheatre prevForm) : this()
        {
            tienVe = tienVeTruyenVao;
            diemDaDung = diemDaDungTruyenVao;
            previousForm = prevForm; // Lưu lại form trước đó

            txtTienVe.Text = tienVe.ToString("N3");
            CapNhatTongTien(); // hiển thị tổng tiền ban đầu (chỉ là tiền vé)
        }

        

        //Constructor mặc định – cấu hình UI và gán map
        public frmPopcorn_Drinks()
        {
            InitializeComponent();

            txtCombo.Text = "0"; // Nếu chưa chọn combo nào

            textBoxSoLuongMap[1] = txtMycombo1;
            textBoxSoLuongMap[2] = txtMycombo2;
            textBoxSoLuongMap[3] = txtSpecialcombo1;
            textBoxSoLuongMap[4] = txtSpecialcombo2;

            foreach (var tb in textBoxSoLuongMap.Values)
                tb.Text = "0"; // reset về 0 khi load
        }

        private void frmPopcorn_Drinks_Load(object sender, EventArgs e)
        {
            LoadCombo();
        }

        List<ComboChon> danhSachComboChon = new List<ComboChon>();




        //Khởi tạo ds ban đầu
        private void LoadCombo()
        {
            var danhSachCombo = ComBoBapNuocBUS.Instance.LayDanhSachCombo();
            foreach (var combo in danhSachCombo)
            {
                danhSachComboChon.Add(new ComboChon
                {
                    MaCombo = combo.MaCombo,
                    TenCombo = combo.TenCombo,
                    Gia = combo.Gia,
                    SoLuong = 0
                });
            }
        }


        //Chạy tăng SL Combo
        private void TangSoLuong(int maCombo)
        {
            var combo = danhSachComboChon.FirstOrDefault(c => c.MaCombo == maCombo);
            if (combo != null)
            {
                combo.SoLuong++;
                CapNhatTienCombo();
                CapNhatTextBoxSoLuong(maCombo, combo.SoLuong);
            }
        }

        //Chạy giảm SL Combo
        private void GiamSoLuong(int maCombo)
        {
            var combo = danhSachComboChon.FirstOrDefault(c => c.MaCombo == maCombo);
            if (combo != null && combo.SoLuong > 0)
            {
                combo.SoLuong--;
                CapNhatTienCombo();
                CapNhatTextBoxSoLuong(maCombo, combo.SoLuong);
            }
        }

        //Cập nhật lại số lượng cb
        private void CapNhatTextBoxSoLuong(int maCombo, int soLuong)
        {
            if (textBoxSoLuongMap.ContainsKey(maCombo))
            {
                textBoxSoLuongMap[maCombo].Text = soLuong.ToString();
            }
        }

        //Hàm cập nhật tổng tiền
        private void CapNhatTongTien()
        {
            var culture = System.Globalization.CultureInfo.InvariantCulture;
            try
            {
                decimal tienCombo = 0;

                if (!string.IsNullOrWhiteSpace(txtCombo.Text))
                {
                    decimal.TryParse(txtCombo.Text, NumberStyles.Number, culture, out tienCombo);
                }

                decimal tong = tienVe + tienCombo;
                txtTongTien.Text = tong.ToString("N3", culture);
            }
            catch
            {
                txtTongTien.Text = tienVe.ToString("N3", culture);
            }

        }


        //Hàm Cập nhật giá tiền Combo
        private void CapNhatTienCombo()
        {
            var culture = System.Globalization.CultureInfo.InvariantCulture;

            decimal tongTien = danhSachComboChon.Sum(c => c.ThanhTien);
            txtCombo.Text = tongTien.ToString("N3", culture);
            CapNhatTongTien();
        }

        //Xử lý Combo1
        private void btnCong1_Click(object sender, EventArgs e)
        {
            TangSoLuong(1); //Mã CB = 1
        }

        private void btnTru1_Click(object sender, EventArgs e)
        {
            GiamSoLuong(1);
        }

        //Xử lý CB2
        private void btnCong2_Click(object sender, EventArgs e)
        {
            TangSoLuong(2);
        }

        private void btnTru2_Click(object sender, EventArgs e)
        {
            GiamSoLuong(2);
        }

        //Xử lý Special CB1
        private void btnCongS1_Click(object sender, EventArgs e)
        {
            TangSoLuong(3);
        }

        private void btnTruS1_Click(object sender, EventArgs e)
        {
            GiamSoLuong(3);
        }


        //Xử lý Special CB2
        private void btnCongS2_Click(object sender, EventArgs e)
        {
            TangSoLuong(4);
        }

        private void btnTruS2_Click(object sender, EventArgs e)
        {
            GiamSoLuong(4);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            decimal tienTong = 0;
            decimal tienCombo = 0;

            if (!decimal.TryParse(txtTongTien.Text, NumberStyles.Number, CultureInfo.InvariantCulture, out tienTong) ||
                !decimal.TryParse(txtCombo.Text, NumberStyles.Number, CultureInfo.InvariantCulture, out tienCombo))
            {
                MessageBox.Show("Tổng tiền không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Lấy danh sách mã ghế từ frmTheatre
            List<string> selectedSeats = previousForm.getUserSelectedSeats();

            // Truyền tiền tổng, tiền vé, tiền combo, và mã ghế sang frmPayment
            frmPayment frm = new frmPayment(tienTong, tienVe, tienCombo, diemDaDung, selectedSeats, this);
            this.Hide();
            frm.ShowDialog();
            this.Show();

            //if (!decimal.TryParse(txtTongTien.Text, NumberStyles.Number, CultureInfo.InvariantCulture, out tienTong))
            //{
            //    MessageBox.Show("Tổng tiền không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}

            //frmPayment frm = new frmPayment(tienTong, this);
            //this.Hide();
            //frm.ShowDialog();
            //this.Show();


        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            // Hiện lại form cũ (frmTheatre)
            if (previousForm != null)
            {
                previousForm.Show();
            }

            // Đóng form hiện tại
            this.Close();
        }
    }
}
