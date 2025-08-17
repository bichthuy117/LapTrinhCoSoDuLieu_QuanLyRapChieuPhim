using DAO;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BUS
{
    public class TheLoaiBUS
    {
        private static TheLoaiBUS instance;
        public static TheLoaiBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new TheLoaiBUS(); // nếu chưa có thì tạo mới
                return TheLoaiBUS.instance; // trả về instance đã tạo
            }
            private set { TheLoaiBUS.instance = value; } //Không cho bên ngoài gán lại
        }

        public void hienThiTheLoaiPhim(BindingSource source)
        {
            source.DataSource = TheLoaiDAO.Instance.hienThiTheLoaiPhim();
        }

        public int themTheLoai(string MaLoaiPhim, string TenTheLoai)
        {
            return TheLoaiDAO.Instance.themTheLoai(MaLoaiPhim, TenTheLoai);
        }

        public int xoaTheLoai(string MaLoaiPhim)
        {
            return TheLoaiDAO.Instance.xoaTheLoai(MaLoaiPhim);
        }

        public int suaTheLoai(string MaLoaiPhim, string TenTheLoai)
        {
            return TheLoaiDAO.Instance.suaTheLoai(MaLoaiPhim, TenTheLoai);
        }

    }
}
