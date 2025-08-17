using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Rap
    {
        private string _maRap;
        private string _tenRap;

        public string MaRap { get => _maRap; set => _maRap = value; }
        public string TenRap { get => _tenRap; set => _tenRap = value; }

        public Rap(DataRow row)
        {
            MaRap = row["MaRap"].ToString();
            TenRap = row["TenRap"].ToString();
        }
    }
}
