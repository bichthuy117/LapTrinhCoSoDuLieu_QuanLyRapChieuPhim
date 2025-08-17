using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using DAO;
using DTO;
//LOP BUS ko nen biet den phan GUI. 
namespace BUS
{
    public class CaChieuBUS
    {
        private static CaChieuBUS instance;
        public static CaChieuBUS Instance
        {
            get { if (instance == null) instance = new CaChieuBUS(); return CaChieuBUS.instance; } //neu chua co thi tao moi
            private set { CaChieuBUS.instance = value; } //privte set tranh tac dong du lieu tu ben ngoai
        }

        public void hienThiCaChieu(BindingSource source)
        {
            source.DataSource = CaChieuDAO.Instance.hienThiCaChieu();
        }

        public void hienThiThongTinChiTietLichChieu(int index, string tenPhim, ListView lv)
        {

        }
        public void GetCaChieu(BindingSource source)
        {
            source.DataSource = CaChieuDAO.Instance.GetCaChieu();
        }
        public int themCaChieu(
            string MaCaChieu
            , DateTime ThoiGianChieu
            , DateTime ThoiGianKetThuc, string MaPhong, string MaPhim, float GiaVe, string MaRap)
        {
            return CaChieuDAO.Instance.themCaChieu(MaCaChieu, ThoiGianChieu, ThoiGianKetThuc, MaPhong, MaPhim, GiaVe, MaRap);
        }
        public int xoaCaChieu(string MaCaChieu)
        {
            return CaChieuDAO.Instance.xoaCaChieu(MaCaChieu);
        }
        public int suaCaChieu(string MaCaChieu, DateTime ThoiGianChieu, DateTime ThoiGianKetThuc, string MaPhong, string MaPhim, float GiaVe, string MaRap)
        {
            return CaChieuDAO.Instance.suaCaChieu(MaCaChieu,ThoiGianChieu,ThoiGianKetThuc,MaPhong,MaPhim,GiaVe,MaRap);
        }

        public ChiTietCaChieu LayChiTietCaChieu(string maCaChieu)
        {
            return CaChieuDAO.Instance.LayThongTinCaChieu(maCaChieu);
        }
    }
}
