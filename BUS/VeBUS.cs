using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Windows.Documents;
using System.Windows.Forms;

namespace BUS
{
    public class VeBUS
    {
        private static VeBUS instance;
        public static VeBUS Instance
        {
            get { if (instance == null) instance = new VeBUS(); return VeBUS.instance; }
            private set { VeBUS.instance = value; }
        }

        public List<Ve> hienthiVe(string maCaChieu)
        {
            return VeDAO.Instance.hienthiVe(maCaChieu);
        }

        public Boolean updateListTicket(List<Ve> maVe)
        {
            return VeDAO.Instance.updateListTicketDAO(maVe);
        }

        public float getPriceOfTicketBUS(string maCaChieu)
        {
            return VeDAO.Instance.getPriceOfTicketDAO(maCaChieu);
        }
    }
}
