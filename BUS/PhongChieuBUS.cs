using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BUS
{
    public class PhongChieuBUS
    {
        private static PhongChieuBUS instance;
        public static PhongChieuBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new PhongChieuBUS(); // nếu chưa có thì tạo mới
                return PhongChieuBUS.instance; // trả về instance đã tạo
            }
            private set { PhongChieuBUS.instance = value; } //Không cho bên ngoài gán lại
        }

        //hiển thị phòng chiếu
        public void hienThiPhongChieu(BindingSource source)
        {
            source.DataSource = PhongChieuDAO.Instance.hienThiPhongChieu();
        }

        public int themPhongChieu(string MaPhong, string TenPhong, int SoChoNgoi, int TinhTrang, int SoHangGhe, int SoGheMotHang)
        {
            return PhongChieuDAO.Instance.themPhongChieu(MaPhong, TenPhong, SoChoNgoi, TinhTrang, SoHangGhe, SoGheMotHang);
        }

        public int xoaPhongChieu(string MaPhong)
        {
            return PhongChieuDAO.Instance.xoaPhongChieu(MaPhong);
        }

        public int capNhatPhongChieu(string MaPhong, string TenPhong, int SoChoNgoi, int TinhTrang, int SoHangGhe, int SoGheMotHang)
        {
            return PhongChieuDAO.Instance.suaPhongChieu(MaPhong, TenPhong, SoChoNgoi, TinhTrang, SoHangGhe, SoGheMotHang);
        }
    }
}
