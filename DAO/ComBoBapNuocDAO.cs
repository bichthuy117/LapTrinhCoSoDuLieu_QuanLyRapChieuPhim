using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class ComBoBapNuocDAO
    {
        private static ComBoBapNuocDAO instance;
        public static ComBoBapNuocDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new ComBoBapNuocDAO();
                return instance;
            }
            private set { instance = value; }
        }

        public List<ComBoBapNuoc> LayDanhSachCombo()
        {
            List<ComBoBapNuoc> list = new List<ComBoBapNuoc>();
            string query = "SELECT * FROM ComboBapNuoc";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow row in data.Rows)
            {
                list.Add(new ComBoBapNuoc(row));
            }
            return list;
        }

        public List<ComBoBapNuoc> LayTatCaCombo()
        {
            List<ComBoBapNuoc> danhSachCombo = new List<ComBoBapNuoc>();
            string query = "USP_layDanhSachComboBapNuoc";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow row in data.Rows)
            {
                ComBoBapNuoc combo = new ComBoBapNuoc(row);
                danhSachCombo.Add(combo);
            }

            return danhSachCombo;
        }

        public int ThemCombo(string tenCombo, decimal gia)
        {
            string query = "sp_ThemCombo @TenCombo , @Gia";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { tenCombo, gia });
        }

        public int XoaCombo(string maCombo)
        {
            string query = "sp_XoaCombo @MaCombo";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { maCombo });
        }

        public int SuaCombo(string maCombo, string tenCombo, decimal gia)
        {
            string query = "sp_SuaCombo @MaCombo , @TenCombo , @Gia";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { maCombo, tenCombo, gia });
        }





    }
}
