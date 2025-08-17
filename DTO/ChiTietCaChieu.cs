using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;

namespace DTO
{
    public class ChiTietCaChieu
    {
        public ChiTietCaChieu(DataRow r)
        {
            MaCaChieu = r.Field<string>(nameof(MaCaChieu));
            ThoiGianChieu = r.Field<DateTime>(nameof(ThoiGianChieu));
            ThoiGianKetThuc = r.Field<DateTime>(nameof(ThoiGianKetThuc));
            MaPhong = r.Field<string>(nameof(MaPhong));
            MaPhim = r.Field<string>(nameof(MaPhim));
            GiaVe = r.Field<decimal>(nameof(GiaVe));
            TrangThai = r.Field<int>(nameof(TrangThai));
            TenPhong = r.Field<string>(nameof(TenPhong));
            SoChoNgoi = r.Field<int>(nameof(SoChoNgoi));
            TinhTrang = r.Field<int>(nameof(TinhTrang));
            SoHangGhe = r.Field<int>(nameof(SoHangGhe));
            SoGheMotHang = r.Field<int>(nameof(SoGheMotHang));
            TenPhim = r.Field<string>(nameof(TenPhim));
            ThoiLuong = r.Field<double>(nameof(ThoiLuong));
            NgayKhoiChieu = r.Field<DateTime>(nameof(NgayKhoiChieu));
            NgayKetThuc = r.Field<DateTime>(nameof(NgayKetThuc));
            MaRap = r.Field<string>(nameof(MaRap));
            TenRap = r.Field<string>(nameof(TenRap));

            //Field<datatype>() : pthuc mo rong LINQ lay gtri cot MaRap -> ep kieu String. Xu ly gtri NULL tot hon
            //Nếu bạn sau này thay đổi tên của biến MaRap thanh 'MovieCode'
            //việc sử dụng nameof giúp đảm bảo tên cột luôn đồng nhất
            //và tránh lỗi khi thay đổi tên cột trong mã nguồn mà không cần sửa chữa nhiều nơi.
        }
        public string MaCaChieu { get; set; }
        public DateTime ThoiGianChieu { get; set; }
        public DateTime ThoiGianKetThuc { get; set; }
        public string MaPhong { get; set; }
        public string MaPhim { get; set; }
        public decimal GiaVe { get; set; }
        public int TrangThai { get; set; }
        public string TenPhong { get; set; }
        public int SoChoNgoi { get; set; }
        public int TinhTrang { get; set; }
        public int SoHangGhe { get; set; }
        public int SoGheMotHang { get; set; }
        public string TenPhim { get; set; }
        public double ThoiLuong { get; set; }
        public DateTime NgayKhoiChieu { get; set; }
        public DateTime NgayKetThuc { get; set; }
        public string MaRap { get; set; }
        public string TenRap { get; set; }
    }
}
