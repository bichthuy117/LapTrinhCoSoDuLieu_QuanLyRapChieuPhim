using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;

namespace DTO
{
    public class CaChieu_Phim
    {
        public CaChieu_Phim(string maCaChieu, string tenPhim, DateTime thoigianchieu, string maphong, int trangthai)
        {
            this.MaCaChieu = maCaChieu;
            this.TenPhim = tenPhim;
            this.ThoiGianChieu = thoigianchieu;
            //this.ThoiGianKetThuc = thoigianketthuc;
            this.TrangThai = trangthai;
            this.MaPhong = maphong;
        }

        public CaChieu_Phim(DataRow row)
        {
            //edited
            MaCaChieu = row.Field<string>(nameof(MaCaChieu));
            TenPhim = row.Field<string>(nameof(TenPhim));
            ThoiGianChieu = row.Field<DateTime>(nameof(ThoiGianChieu));
            //ThoiGianKetThuc = row.Field<DateTime>(nameof(ThoiGianKetThuc)); //bo sung cot nay
            TrangThai = row.Field<int>(nameof(TrangThai));
            MaPhong = row.Field<string>(nameof(MaPhong));
            MaRap = row.Field<string>(nameof(MaRap));  //khi marap cho phep null ? 
        }
        public string MaCaChieu { get; set; }
        public string TenPhim { get; set; }
        public DateTime ThoiGianChieu { get; set; }
        //public DateTime ThoiGianKetThuc { get; set; }
        public int TrangThai { get; set; }
        public string MaPhong { get; set; }
        public string MaRap { get; set; }

    }
}
