using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ComBoBapNuoc_Chon
    {
        public class ComboChon
        {
            public int MaCombo { get; set; }
            public string TenCombo { get; set; }
            public decimal Gia { get; set; }
            public int SoLuong { get; set; } = 0;

            public decimal ThanhTien => Gia * SoLuong;
        }

    }
}
