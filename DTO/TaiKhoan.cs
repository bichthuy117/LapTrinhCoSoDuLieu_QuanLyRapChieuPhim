using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TaiKhoan
    {
        private string userName;
        private string pass;
        private int loaiTK;
        private string idNV;

        public string UserName { get => userName; set => userName = value; }
        public string Pass { get => pass; set => pass = value; }
        public int LoaiTK { get => loaiTK; set => loaiTK = value; }
        public string IdNV { get => idNV; set => idNV = value; }

        public TaiKhoan() { }

        public TaiKhoan(DataRow row)
        {
            UserName = row["UserName"].ToString();
            Pass = row["Pass"].ToString();
            LoaiTK = (int)row["LoaiTK"];
            IdNV = row["idNV"].ToString();
        }
    }
}
