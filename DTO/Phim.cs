using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Phim
    {
        private string maPhim;
        private string tenPhim;
        private string moTa;
        private float thoiLuong;
        private DateTime ngayKhoiChieu;
        private DateTime ngayKetThuc;
        private string quocGia;
        private string daoDien;
        private int gioiHanTuoi;
        private int namSX;

        public string MaPhim { get => maPhim; set => maPhim = value; }
        public string TenPhim { get => tenPhim; set => tenPhim = value; }
        public string MoTa { get => moTa; set => moTa = value; }
        public float ThoiLuong { get => thoiLuong; set => thoiLuong = value; }
        public DateTime NgayKhoiChieu { get => ngayKhoiChieu; set => ngayKhoiChieu = value; }
        public DateTime NgayKetThuc { get => ngayKetThuc; set => ngayKetThuc = value; }
        public string QuocGia { get => quocGia; set => quocGia = value; }
        public string DaoDien { get => daoDien; set => daoDien = value; }
        public int GioiHanTuoi { get => gioiHanTuoi; set => gioiHanTuoi = value; }
        public int NamSX { get => namSX; set => namSX = value; }

        public Phim() { }

        public Phim(DataRow row)
        {
            MaPhim = row["MaPhim"].ToString();
            TenPhim = row["TenPhim"].ToString();
            MoTa = row["MoTa"].ToString();
            ThoiLuong = (float)Convert.ToDouble(row["ThoiLuong"]);
            NgayKhoiChieu = (DateTime)row["NgayKhoiChieu"];
            NgayKetThuc = (DateTime)row["NgayKetThuc"];
            QuocGia = row["QuocGia"].ToString();
            DaoDien = row["DaoDien"].ToString();
            GioiHanTuoi = (int)row["GioiHanTuoi"];
            NamSX = (int)row["NamSX"];
        }
    }
}
