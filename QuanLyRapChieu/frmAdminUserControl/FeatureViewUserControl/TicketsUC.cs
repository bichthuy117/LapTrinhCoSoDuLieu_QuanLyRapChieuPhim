using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyXemPhim.frmAdminUserControl.FeatureViewUserControl
{
    public partial class TicketsUC : UserControl
    {
        public TicketsUC()
        {
            InitializeComponent();
        }
        void LoadCaChieuList()
        {
            lsvAllListShowTimes.Items.Clear();

            List<CaChieu_Phim> allListCaChieu = CaChieu_PhimDAO.GetCaChieuByTicket();
            foreach (CaChieu_Phim showTimes in allListCaChieu)
            {
                ListViewItem lvi = new ListViewItem(showTimes.MaCaChieu);
                lvi.SubItems.Add(showTimes.MaPhong);
                lvi.SubItems.Add(showTimes.TenPhim);
                lvi.SubItems.Add(showTimes.ThoiGianChieu.ToString("HH:mm:ss dd/MM/yyyy"));
                //lvi.SubItems.Add(showTimes.ThoiGianKetThuc.ToString("HH:mm:ss dd/MM/yyyy"));

                lvi.Tag = showTimes;
                if (showTimes.TrangThai == 1)
                {
                    lvi.SubItems.Add("Sắp Chiếu");
                }
                else
                {
                    lvi.SubItems.Add("Chưa Chiếu");
                }
                lsvAllListShowTimes.Items.Add(lvi);
            }
        }
        private void lsvAllListShowTimes_Click(object sender, EventArgs e)
        {
            if (lsvAllListShowTimes.SelectedItems.Count > 0)
            {
                CaChieu_Phim showTimes = lsvAllListShowTimes.SelectedItems[0].Tag as CaChieu_Phim;
                hienThiVebyCaChieu(showTimes.MaCaChieu);
            }
        }
        private void btnAddTicketsByShowTime_Click(object sender, EventArgs e)
        {
            if (lsvAllListShowTimes.SelectedItems.Count > 0)
            {
                CaChieu_Phim showTimes = lsvAllListShowTimes.SelectedItems[0].Tag as CaChieu_Phim;
                if (showTimes.TrangThai == 1)
                {
                    MessageBox.Show("CA CHIẾU NÀY ĐÃ ĐƯỢC TẠO VÉ!!!", "THÔNG BÁO");
                    return;
                }
                TaoVe(showTimes);
                LoadCaChieuList();
                hienThiVebyCaChieu(showTimes.MaCaChieu);
            }
            else
            {
                MessageBox.Show("BẠN CHƯA CHỌN CA CHIẾU ĐỂ TẠO!!!", "THÔNG BÁO");
            }
        }

        //private void btnShowAllTicketsBoughtByShowTime_Click(object sender, EventArgs e)
        //{
        //    if (lsvAllListShowTimes.SelectedItems.Count > 0)
        //    {
        //        CaChieu caChieu = lsvAllListShowTimes.SelectedItems[0].Tag as CaChieu;
        //        hienThiVeDaMuaBoiCaChieu(caChieu.MaCaChieu);
        //    }
        //    else
        //    {
        //        MessageBox.Show("BẠN CHƯA CHỌN LỊCH CHIẾU ĐỂ XEM!!!", "THÔNG BÁO");
        //    }
        //}
        void TaoVe(CaChieu_Phim caChieu)
        {
            int result = 0;
            PhongChieu cinema = PhongChieuDAO.GetPhongChieuByName();
            int Row = cinema.SoHangGhe;
            int Column = cinema.SoGheMotHang;

            for (int i = 0; i < Row; i++) 
            {
                
                int temp = i + 65;
                char nameRow = (char)(temp);
                for (int j = 0; j < Column; j++) // j bắt đầu từ 0
                {
                    string seatName = $"{nameRow}-{j}"; //HIEN THI maghengoi A-0 den A-9 thay vi A0 A1
                    result += VeDAO.Instance.themVeByCaChieu(caChieu.MaCaChieu, seatName);
                }
            }

            if (result == Row * Column)
            {
                int ret = CaChieuDAO.updateTinhTrangCaChieu(caChieu.MaCaChieu, 1);
                if (ret > 0)
                    MessageBox.Show("TẠO VÉ THÀNH CÔNG!", "THÔNG BÁO");
            }
            else
                MessageBox.Show("TẠO VÉ THẤT BẠI!", "THÔNG BÁO");

        }
        void hienThiVebyCaChieu(string maCaChieu)
        {
            List<Ve> listTicket = VeDAO.Instance.hienthiVe(maCaChieu);
            dtgvTicket.DataSource = listTicket;

        }
        private void btnAllListShowTimes_Click(object sender, EventArgs e)
        {
            LoadCaChieuList();
        }


        private void xoaVebyCaChieu(CaChieu_Phim caChieu)
        {
            PhongChieu cinema = PhongChieuDAO.GetPhongChieuByName();
            int Row = cinema.SoHangGhe;
            int Column = cinema.SoGheMotHang;
            int result = VeDAO.Instance.xoaVeByCaChieu(caChieu.MaCaChieu);
            if (result == Row * Column)
            {
                int ret = CaChieuDAO.updateTinhTrangCaChieu(caChieu.MaCaChieu, 0);
                if (ret > 0)
                    MessageBox.Show("XÓA TẤT CẢ CÁC VÉ CỦA CA CHIẾU ID=" + caChieu.MaCaChieu + " THÀNH CÔNG!", "THÔNG BÁO");
            }
            else
                MessageBox.Show("XÓA TẤT CẢ CÁC VÉ CỦA CA CHIẾU ID=" + caChieu.MaCaChieu + " THẤT BẠI!", "THÔNG BÁO");
        }

        //private void btnDeleteTicketsByShowTime_Click(object sender, EventArgs e)
        //{
        //    if (lsvAllListShowTimes.SelectedItems.Count > 0)
        //    {
        //        CaChieu_Phim caChieu = lsvAllListShowTimes.SelectedItems[0].Tag as CaChieu_Phim;
        //        xoaVebyCaChieu(caChieu);
        //        LoadCaChieuList();
        //        hienThiVebyCaChieu(caChieu.MaCaChieu);
        //    }
        //    else
        //    {
        //        MessageBox.Show("BẠN CHƯA CHỌN LỊCH CHIẾU ĐỂ XÓA!!!", "THÔNG BÁO");
        //    }

        //}

        void hienThiVeDaMuaBoiCaChieu(string maCaChieu)
        {
            List<Ve> listTicket = VeDAO.Instance.layTrangThaiVeDaBan(maCaChieu);
            dtgvTicket.DataSource = listTicket;
        }

        private void TicketsUC_Load(object sender, EventArgs e)
        {
            LoadCaChieuList();
        }

    }
}
