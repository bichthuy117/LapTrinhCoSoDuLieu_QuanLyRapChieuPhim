using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ComBoBapNuoc
    {
        private int maCB;
        private string tenCB;
        private decimal gia;

        public int MaCombo { get => maCB; set => maCB = value; }
        public string TenCombo { get => tenCB; set => tenCB = value; }
        public decimal Gia { get => gia; set => gia = value; }

        public ComBoBapNuoc() { }

        public ComBoBapNuoc(DataRow row) //tạo 1 đối tượng ComboBapNuoc từ 1 dòng dữ liệu (DataRow)
        {                             //(ví dụ SELECT * FROM ComboBapNuoc) và kết quả là một DataTable, thì mỗi dòng trong đó là một DataRow.
            MaCombo = (int)row["MaCombo"];
            TenCombo = row["TenCombo"].ToString();
            Gia = Convert.ToInt32(row["Gia"]);

        }

    }
}
