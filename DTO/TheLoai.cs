using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TheLoai
    {
        private string maLoaiPhim;
        private string tenTheLoai;


        public string MaLoaiPhim { get => maLoaiPhim; set => maLoaiPhim = value; }
        public string TenTheLoai { get => tenTheLoai; set => tenTheLoai = value; }

        public TheLoai() { }

        public TheLoai(DataRow row)
        {
            MaLoaiPhim = row["MaLoaiPhim"].ToString();
            TenTheLoai = row["TenTheLoai"].ToString();
        }
    }
}
