using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class TaiKhoanDAO
    {
        private static TaiKhoanDAO instance;
        public static TaiKhoanDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new TaiKhoanDAO(); // nếu chưa có thì tạo mới
                return TaiKhoanDAO.instance; // trả về instance đã tạo
            }
            private set { TaiKhoanDAO.instance = value; } //Không cho bên ngoài gán lại
        }

        public List<TaiKhoan> hienThiTaiKhoan()
        {
            List<TaiKhoan> danhSachTaiKhoan = new List<TaiKhoan>();
            string query = @"USP_hienDanhSachTaiKhoan";
            DataTable table = DataProvider.Instance.ExecuteQuery(query); //Gọi DP kết nối DB, thực hiện câu lệnh lấy DL
            foreach (DataRow row in table.Rows) //duyệt qua từng dòng trong bảng DL
            {                                   //1 dòng đại diện 1 TK
                TaiKhoan taikhoan = new TaiKhoan(row);
                danhSachTaiKhoan.Add(taikhoan);
            }
            return danhSachTaiKhoan;
            
        }

        public TaiKhoan xuLyDangNhap(string userName, string password) //Phương thức kiểm tra xem thông tin TK có tồn tại trong DB không.
        {
            string query = @"USP_dangNhap @userName , @pass ";
            DataTable table = DataProvider.Instance.ExecuteQuery(query, new object[] { userName, password });
            if (table.Rows.Count > 0) //Ktra xem có ít nhất 1 dòng DL trả về không(có TK khớp)
            {
                TaiKhoan taiKhoan = new TaiKhoan(table.Rows[0]);
                return taiKhoan;
            }
            return null;
        }

        public int themDanhSachTaiKhoan(string UserName, string Pass, int LoaiTK, string idNV)
        {
            try
            {
                string query = @"USP_themDanhSachTaiKhoan @UserName , @Pass , @LoaiTK , @idNV ";
                int kq = DataProvider.Instance.ExecuteNonQuery(query, new object[] { UserName, Pass, LoaiTK, idNV });

                return kq; // Trả về số dòng bị ảnh hưởng, thường là 1 nếu thêm thành công
            }
            catch (Exception ex)
            {
                // Ghi log ra console
                Console.WriteLine("Lỗi khi thêm tài khoản: " + ex.Message);
                return 0; // Trả về 0 để biết là có lỗi
            }
        }

        public int suaDanhSachTaiKhoan(string UserName, string Pass, int LoaiTK, string idNV)
        {
            try
            {
                string query = @"USP_suaDanhSachTaiKhoan @UserName , @Pass , @LoaiTK , @idNV";
                int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { UserName, Pass, LoaiTK, idNV });
                return result;
            }
            catch (Exception ex)
            {
                // Ghi log ra file hoặc console để kiểm tra lỗi
                Console.WriteLine("Lỗi khi sửa tài khoản: " + ex.Message);
                return 0;
            }
        }

        public int xoaDanhSachTaiKhoan(string idNV)
        {
            try
            {
                // Kiểm tra không cho xóa tài khoản admin
                string checkQuery = "SELECT COUNT(*) FROM TaiKhoan WHERE idNV = @idNV AND LoaiTK = 1"; // 1 là admin
                object result = DataProvider.Instance.ExecuteScalar(checkQuery, new object[] { idNV });
                int count = Convert.ToInt32(result);

                if (count > 0)
                {
                    return -1; // Tài khoản admin, không được xóa
                }

                // Ghi lịch sử trước khi xóa
                //string logQuery = "INSERT INTO LichSuXoaTaiKhoan (idNV, NgayXoa) VALUES (@idNV, GETDATE())";
                //int logResult = DataProvider.Instance.ExecuteNonQuery(logQuery, new object[] { idNV });

                //if (logResult <= 0)
                //{
                //    return -2; // Ghi log thất bại
                //}


                // Thực hiện xóa
                string query = @"USP_xoaDanhSachTaiKhoan @idNV";
                int kq = DataProvider.Instance.ExecuteNonQuery(query, new object[] { idNV });

                return kq; // >0 nếu xóa thành công
            }
            catch (Exception ex)
            {
                // Có thể log lỗi ex.Message vào file/log table nếu muốn
                return 0; // Xóa thất bại
            }
        }



    }
}
