using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class TheLoaiDAO
    {
        private static TheLoaiDAO instance;
        public static TheLoaiDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new TheLoaiDAO(); // nếu chưa có thì tạo mới
                return TheLoaiDAO.instance; // trả về instance đã tạo
            }
            private set { TheLoaiDAO.instance = value; } //Không cho bên ngoài gán lại
        }

        public List<TheLoai> hienThiTheLoaiPhim()
        {
            List<TheLoai> danhSachTheLoai = new List<TheLoai>();
            string query = @"USP_hienThiTheLoaiPhim";
            DataTable table = DataProvider.Instance.ExecuteQuery(query); //Gọi DP kết nối DB, thực hiện câu lệnh lấy DL
            foreach (DataRow row in table.Rows) //duyệt qua từng dòng trong bảng DL
            {                                   
                TheLoai theLoai = new TheLoai(row);
                danhSachTheLoai.Add(theLoai);
            }
            return danhSachTheLoai;

        }

        public int themTheLoai(string MaLoaiPhim, string TenTheLoai)
        {
            try
            {
                string query = @"USP_themTheLoaiPhim @MaLoaiPhim , @TenTheLoai ";
                int kq = DataProvider.Instance.ExecuteNonQuery(query, new object[] { MaLoaiPhim, TenTheLoai});

                return kq; // Trả về số dòng bị ảnh hưởng, thường là 1 nếu thêm thành công
            }
            catch (Exception ex)
            {
                // Ghi log ra console
                Console.WriteLine("Lỗi khi thêm the loai: " + ex.Message);
                return 0; // Trả về 0 để biết là có lỗi
            }
        }

        public int xoaTheLoai(string MaLoaiPhim)
        {
            try
            {
                string query = @"USP_xoaTheLoaiPhim @MaLoaiPhim ";
                int kq = DataProvider.Instance.ExecuteNonQuery(query, new object[] { MaLoaiPhim});

                return kq; // Trả về số dòng bị ảnh hưởng, thường là 1 nếu xóa thành công
            }
            catch (Exception ex)
            {
                // Ghi log ra console
                Console.WriteLine("Lỗi khi xóa the loai: " + ex.Message);
                return 0; // Trả về 0 để biết là có lỗi
            }
        }

        public int suaTheLoai(string MaLoaiPhim, string TenTheLoai)
        {
            try
            {
                string query = @"USP_suaTheLoaiPhim @MaLoaiPhim , @TenTheLoai ";
                int kq = DataProvider.Instance.ExecuteNonQuery(query, new object[] { MaLoaiPhim, TenTheLoai });

                return kq; // Trả về số dòng bị ảnh hưởng, thường là 1 nếu sửa thành công
            }
            catch (Exception ex)
            {
                // Ghi log ra console
                Console.WriteLine("Lỗi khi sửa the loai: " + ex.Message);
                return 0; // Trả về 0 để biết là có lỗi
            }
        }

        //// hiển thị thể loại bộ phim theo id
        public static List<TheLoai> layDanhSachTheLoaiBoPhimID(string MaPhim)
        {
            List<TheLoai> theloaiList = new List<TheLoai>();
            DataTable data = DataProvider.Instance.ExecuteQuery("EXEC USP_layTheLoaiBoiPhim @MaPhim", new object[] { MaPhim });
            foreach (DataRow item in data.Rows)
            {
                TheLoai genre = new TheLoai(item);
                theloaiList.Add(genre);
            }
            return theloaiList;
        }
    }
}
