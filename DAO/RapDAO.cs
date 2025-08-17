using DTO;
using System;
using System.Collections.Generic;
using System.Data;

namespace DAO
{
    public class RapDAO
    {
        private static RapDAO instance;
        public static RapDAO Instance
        {
            get { if (instance == null) instance = new RapDAO(); return instance; }
            private set { instance = value; }
        }

        public List<Rap> hienThiRapPhim()
        {
            List<Rap> danhSachRap = new List<Rap>();
            string query = @"USP_layDanhSachRapPhim";

            DataTable table = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow row in table.Rows)
            {
                Rap rap = new Rap(row);
                danhSachRap.Add(rap);
            }

            return danhSachRap;
        }

        public int themRap(string MaRap, string TenRap)
        {
            string query = @"USP_themRapPhim @MaRap , @TenRap ";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { MaRap, TenRap });
        }

        public int xoaRap(string MaRap)
        {
            string query = @"USP_xoaRapPhim @MaRap ";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { MaRap });
        }

        public int suaRap(string MaRap, string TenRap)
        {
            string query = @"USP_capNhatRapPhim @MaRap , @TenRap ";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { MaRap, TenRap });
        }

        // (Optional): Lấy danh sách rạp theo mã phim
        public List<Rap> layDanhSachRapBoiPhim(string MaPhim)
        {
            List<Rap> danhSachRap = new List<Rap>();
            string query = "EXEC USP_layRapBoiPhim @MaPhim";
            DataTable table = DataProvider.Instance.ExecuteQuery(query, new object[] { MaPhim });

            foreach (DataRow row in table.Rows)
            {
                Rap rap = new Rap(row);
                danhSachRap.Add(rap);
            }

            return danhSachRap;
        }
    }
}
