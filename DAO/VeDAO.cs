using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class VeDAO
    {
        private static VeDAO instance;
        public static VeDAO Instance
        {
            get { if (instance == null) instance = new VeDAO(); return VeDAO.instance; }
            private set { VeDAO.instance = value; }
        }
        public int themVeByCaChieu(string MaCaChieu, string MaGheNgoi)
        {
            string query = "USP_themVeCaChieu @MaCaChieu , @MaGheNgoi ";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { MaCaChieu, MaGheNgoi });
        }
        public List<Ve> hienthiVe(string maCaChieu)
        {
            List<Ve> listTicket = new List<Ve>();
            string query = @"select * from Ve where MaCaChieu = '" + maCaChieu + "'";  //Dễ xh SQL Injection risk (không dùng tham số hóa truy vấn)
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
     

            foreach (DataRow row in data.Rows)
            {
                Ve ticket = new Ve(row);
                listTicket.Add(ticket);
            }
            return listTicket;
        }
        public int xoaVeByCaChieu(string MaCaChieu)
        {
            string query = "USP_xoaVeBoiMaCaChieu";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { MaCaChieu });
        }

        public bool updateListTicketDAO(List<Ve> maVe)
        {

            string query = "USP_capNhatTrangThaiVe @maVe , @TienBanVe ,  @LoaiVe ";
            try
            {
                for (int i = 0; i < maVe.Count; i++)
                {
                    DataProvider.Instance.ExecuteNonQuery(query, new object[] { maVe[i].Id, maVe[i].TienBanVe, maVe[i].LoaiVe });
                }
                return true;
            }
            catch
            {
                return false;
            }


        }

        public float getPriceOfTicketDAO(string maCaChieu)
        {
            string query = "Select dbo.FUNC_layGiaVe( @Id ) ";
            try
            {
                return Convert.ToSingle(DataProvider.Instance.ExecuteScalar(query, new object[] { maCaChieu }));
            }
            catch
            {
                return -1;
            }

        }
        public List<Ve> layTrangThaiVeDaBan(string maCaChieu)
        {
            List<Ve> listTicket = new List<Ve>();
            string query = "SELECT * FROM Ve WHERE MaCaChieu = @MaCaChieu AND TrangThai = 1";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { maCaChieu });

            foreach (DataRow row in data.Rows)
            {
                Ve ticket = new Ve(row);
                listTicket.Add(ticket);
            }

            return listTicket;
        }
    }
}
