using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;
using System.Text.RegularExpressions;
using System.Globalization;

/*Mot so thay doi:
 txtPayment -> txtRefund
 */
namespace QuanLyRapChieu
{
    public partial class frmTheatre : Form
    {
        private string maCaChieu;
        private static List<Ve> maVe = new List<Ve>();
        private static decimal totalPrice = 0;
        private static int bonus = 0;
        

        // Dùng từ điển để lưu lại tất cả ghế đã tạo, key là mã ghế, value là Button tương ứng
        private Dictionary<string, Button> danhSachGhe = new Dictionary<string, Button>();
    

        public frmTheatre(string maCaChieu)
        {
            InitializeComponent();
            this.maCaChieu = maCaChieu;
        }

        private void chkCustomer_CheckedChanged(object sender, EventArgs e)
        {
            frmCustomer frmCustomer = new frmCustomer(this);
            frmCustomer.ShowDialog();
        }

        public void hienThiDanhSachChoNgoiTheoMaCaChieu(string maCaChieu)
        {
            flpSeat.Controls.Clear();
            flpSeat.Visible = true;
            flpSeat.BringToFront();
            flpSeat.FlowDirection = FlowDirection.TopDown;
            flpSeat.WrapContents = false;
            flpSeat.AutoScroll = true;

            // Tạo danh sách các hàng ghế
            Dictionary<string, FlowLayoutPanel> hangGhePanels = new Dictionary<string, FlowLayoutPanel>();
            List<Ve> danhSachVe = VeBUS.Instance.hienthiVe(maCaChieu);

            if (danhSachVe != null)
            {
                foreach (Ve ve in danhSachVe)
                {
                    // Lấy tên hàng (ví dụ: "A" từ "A-0")
                    string hang = ve.MaGheNgoi.Split('-')[0];

                    // Nếu chưa có panel cho hàng này, tạo mới và thêm vào flpSeat
                    if (!hangGhePanels.ContainsKey(hang))
                    {
                        FlowLayoutPanel hangPanel = new FlowLayoutPanel();
                        hangPanel.FlowDirection = FlowDirection.LeftToRight;
                        hangPanel.WrapContents = false;
                        hangPanel.Height = 80;
                        hangPanel.AutoSize = true;

                        Label lblHang = new Label();
                        lblHang.Text = hang;
                        lblHang.Width = 30;
                        lblHang.TextAlign = ContentAlignment.MiddleCenter;
                        lblHang.Font = new Font("Arial", 10, FontStyle.Bold);

                        hangPanel.Controls.Add(lblHang);
                        hangGhePanels[hang] = hangPanel;
                        flpSeat.Controls.Add(hangPanel);
                    }

                    // Tạo nút ghế
                    Button btn = new Button()
                    {
                        Width = 80,
                        Height = 30,
                        Text = ve.MaGheNgoi,
                        Font = new Font("Arial", 10.5f),
                        TextAlign = ContentAlignment.MiddleCenter,  
                        Margin = new Padding(10) // khoảng cách giữa các ghế
                    };
                    btn.Click += btnSeat_Click;
                    btn.Tag = ve;

                    if (ve.TrangThai == 0)
                    {
                        btn.BackColor = Color.LightGray; // ghế trống
                    }
                    else // Ghế đã có người ngồi (đã đặt)
                    {
                        btn.Enabled = false;
                        btn.BackColor = Color.Gray; // ghế được đặt: xám đậm
                        btn.ForeColor = Color.White;
                    }
                    //them ghe vao dictionary de truy cap sau nay
                    danhSachGhe[ve.MaGheNgoi] = btn;
                    // Thêm ghế vào panel tương ứng với hàng
                    hangGhePanels[hang].Controls.Add(btn);
                }
            }

        }
        private void TinhToanSoTienCanTra()
        {
            decimal tongTien = totalPrice;
            decimal soTienGiam = 0;
            var culture = System.Globalization.CultureInfo.InvariantCulture;

            // Ktra nếu có thông tin KH và đã dùng điểm (txtDiscount đã có giá trị)
            if (!string.IsNullOrEmpty(txtCustomerName.Text) &&
                !string.IsNullOrEmpty(frmCustomer.phoneNumber) &&
                !string.IsNullOrEmpty(txtDiscount.Text))
            {
                decimal.TryParse(txtDiscount.Text, System.Globalization.NumberStyles.Number, culture, out soTienGiam);
            }
            //case k sudung diem tich luy
            decimal soTienCanTra = Math.Max(tongTien - soTienGiam, 0);
            txtRefund.Text = soTienCanTra.ToString("N3", culture);
        }

         

        // Xử lý khi click vào ghế: Đổi màu ghế + Ktra loại vé + Tinh gia ve
        private void btnSeat_Click(object sender, EventArgs e)
        {
            Color mauGheDangChon = Color.CornflowerBlue;
            Color mauGheTrong = Color.LightGray;

            Button btn = (sender as Button);
            Ve ve = (btn.Tag as Ve);

            decimal soTienCanTra = totalPrice;

            if (ve.LoaiVe != 0)
            {
                ve.LoaiVe = 0;
            }
            else
            {
                if (rdoAdult.Checked)
                {
                    ve.LoaiVe = 1;
                    ve.TienBanVe = 1 * getSingleTicketPrice(this.maCaChieu);
                }
                else if (rdoChild.Checked)
                {
                    ve.LoaiVe = 2;
                    ve.TienBanVe = 0.5m * getSingleTicketPrice(this.maCaChieu);
                }
                else if (rdoStudent.Checked)
                {
                    ve.LoaiVe = 3;
                    ve.TienBanVe = 0.75m * getSingleTicketPrice(this.maCaChieu);
                }
                else if (rdoFree.Checked)
                {
                    ve.LoaiVe = 4;
                    ve.TienBanVe = 0m * getSingleTicketPrice(this.maCaChieu);
                }

            }

            if (btn.BackColor == mauGheDangChon) //neu ghe dang duoc chon
            {
                btn.BackColor = mauGheTrong; //tra lai ghe trang thai mau ghe trong
                maVe.Remove(ve);//chuyen lai mau ghe trong
                totalPrice -= ve.TienBanVe; //xoa ve khoi dsach da chon
                bonus--; //giam tong tien do bỏ chọn ghế
            }
            else //neu ghe chua duoc chon
            {
                btn.BackColor = mauGheDangChon;  //tra lai ghe trang thai GHE DANG CHON
                maVe.Add(ve);
                totalPrice += ve.TienBanVe;
                bonus++;
            }
            // Khi click ghe ngoi bat ki, thuc hien tinh toan: 
            txtTotal.Text = (totalPrice).ToString("N3", CultureInfo.InvariantCulture); //NO format 90 -> 90,000
            TinhToanSoTienCanTra();

        }


        // lấy giá của một vé theo ca chiếu
        private decimal getSingleTicketPrice(string maCaChieu)
        {
            return Convert.ToDecimal(VeBUS.Instance.getPriceOfTicketBUS(maCaChieu));
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (txtPoint.Text != "" && txtPoint.Text != null)
            {
                CustomerBUS.Instance.rollbackPoint(Int32.Parse(txtPoint.Text), frmCustomer.phoneNumber);
            }

            flpSeat.Controls.Clear();
            hienThiDanhSachChoNgoiTheoMaCaChieu(this.maCaChieu);
            maVe.Clear();
            totalPrice = 0;
       
            bonus = 0;
            resetPanels();

            DialogResult result = MessageBox.Show("Bạn có chắc muốn hủy vé không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                MessageBox.Show("Vé đã được hủy.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void resetPanels()
        {
            txtTotal.ResetText();
            txtCustomerName.ResetText();
            txtPoint.ResetText();
            numBonusPoint.Value = numBonusPoint.Minimum;
            txtDiscount.ResetText();
            txtRefund.ResetText();
            btnUsePoint.Enabled = true;
        }


        public void loadDataCustomer()
        {
            if (frmCustomer.phoneNumber != "")
            {
                DataTable customer = CustomerBUS.Instance.getCustomer(frmCustomer.phoneNumber.Trim());
                if (customer != null)
                {
                    DataRow row = customer.Rows[0];
                    txtCustomerName.Text = row["TenKhachHang"].ToString();
                    txtPoint.Text = row["DiemTichLuy"].ToString();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy thông tin khách hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
        }

        private void frmTheatre_FormClosing(object sender, FormClosingEventArgs e)
        {
            resetPanels();
            maVe.Clear();  
            DialogResult result = MessageBox.Show("Bạn có chắc muốn thoát không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                e.Cancel = true; // Ngăn không cho form đóng
            }
        }

        private void updatePoint(string phoneNumber, int bonus)
        {
            if (!string.IsNullOrEmpty(txtCustomerName.Text))
            {
                updatePoint(frmCustomer.phoneNumber.Trim(), Convert.ToInt32(numBonusPoint.Value));
            }
            else if (!CustomerBUS.Instance.updatePointBUS(phoneNumber, bonus))
            {
                MessageBox.Show("Cập nhật điểm không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnUsePoint_Click(object sender, EventArgs e)
        {
            // Nếu khg có th.tin khách hàng
            if (string.IsNullOrWhiteSpace(txtCustomerName.Text) ||
                string.IsNullOrWhiteSpace(frmCustomer.phoneNumber))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin khách hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Check: nếu k có điểm để sử dụng
            if (string.IsNullOrWhiteSpace(txtPoint.Text))
            {
                // thì kh có giảm giá
                txtDiscount.Text = "0";
                txtRefund.Text = txtTotal.Text;  

            }

            // Ktra đkiện sử dụng điểm
            if (CustomerBUS.Instance.usePointBUS(frmCustomer.phoneNumber))
            {
                // Cập nhật số điểm giảm giá
                int diem = int.Parse(txtPoint.Text);
                int soTienGiam = diem;

                txtDiscount.Text = soTienGiam.ToString("N3", System.Globalization.CultureInfo.InvariantCulture);
                TinhToanSoTienCanTra();  //txtRefund

                MessageBox.Show("Sử dụng điểm thành công! Nhân viên vui lòng tiến hành đổi điểm cho khách.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Không thể sử dụng điểm. Vui lòng kiểm tra lại thông tin khách hàng hoặc trạng thái điểm!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }


        private void frmTheatre_Load(object sender, EventArgs e)
        {
            //MessageBox.Show(flpSeat.Parent.Name); // Xem flpSeat nằm trong đâu
            hienThiDanhSachChoNgoiTheoMaCaChieu(this.maCaChieu);
            hienThiThongTinCaChieu(maCaChieu);
        }

        private void hienThiThongTinCaChieu(string maCaChieu)
        {
            ChiTietCaChieu ct = CaChieuBUS.Instance.LayChiTietCaChieu(maCaChieu);
            if (ct == null)
                return;
            lblInformation.Text = string.Format("Ca chiếu : {0}, Phim : {1}, Phòng : {2}, Rạp : {3} ", ct.MaCaChieu, ct.TenPhim, ct.TenPhong, ct.TenRap);
            lblTime.Text = string.Format("Từ Giờ : {0:HH:mm}, đến Giờ : {1:HH:mm} ", ct.ThoiGianChieu, ct.ThoiGianKetThuc);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (maVe.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn vé trước khi tiếp tục thao tác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (VeBUS.Instance.updateListTicket(maVe))
            {

                string maKH = "";

                DataTable customer = CustomerBUS.Instance.getCustomer(frmCustomer.phoneNumber.Trim());
                if (customer != null)
                {
                    if(customer.Rows.Count > 0)
                    {
                        DataRow row = customer.Rows[0];
                        maKH = row["maKH"].ToString();
                    }
                    //khachhang = KhachHang(row);
                    //txtPoint.Text = row["DiemTichLuy"].ToString();
                }


                // ⭐ LẤY GIÁ TIỀN VÉ từ txtRefund và truyền sang frmPopcorn_Drinks ⭐

                decimal tienVe = decimal.Parse(txtRefund.Text.Trim(), CultureInfo.InvariantCulture);
                decimal diemDaDung = 0;

                if (!string.IsNullOrWhiteSpace(txtDiscount.Text))
                {
                    decimal.TryParse(txtDiscount.Text, NumberStyles.Number, CultureInfo.InvariantCulture, out diemDaDung);
                }
                //Chỉ ẩn form chứ không đóng, và chờ frmPopcorn_Drinks đóng lại
                frmPopcorn_Drinks frm = new frmPopcorn_Drinks(tienVe, diemDaDung, this);
                this.Hide(); // Ẩn frmTheatre
                frm.ShowDialog(); // Đợi người dùng đặt xong combo hoặc quay lại
                this.Show(); // Hiện lại frmTheatre

            }
            else
            {
                MessageBox.Show("Đặt vé thất bại. Vui lòng kiểm tra lại thông tin và thử lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
             
            }
        }
        public List<string> getUserSelectedSeats()
        {
            Color maugheDangChon = Color.CornflowerBlue;
            List<string> selectedSeats = new List<string>();

            foreach (var pair in danhSachGhe)
            {
                string maGhe = pair.Key;
                Button btn = pair.Value;

                if (btn.BackColor == maugheDangChon)
                {
                    selectedSeats.Add(maGhe.Trim());
                }
            }

            return selectedSeats;
        }

    }

}
