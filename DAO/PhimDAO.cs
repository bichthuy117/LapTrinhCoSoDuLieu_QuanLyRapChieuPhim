using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class PhimDAO
    {
        private static PhimDAO instance;
        public static PhimDAO Instance
        {
            get { if (instance == null) instance = new PhimDAO(); return PhimDAO.instance; }
            private set { PhimDAO.instance = value; }
        }


        public List<Phim> hienThiPhim()
        {
            try
            {
                string query = @"USP_hienDanhSachPhim";
                List<Phim> danhSachPhim = new List<Phim>();
                DataTable table = DataProvider.Instance.ExecuteQuery(query);

                foreach (DataRow row in table.Rows)
                {
                    Phim phim = new Phim(row);
                    danhSachPhim.Add(phim);
                }
                return danhSachPhim;
            }
            catch
            {
                return null;
            }
        }

        public List<Phim> hienThiPhimTheoNgay(DateTime date)
        {
            try
            {
                string query = @"SELECT * FROM dbo.FUNC_layPhimTheoNgayChieu( @NgayChieu )";
                List<Phim> danhSachPhim = new List<Phim>();
                DataTable table = DataProvider.Instance.ExecuteQuery(query, new object[] { date });

                foreach (DataRow row in table.Rows)
                {
                    Phim phim = new Phim(row);
                    danhSachPhim.Add(phim);
                }
                return danhSachPhim;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi DAO khi truy vấn hienThiPhimTheoNgay: " + ex.Message);
                return null;
            }
        }
        //string query = @"SELECT * FROM dbo.FUNC_layPhimTheoThangChieu('2025-05-01');
        public List<Phim> hienThiPhimTheoThang(DateTime date)
        {
            try
            {
                string query = @"SELECT * FROM dbo.FUNC_layPhimTheoThangChieu( @NgayChieu )"; //error: cần space ( @NgayChieu )
                List<Phim> danhSachPhim = new List<Phim>();
                DataTable table = DataProvider.Instance.ExecuteQuery(query, new object[] { date });

                foreach (DataRow row in table.Rows)
                {
                    Phim phim = new Phim(row);
                    danhSachPhim.Add(phim);
                }
                return danhSachPhim;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi DAO khi truy vấn hienThiPhimTheoThang: " + ex.Message);
                return null;
            }
        }

        public int suaDanhSachPhim(string MaPhim, string TenPhim, string MoTa, double ThoiLuong,
            DateTime NgayBatDau, DateTime NgayKetThuc, string QuocGia, string DienVien, int NamSX, int GioiHanTuoi)
        {
            try
            {
                string query = @"USP_suaDanhSachPhim @MaPhim , @TenPhim , @MoTa , @ThoiLuong , @NgayKhoiChieu ,
                         @NgayKetThuc , @QuocGia , @DaoDien , @NamSX , @GioiHanTuoi ";
                int kq = DataProvider.Instance.ExecuteNonQuery(query, new object[] {MaPhim, TenPhim,MoTa, ThoiLuong,
                         NgayBatDau, NgayKetThuc, QuocGia, DienVien,NamSX, GioiHanTuoi });
                return kq;
            }
            catch
            {
                return 0;
            }
        }
        public int themDanhSachPhim(string MaPhim, string TenPhim, string MoTa, double ThoiLuong,
            DateTime NgayBatDau, DateTime NgayKetThuc, string QuocGia, string DienVien, int NamSX, int GioiHanTuoi)
        {
            try
            {
                string query = @"USP_themDanhSachPhim @MaPhim , @TenPhim , @MoTa , @ThoiLuong , @NgayKhoiChieu ,
                        @NgayKetThuc , @QuocGia , @DaoDien , @NamSX , @GioiHanTuoi ";
                int kq = DataProvider.Instance.ExecuteNonQuery(query, new object[] {MaPhim, TenPhim,MoTa, ThoiLuong,
                        NgayBatDau, NgayKetThuc, QuocGia, DienVien, NamSX, GioiHanTuoi });
                return kq;
            }
            catch
            {
                return 0;
            }
        }
        public int xoaDanhSachPhim(string MaPhim)
        {
            try
            {
                string query = @"USP_xoaDanhSachPhimTuCaChieu @MaPhim ";
                int kq = DataProvider.Instance.ExecuteNonQuery(query, new object[] { MaPhim });
                return kq;
            }
            catch
            {
                return 0;
            }
        }

        // Lấy tên Phim 
        public static List<Phim> GetPhim()
        {
            List<Phim> MovieList = new List<Phim>();
            DataTable data = DataProvider.Instance.ExecuteQuery(@"USP_hienDanhSachPhim");
            foreach (DataRow item in data.Rows)
            {
                Phim MovieName = new Phim(item);
                MovieList.Add(MovieName);
            }
            return MovieList;
        }
        public static Phim layMaPhim(string id)
        {
            Phim movie = null;
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.Phim WHERE MaPhim = '" + id + "'");
            foreach (DataRow item in data.Rows)
            {
                movie = new Phim(item);
                return movie;
            }
            return movie;
        }
    }
}
