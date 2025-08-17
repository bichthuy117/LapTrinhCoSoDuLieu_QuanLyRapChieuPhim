using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class PhongChieuDAO
    {
        private static PhongChieuDAO instance;
        public static PhongChieuDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new PhongChieuDAO(); // nếu chưa có thì tạo mới
                return PhongChieuDAO.instance; // trả về instance đã tạo
            }
            private set { PhongChieuDAO.instance = value; } //Không cho bên ngoài gán lại
        }

        public List<PhongChieu> hienThiPhongChieu()
        {
            List<PhongChieu> danhSachPhongChieu = new List<PhongChieu>();
            string query = @"USP_layDanhSachPhongChieu";
            DataTable table = DataProvider.Instance.ExecuteQuery(query); //Gọi DP kết nối DB, thực hiện câu lệnh lấy DL
            foreach (DataRow row in table.Rows) //duyệt qua từng dòng trong bảng DL
            {                                   //1 dòng đại diện 1 phòng chiếu
                PhongChieu phongChieu = new PhongChieu(row);
                danhSachPhongChieu.Add(phongChieu);
            }
            return danhSachPhongChieu;

        }

        public int themPhongChieu(string MaPhong, string TenPhong, int SoChoNgoi, int TinhTrang, int SoHangGhe, int SoGheMotHang)
        {
            try
            {
                string query = @"USP_themPhongChieu @MaPhong , @TenPhong , @SoChoNgoi , @TinhTrang , @SoHangGhe , @SoGheMotHang ";
                int kq = DataProvider.Instance.ExecuteNonQuery(query, new object[] { MaPhong, TenPhong, SoChoNgoi, TinhTrang, SoHangGhe, SoGheMotHang });

                return kq; // Trả về số dòng bị ảnh hưởng, thường là 1 nếu thêm thành công
            }
            catch (Exception ex)
            {
                // Ghi log ra console
                Console.WriteLine("Lỗi khi thêm phòng chiếu: " + ex.Message);
                return 0; // Trả về 0 để biết là có lỗi
            }
        }

        public int xoaPhongChieu(string MaPhong)
        {
            try
            {
                string query = @"USP_xoaPhongChieu @MaPhong ";
                int kq = DataProvider.Instance.ExecuteNonQuery(query, new object[] { MaPhong});

                return kq; // Trả về số dòng bị ảnh hưởng, thường là 1 nếu thêm thành công
            }
            catch (Exception ex)
            {
                // Ghi log ra console
                Console.WriteLine("Lỗi khi xóa phòng chiếu: " + ex.Message);
                return 0; // Trả về 0 để biết là có lỗi
            }
        }

        public int suaPhongChieu(string MaPhong, string TenPhong, int SoChoNgoi, int TinhTrang, int SoHangGhe, int SoGheMotHang)
        {
            try
            {
                string query = @"USP_capNhatPhongChieu @MaPhong , @TenPhong , @SoChoNgoi , @TinhTrang , @SoHangGhe , @SoGheMotHang ";
                int kq = DataProvider.Instance.ExecuteNonQuery(query, new object[] { MaPhong, TenPhong, SoChoNgoi, TinhTrang, SoHangGhe, SoGheMotHang });

                return kq; // Trả về số dòng bị ảnh hưởng, thường là 1 nếu thêm thành công
            }
            catch (Exception ex)
            {
                // Ghi log ra console
                Console.WriteLine("Lỗi khi sửa phòng chiếu: " + ex.Message);
                return 0; // Trả về 0 để biết là có lỗi
            }
        }

        public static PhongChieu GetPhongChieuByName()
        {
            string query = @"USP_layDanhSachPhongChieu";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            if (data.Rows.Count > 0)
            {
                return new PhongChieu(data.Rows[0]);
            }

            throw new Exception("Không tìm thấy phòng chiếu nào trong cơ sở dữ liệu.");
        }

    }
}
