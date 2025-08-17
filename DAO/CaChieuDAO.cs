using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using DTO;

namespace DAO
{
    public class CaChieuDAO
    {
        private static CaChieuDAO instance;
        public static CaChieuDAO Instance
        {
            get { if (instance == null) instance = new CaChieuDAO(); return CaChieuDAO.instance; } //instance CaChieu l unique neu chua co thi tao moi
            private set { CaChieuDAO.instance = value; } //private set: ngăn sự tác động từ bên ngoài
        }

        public List<CaChieu> hienThiCaChieu()
        {
            List<CaChieu> caChieus = new List<CaChieu>();

            string query = @"USP_layDanhSachCaChieu"; //goi stored procedure de lay data

            DataTable table = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow row in table.Rows)
            {
                CaChieu caChieu = new CaChieu(row); 
                caChieus.Add(caChieu); //tra ve list dsach cac ca chieu
            }
            return caChieus;
        }

        public ChiTietCaChieu LayThongTinCaChieu(string MaCaChieu)
        {
            string query = @"USP_layChiTietCaChieu @MaCaChieu ";
            DataTable table = DataProvider.Instance.ExecuteQuery(query, new object[] { MaCaChieu });
            if (table.Rows.Count > 0)
                return new ChiTietCaChieu(table.Rows[0]);
            return null;
        }

        public DataTable GetCaChieu()
        {
            return DataProvider.Instance.ExecuteQuery("EXEC USP_layDanhSachCaChieu");
            //tra ve truc tiep DataTable
        }

        public int themCaChieu(string MaCaChieu, DateTime ThoiGianChieu, DateTime ThoiGianKetThuc, string MaPhong, string MaPhim, float GiaVe, string MaRap)
        {
            try
            {
                string query = @"USP_themCaChieu @MaCaChieu , @ThoiGianChieu , @ThoiGianKetThuc , @MaPhong , @MaPhim , @GiaVe , @MaRap ";
                int kq = DataProvider.Instance.ExecuteNonQuery(query, new object[] { MaCaChieu, ThoiGianChieu, ThoiGianKetThuc, MaPhong, MaPhim, GiaVe, MaRap });
                return kq;
            }
            catch (Exception ex)
            {
                //Console.WriteLine("Lỗi khi thêm ca chiếu: " + ex.Message); //debug tạm thời
                throw new Exception("Có lỗi khi thêm ca chiếu trong DAO: " + ex.Message); //de goi BUS khi co loi xay ra
                return 0;
            }


        }
        public int xoaCaChieu(string MaCaChieu)
        {
            try
            {
                string query = @"USP_xoaCaChieu @MaCaChieu ";
                int kq = DataProvider.Instance.ExecuteNonQuery(query, new object[] { MaCaChieu });
                return kq;
            }
            catch (Exception ex) 
            {
                //Console.WriteLine("Lỗi khi thêm ca chiếu: " + ex.Message); //debug tạm thời
                throw new Exception("Có lỗi khi xóa ca chiếu trong DAO: " + ex.Message); 
                return 0; //neu loi
            }
        }

        public int suaCaChieu(string MaCaChieu, DateTime ThoiGianChieu, DateTime ThoiGianKetThuc, string MaPhong, string MaPhim, float GiaVe, string MaRap)
        {
            try
            {
                string query = @"USP_capNhatCaChieu @MaCaChieu , @ThoiGianChieu , @ThoiGianKetThuc , @MaPhong , @MaPhim , @GiaVe , @MaRap ";
                int kq = DataProvider.Instance.ExecuteNonQuery(query, new object[] { MaCaChieu, ThoiGianChieu, ThoiGianKetThuc, MaPhong, MaPhim, GiaVe, MaRap });
                return kq;
            }
            catch (Exception ex) 
            {
                //Console.WriteLine("Lỗi khi sửa ca chiếu: " + ex.Message);
                throw new Exception("Có lỗi khi sửa ca chiếu trong DAO: " + ex.Message);
                return 0;
            }
        }
        public static int updateTinhTrangCaChieu(string MaCaChieu, int TinhTrang)
        {
            string query = "USP_capNhatTinhTrangCaChieu @MaCaChieu , @TinhTrang";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { MaCaChieu, TinhTrang });
            //la p.thuc static goi truc tiep nen ko can qua Instance
        }
    }
}
