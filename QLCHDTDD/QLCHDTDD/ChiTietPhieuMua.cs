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
    public partial class ChiTietPhieuMua : Form
    {
        public ChiTietPhieuMua(string sophieumua)
        {
            InitializeComponent();
            SoPhieuMua.Text = sophieumua;
            Load_DL();
            LoadDataComboBox();
            SoPhieuMua.Enabled = false;
        }
        ConnectDataBase ConnectDB = new ConnectDataBase();

        //combobox mat hang
        public void LoadDataComboBox()
        {
            MaMH.Items.Clear();
            List<string> data = ConnectDB.DataCBCTPhieuMua();

            //Gắn dữ liệu từ list vào combo box
            MaMH.Items.AddRange(data.ToArray());
        }
        int i = 0;
        public void Load_DL()
        {
            dgvChiTietPhieuMua.DataSource = ConnectDB.ChiTietPhieuMua(SoPhieuMua.Text);
            TenMH.Enabled = false;
            SoLuong.Enabled = true;
            DonGiaMua.Enabled = false;
            Save.Enabled = false;
            SoPhieuMua.Enabled = false;
            Skip.Enabled = false;
            LoadDataComboBox();
            i = 1;
            TinhTongTien();
        }
        public bool KT_rong()
        {
            if (SoPhieuMua.Text == "")
                return false;
            if (MaMH.Text == "")
                return false;
            return true;
        }
        public void Reset()
        {
            MaMH.Text = "";
            SoLuong.Text = "";
            DonGiaMua.Text = "";
            TenMH.Text = "";
            SoPhieuMua.Focus();
        }
        private void TinhTongTien()
        {
            if (i == 0) return;
            decimal Tong = 0;
            DataTable dt = (DataTable)dgvChiTietPhieuMua.DataSource;
            foreach (DataRow row in dt.Rows)
            {
                if (row["ThanhTien"].ToString() != null && row["ThanhTien"].ToString() != "")
                {
                    decimal ThanhTien;
                    if (decimal.TryParse(row["ThanhTien"].ToString(), out ThanhTien))
                    {
                        Tong += ThanhTien;
                    }
                }
            }
            TongTien.Text = Tong.ToString();
        }


        private void MaMH_SelectedIndexChanged(object sender, EventArgs e)
        {
            string SelectMaMH = MaMH.SelectedItem.ToString();
            string tenmathang = ConnectDB.LoadCTPMTenMH(SelectMaMH);
            string dongiaban = ConnectDB.LoadCTPMDonGiaMH(SelectMaMH);
            string soluong = ConnectDB.LoadCTPMSLMH(SelectMaMH);
            TenMH.Text = tenmathang;
            DonGiaMua.Text = dongiaban;
            SoLuong.Text = soluong;
        }

        private void Change_Click(object sender, EventArgs e)
        {
            Add.Enabled = false;
            Del.Enabled = false;
            Save.Enabled = true;
            Skip.Enabled = true;
        }

        private void Skip_Click(object sender, EventArgs e)
        {
            Add.Enabled = true;
            Del.Enabled = true;
            Save.Enabled = false;
            Skip.Enabled = false;
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn muốn thoát?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                this.Close();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            if (!KT_rong())
            {
                MessageBox.Show("Chưa nhập đủ thông tin!", "Thông báo");
                return;
            }
            ConnectDB.AddCTPhieuMuaHang(SoPhieuMua.Text.Trim().ToUpper(), MaMH.Text, DonGiaMua.Text, SoLuong.Text);
            Load_DL();
            Reset();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            if (!KT_rong())
            {
                MessageBox.Show("Chưa nhập đủ thông tin", "Thông báo");
                return;
            }
            int soluong = ConnectDB.GetSL(MaMH.Text);   // số lượng tồn kho
            int soluong2 = int.Parse(SoLuong.Text.Trim()) - sl; //số lượng sau khi cập nhật
            ConnectDB.ChangeCTPhieuMuaHang(MaMH.Text.Trim().ToUpper(), SoLuong.Text, TongTien.Text, SoPhieuMua.Text, soluong2.ToString());
            Load_DL();
            Add.Enabled = true;
            Del.Enabled = true;
            Save.Enabled = false;
            Skip.Enabled = false;
        }

        private void Del_Click(object sender, EventArgs e)
        {
            if (!ConnectDB.CheckChiTietPhieuMua(MaMH.Text.Trim()))
            {
                MessageBox.Show("Mã mặt hàng không tồn tại, hãy kiểm tra lại mã", "Thông báo");
                return;
            }
            if (MessageBox.Show("Có chắc chắn xóa không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                ConnectDB.DelCTPhieuMuaHang(MaMH.Text.Trim(), SoPhieuMua.Text, SoLuong.Text);
                Load_DL();
                Reset();
            }
        }
        int sl = 0;
        private void dgvChiTietPhieuMua_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            if (i < 0)
            {
                Reset();
                return;
            }
            DataGridViewRow row = new DataGridViewRow();
            row = dgvChiTietPhieuMua.Rows[i];
            SoPhieuMua.Text = row.Cells[0].Value.ToString();
            MaMH.Text = row.Cells[1].Value.ToString();
            TenMH.Text = row.Cells[2].Value.ToString();
            DonGiaMua.Text = row.Cells[3].Value.ToString();
            SoLuong.Text = row.Cells[4].Value.ToString();
            if (SoPhieuMua.Text == "")
                return;
            sl = int.Parse(SoLuong.Text.Trim());
        }

        private void dgvChiTietPhieuMua_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            TinhTongTien();
        }

    }
}
