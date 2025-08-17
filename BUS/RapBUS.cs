using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BUS
{
    public class RapBUS
    {
        private static RapBUS instance;
        public static RapBUS Instance
        {
            get { if (instance == null) instance = new RapBUS(); return RapBUS.instance; }
            private set { RapBUS.instance = value; }
        }

        public void hienThiRapPhim(BindingSource source)
        {
            source.DataSource = RapDAO.Instance.hienThiRapPhim();
        }

        public bool themRap(string MaRap, string TenRap)
        {
            return RapDAO.Instance.themRap(MaRap, TenRap) > 0;
        }

        public bool suaRap(string MaRap, string TenRap)
        {
            return RapDAO.Instance.suaRap(MaRap, TenRap) > 0;
        }

        public bool xoaRap(string MaRap)
        {
            return RapDAO.Instance.xoaRap(MaRap) > 0;
        }
    }
}
