using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyRapChieu.frmAdminUserControl.FeatureViewUserControl
{
    public partial class Popcorn_UC : UserControl
    {
        BindingSource comboList = new BindingSource();

        public Popcorn_UC()
        {
            InitializeComponent();
        }

        private void Popcorn_UC_Load(object sender, EventArgs e)
        {
            dtgvPopcorn.DataSource = comboList;
            LoadComboList();
        }

        private void LoadComboList()
        {
            ComBoBapNuocBUS.Instance.HienThiDanhSachCombo(comboList);
            dtgvPopcorn.DataSource = comboList;
            ClearAndAddBinding();
        }

        private void ClearAndAddBinding()
        {
            txtMaCbo.DataBindings.Clear();
            txtTenCbo.DataBindings.Clear();
            txtGiaCbo.DataBindings.Clear();

            txtMaCbo.DataBindings.Add(new Binding("Text", dtgvPopcorn.DataSource, "MaCombo", true, DataSourceUpdateMode.Never));
            txtTenCbo.DataBindings.Add(new Binding("Text", dtgvPopcorn.DataSource, "TenCombo", true, DataSourceUpdateMode.Never));
            txtGiaCbo.DataBindings.Add(new Binding("Text", dtgvPopcorn.DataSource, "Gia", true, DataSourceUpdateMode.Never));
        }
        
        
        private void btnInsertPopcorn_Click(object sender, EventArgs e)
        {
            string ma = txtMaCbo.Text.Trim();
            string ten = txtTenCbo.Text.Trim();
            string giaText = txtGiaCbo.Text.Trim();

            if (string.IsNullOrEmpty(ma) || string.IsNullOrEmpty(ten) || string.IsNullOrEmpty(giaText))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }

            if (!int.TryParse(giaText, out int gia))
            {
                MessageBox.Show("Giá phải là số!");
                return;
            }

            bool result = ComBoBapNuocBUS.Instance.ThemCombo(ten, gia);
            if (result)
                MessageBox.Show("Thêm combo thành công!");
            else
                MessageBox.Show("Thêm thất bại!");

            LoadComboList();
        }

        private void btnUpdatePopcorn_Click(object sender, EventArgs e)
        {
            if (dtgvPopcorn.SelectedCells.Count == 0)
                return;

            string ma = txtMaCbo.Text;
            string ten = txtTenCbo.Text;
            string giaText = txtGiaCbo.Text;

            if (!int.TryParse(giaText, out int gia))
            {
                MessageBox.Show("Giá phải là số!");
                return;
            }

            bool result = ComBoBapNuocBUS.Instance.SuaCombo(ma, ten, gia);
            MessageBox.Show(result ? "Sửa thành công!" : "Sửa thất bại!");
            LoadComboList();
        }

        private void btnDeletePopcorn_Click(object sender, EventArgs e)
        {
            if (dtgvPopcorn.SelectedCells.Count == 0)
                return;

            string ma = dtgvPopcorn.SelectedCells[0].OwningRow.Cells["MaCombo"].Value.ToString();
            DialogResult confirm = MessageBox.Show("Xóa combo này?", "Xác nhận", MessageBoxButtons.YesNo);

            if (confirm == DialogResult.Yes)
            {
                bool result = ComBoBapNuocBUS.Instance.XoaCombo(ma);
                MessageBox.Show(result ? "Xóa thành công!" : "Xóa thất bại!");
                LoadComboList();
            }
        }
    }
}
