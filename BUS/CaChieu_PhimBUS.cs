using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

using DTO;
using DAO;
namespace BUS
{
    public class CaChieu_PhimBUS
    {
        private static CaChieu_PhimBUS instance;
        public static CaChieu_PhimBUS Instance
        {
            get { if (instance == null) instance = new CaChieu_PhimBUS(); return CaChieu_PhimBUS.instance; }
            private set { CaChieu_PhimBUS.instance = value; }
        }
        public List<CaChieu_Phim> hienThiDanhSachCaChieuTheoTenPhim(string tenPhim) //edited. Ko load dtgv o day
        {
            return CaChieu_PhimDAO.Instance.hienthiDanhSachCaChieuByTenPhim(tenPhim);
        }
    }
}
