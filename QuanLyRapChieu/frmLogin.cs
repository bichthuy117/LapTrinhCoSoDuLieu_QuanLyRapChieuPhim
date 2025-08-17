using BUS;
using DAO;
using DTO;
//using QuanLyXemPhim.frmAdminUserControl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyRapChieu
{
    public partial class frmLogin : Form
    {
        // Biến để lưu trạng thái ẩn/hiện mật khẩu
        private bool isPasswordVisible = false;

        public frmLogin()
        {
            InitializeComponent();
            this.Load += frmLogin_Load;
        }
        
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userName = txtUsername.Text; //user qly: admin, nvien: NV02
            string password = txtPassword.Text; //pass ply: admin, nvien: admin

            TaiKhoan taiKhoan = TaiKhoanBUS.Instance.xuLyDangNhap(userName, password);

            if (taiKhoan != null)
            {
                // Đăng nhập thành công
                frmDashboard dashboard = new frmDashboard(taiKhoan);
                this.Hide();
                dashboard.ShowDialog();
                this.Show();

                // Xóa thông tin đăng nhập sau khi đóng Dashboard
                txtUsername.Clear();
                txtPassword.Clear();
            }
            else
            {
               
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu của bạn không đúng!", "Lỗi đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                // Có thể xóa mật khẩu để người dùng gõ lại
                txtPassword.Clear();
                txtPassword.Focus();
            }
        }
        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thoát chương trình?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            // Đường dẫn đầy đủ từ thư mục chạy chương trình
            string eyeClosedPath = Path.Combine(Application.StartupPath, "image", "close_eye.png");
            string eyeOpenPath = Path.Combine(Application.StartupPath, "image", "open_eye.png");

            // Kiểm tra xem ảnh có tồn tại không trước khi load
            if (File.Exists(eyeClosedPath))
            {
                this.pnEye.BackgroundImage = Image.FromFile(eyeClosedPath);
                this.pnEye.BackgroundImageLayout = ImageLayout.Zoom;
            }
            else
            {
                MessageBox.Show("Không tìm thấy ảnh eye_closed.png");
            }

        }
        private void pnEye_Click(object sender, EventArgs e)
        {
            string eyeClosedPath = Path.Combine(Application.StartupPath, "image", "close_eye.png");
            string eyeOpenPath = Path.Combine(Application.StartupPath, "image", "open_eye.png");

            if (isPasswordVisible) //show password
            {
                txtPassword.UseSystemPasswordChar = true; //neu dang hien pw

                if (File.Exists(eyeClosedPath))
                {
                    pnEye.BackgroundImage = Image.FromFile(eyeClosedPath); //doi img sang hide pw
                }
                isPasswordVisible = false; //che do an mkhau
            }
            else
            {
                txtPassword.UseSystemPasswordChar = false;
                if (File.Exists(eyeOpenPath))
                {
                    pnEye.BackgroundImage = Image.FromFile(eyeOpenPath);
                }
                isPasswordVisible = true;
            }
        }
    }
}

