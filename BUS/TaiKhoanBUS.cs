using System.Windows.Forms;
using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace BUS
{
    public class TaiKhoanBUS
    {
        private static TaiKhoanBUS instance;

        public static TaiKhoanBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new TaiKhoanBUS(); // nếu chưa có thì tạo mới
                return TaiKhoanBUS.instance; // trả về instance đã tạo
            }
            private set { TaiKhoanBUS.instance = value; } //Không cho bên ngoài gán lại
        }

        public TaiKhoan xuLyDangNhap(string userName, string password)
        {
            return (TaiKhoanDAO.Instance.xuLyDangNhap(userName, password));

        }

        public void hienThiTaiKhoan(BindingSource accountList)
        {
            accountList.DataSource = TaiKhoanDAO.Instance.hienThiTaiKhoan();
        }

        public int themDanhSachTaiKhoan(string UserName, string Pass, int LoaiTK, string idNV)
        {
            return TaiKhoanDAO.Instance.themDanhSachTaiKhoan(UserName, Pass, LoaiTK, idNV);
        }

        public int suaDanhSachTaiKhoan(string UserName, string Pass, int LoaiTK, string idNV)
        {
            return TaiKhoanDAO.Instance.suaDanhSachTaiKhoan(UserName, Pass, LoaiTK, idNV);
        }

        public int xoaDanhSachTaiKhoan(string idNV)
        {
            // Gọi hàm xóa ở DAO và trả về kết quả cho lớp giao diện xử lý
            return TaiKhoanDAO.Instance.xoaDanhSachTaiKhoan(idNV);
        }


    }
}
