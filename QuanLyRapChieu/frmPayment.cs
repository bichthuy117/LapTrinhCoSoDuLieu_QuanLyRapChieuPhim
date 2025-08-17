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

namespace QuanLyRapChieu
{
    public partial class frmPayment : Form
    {

        private decimal tienTong;
        private decimal tienVe;
        private decimal tienCombo;
        private decimal diemDaDung;
        private List<string> selectedSeats;
        private frmPopcorn_Drinks previousForm;

        public frmPayment(decimal tienTong, decimal tienVe, decimal tienCombo, decimal diemDaDung, List<string> selectedSeats, frmPopcorn_Drinks prevForm)
        {
            InitializeComponent();
            this.tienTong = tienTong;
            this.tienVe = tienVe;
            this.tienCombo = tienCombo;
            this.diemDaDung = diemDaDung;
            this.selectedSeats = selectedSeats;
            this.previousForm = prevForm;

            // Hiển thị tổng tiền
            txtTongTien.Text = tienTong.ToString("N3", CultureInfo.InvariantCulture);
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            // Sử dụng diemDaDung đã được truyền từ constructor
            string thongBao = "Đặt vé thành công!\n\n";
            thongBao += $"💰 Tổng tiền: {tienTong.ToString("N3", CultureInfo.InvariantCulture)}\n";
            thongBao += $"💰 Tiền vé: {tienVe.ToString("N3", CultureInfo.InvariantCulture)}\n";
            thongBao += $"💰 Tiền combo: {tienCombo.ToString("N3", CultureInfo.InvariantCulture)}\n";
            thongBao += $"🎁 Điểm đã dùng: {diemDaDung.ToString("N0", CultureInfo.InvariantCulture)}\n";
            thongBao += "💺 Mã ghế: " + (selectedSeats.Any() ? string.Join(", ", selectedSeats) : "Không có ghế nào được chọn");

            MessageBox.Show(thongBao, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Đóng tất cả các form sau khi thanh toán thành công
            if (previousForm != null)
            {
                if (previousForm.previousForm != null)
                {
                    previousForm.previousForm.Close();
                }
                previousForm.Close();
            }
            this.Close();
        }

        private void btnBack2_Click(object sender, EventArgs e)
        {
            if (previousForm != null)
            {
                previousForm.Show();
            }
            this.Close();
        }

        
    }
}
