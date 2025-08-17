using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PhongChieu
    {
        private string maPhong;
        private string tenPhong;
        private int soChoNgoi;
        private int tinhTrang;
        private int soHangGhe;
        private int soGheMotHang;

        public string MaPhong { get => maPhong; set => maPhong = value; }
        public string TenPhong { get => tenPhong; set => tenPhong = value; }
        public int SoChoNgoi { get => soChoNgoi; set => soChoNgoi = value; }
        public int TinhTrang { get => tinhTrang; set => tinhTrang = value; }
        public int SoHangGhe { get => soHangGhe; set => soHangGhe = value; }
        public int SoGheMotHang { get => soGheMotHang; set => soGheMotHang = value; }

        public PhongChieu() { }

        public PhongChieu(DataRow row)
        {
            MaPhong = row["MaPhong"].ToString();
            TenPhong = row["TenPhong"].ToString();
            SoChoNgoi = (int)row["SoChoNgoi"];
            TinhTrang = (int)row["TinhTrang"];
            SoHangGhe = (int)row["SoHangGhe"];
            SoGheMotHang = (int)row["SoGheMotHang"];
        }
    }
}
