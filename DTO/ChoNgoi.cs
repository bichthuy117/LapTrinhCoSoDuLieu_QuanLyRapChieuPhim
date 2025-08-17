using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;

namespace DTO
{
    public class ChoNgoi
    {
        private int id;
        private string hang;
        private int so;
        private string maPhong;
        private int maKhachHang;

        public int Id { get => id; set => id = value; }
        public string Hang { get => hang; set => hang = value; }
        public int So { get => so; set => so = value; }
        public string MaPhong { get => maPhong; set => maPhong = value; }
        public int MaKhachHang { get => maKhachHang; set => maKhachHang = value; }

        public ChoNgoi() { }

        public ChoNgoi(DataRow row) //Constructor tao dtuong ChoNgoi lay du lieu tu DataRow trong DTB de gan cho cac thuoc tinh sau
        {
            //Id = (int)row["Id"];    //Lấy cột "Id" trong dòng dữ liệu row, ép kiểu về int, gán cho thuộc tính Id.
            //Hang = row["Hang"].ToString(); //ep ve String
            //So = (int)row["So"];
            //MaPhong = row["MaPhong"].ToString();
            //MaKhachHang = (int)row["MaKhachHang"];

            Id = row.Field<int>(nameof(Id));
            Hang = row.Field<string>(nameof(Hang));
            So = row.Field<int>(nameof(So));
            MaPhong = row.Field<string>(nameof(MaPhong));
            MaKhachHang = row.Field<int>(nameof(MaKhachHang));

            //Field<datatype>() : pthuc mo rong LINQ lay gtri cot MaRap -> ep kieu String. Xu ly gtri NULL tot hon
            //Nếu bạn sau này thay đổi tên của biến MaRap thanh 'MovieCode'
            //việc sử dụng nameof giúp đảm bảo tên cột luôn đồng nhất
            //và tránh lỗi khi thay đổi tên cột trong mã nguồn mà không cần sửa chữa nhiều nơi.
        }
    }
}
