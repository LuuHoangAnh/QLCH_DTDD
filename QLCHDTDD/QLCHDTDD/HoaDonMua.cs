using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCHDTDD
{
    public partial class HoaDonMua : Form
    {
        public HoaDonMua(string sophieumua)
        {
            InitializeComponent();
            SoPhieuMua.Text = sophieumua;
            Load_DL();
            LoadDataComboBoxNV();
        }
        ConnectDataBase ConnectDB = new ConnectDataBase();

        //combobox nhan vien
        public void LoadDataComboBoxNV()
        {
            MaNV.Items.Clear();
            List<string> data = ConnectDB.HoaDonMuaCBNhanVien();

            //Gắn dữ liệu từ list vào combo box
            MaNV.Items.AddRange(data.ToArray());
        }
        private void MaNV_SelectedIndexChanged(object sender, EventArgs e)
        {
            string SelectMaNV = MaNV.SelectedItem.ToString();
            string tennv = ConnectDB.LoadHDMTenNV(SelectMaNV);
            TenNV.Text = tennv;
        }

        public void Load_DL()
        {
            dgvHoaDonMua.DataSource = ConnectDB.HoaDonMua(SoPhieuMua.Text);
            TenNV.Enabled = false;
            SoPhieuMua.Enabled = false;
            Save.Enabled = false;
            SoPhieuMua.Enabled = false;
            Skip.Enabled = false;
            LoadDataComboBoxNV();
        }

        public bool KT_rong()
        {
            if (MaNV.Text == "")
                return false;
            if (MaDonMua.Text == "")
                return false;
            if (SoPhieuMua.Text == "")
                return false;
            if (GhiChu.Text == "")
                return false;
            return true;
        }
        public void Reset()
        {
            MaNV.Text = "";
            SoPhieuMua.Text = "";
            TenNV.Text = "";
            GhiChu.Text = "";
            MaDonMua.Focus();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            if (!KT_rong())
            {
                MessageBox.Show("Chưa nhập đủ thông tin!", "Thông báo");
                return;
            }
            ConnectDB.AddHoaDonMua(MaDonMua.Text.Trim().ToUpper(), SoPhieuMua.Text, MaNV.Text, DateTime.Parse(NgayMua.Text), GhiChu.Text);
            Load_DL();
            Reset();
        }

        private void Change_Click(object sender, EventArgs e)
        {
            Add.Enabled = false;
            Save.Enabled = true;
        }

        private void Save_Click(object sender, EventArgs e)
        {
            if (!KT_rong())
            {
                MessageBox.Show("Chưa nhập đủ thông tin", "Thông báo");
                return;
            }
            ConnectDB.ChangeHoaDonMua(SoPhieuMua.Text.Trim().ToUpper(), MaDonMua.Text, MaNV.Text, DateTime.Parse(NgayMua.Text), GhiChu.Text);
            Load_DL();
            Add.Enabled = true;
        }

        private void Skip_Click(object sender, EventArgs e)
        {
            Add.Enabled = true;
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn muốn thoát?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                this.Close();
        }

        private void dgvHoaDonMua_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            if (i < 0)
            {
                Reset();
                return;
            }
            DataGridViewRow row = new DataGridViewRow();
            row = dgvHoaDonMua.Rows[i];
            MaDonMua.Text = row.Cells[0].Value.ToString();
            SoPhieuMua.Text = row.Cells[1].Value.ToString();
            MaNV.Text = row.Cells[2].Value.ToString();
            TenNV.Text = row.Cells[3].Value.ToString();
            NgayMua.Text = row.Cells[4].Value.ToString();
            GhiChu.Text = row.Cells[6].Value.ToString();
        }
    }
}
