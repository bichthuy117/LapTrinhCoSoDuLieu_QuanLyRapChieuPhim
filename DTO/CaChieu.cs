using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;

namespace DTO
{
    public class CaChieu
    {
        private string maCaChieu;
        private DateTime thoiGianChieu;
        private DateTime thoiGianKetThuc;
        private string maPhong;
        private string maPhim;
        private float giaVe;
        private int trangThai;

        public string MaCaChieu { get => maCaChieu; set => maCaChieu = value; }
        public DateTime ThoiGianChieu { get => thoiGianChieu; set => thoiGianChieu = value; }
        public DateTime ThoiGianKetThuc { get => thoiGianKetThuc; set => thoiGianKetThuc = value; }
        public string MaPhong { get => maPhong; set => maPhong = value; }
        public string MaPhim { get => maPhim; set => maPhim = value; }
        public int TrangThai { get => trangThai; set => trangThai = value; }
        public float GiaVe { get => giaVe; set => giaVe = value; }
        public string MaRap { get; set; }

        public CaChieu() { }

        public CaChieu(DataRow row) //Lay dlieu tu Datarom -> gan thuoc tinh cho cac dtuong sau:
        {
            this.MaCaChieu = row["MaCaChieu"].ToString();
            ThoiGianChieu = (DateTime)row["ThoiGianChieu"];
            ThoiGianKetThuc = (DateTime)row["ThoiGianKetThuc"];
            MaPhong = row["MaPhong"].ToString();
            MaPhim = row["MaPhim"].ToString();
            if (row["GiaVe"].ToString() == "")
                this.GiaVe = 0;
            else
                this.GiaVe = float.Parse(row["GiaVe"].ToString()); //chua co gia ve 120k

            this.TrangThai = (int)row["TrangThai"]; //t.thai 0, 1 
            MaRap = row["MaRap"].ToString(); //CGV, BETA
        }
    }
}
