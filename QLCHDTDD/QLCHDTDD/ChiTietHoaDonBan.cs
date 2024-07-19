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
    public partial class ChiTietHoaDonBan : Form
    {
        public ChiTietHoaDonBan(string maHoaDon)
        {
            InitializeComponent();
            MaHD.Text = maHoaDon;
            Load_DL();
            LoadDataComboBox();
            MaHD.Enabled = false;
        }

        ConnectDataBase ConnectDB = new ConnectDataBase();


        //combobox mat hang
        public void LoadDataComboBox()
        {
            MaMH.Items.Clear();
            List<string> data = ConnectDB.DataCBCTHDMatHang();

            //Gắn dữ liệu từ list vào combo box
            MaMH.Items.AddRange(data.ToArray());
        }
        private void MaMH_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string SelectMaMH = MaMH.SelectedItem.ToString();
            string tenmathang = ConnectDB.LoadCTHDTenMH(SelectMaMH);
            string dongiaban = ConnectDB.LoadCTHDDonGiaMH(SelectMaMH);
            string soluong = ConnectDB.LoadCTHDSLMH(SelectMaMH);
            TenMH.Text = tenmathang;
            DonGia.Text = dongiaban;
            SoLuong.Text = soluong;
        }
        int i = 0;
        public void Load_DL()
        {

            dgvCTHoaDonBan.DataSource = ConnectDB.dsCTHoaDonBan(MaHD.Text);
            TenMH.Enabled = false;
            SoLuong.Enabled = true;
            DonGia.Enabled = false;
            Save.Enabled = false;
            Skip.Enabled = false;
            LoadDataComboBox();
            i = 1;
            TinhTongTien();
        }
        public void Reset()
        {
            MaMH.Text = "";
            SoLuong.Text = "";
            DonGia.Text = "";
            TenMH.Text = "";
            MaHD.Focus();
        }
        public bool KT_rong()
        {
            if (SoLuong.Text == "")
                return false;
            if (MaMH.Text == "")
                return false;
            return true;
        }
      /*  public bool KT_soluong()
        {
            if ((int)SoLuong.Text )
                MessageBox.Show("số lượng trong kho hiện không đủ!!", "Thông báo");
            return true;
        }
      */
        private void TinhTongTien()
        {
            if (i == 0) return;
            decimal Tong = 0;
            DataTable dt = (DataTable)dgvCTHoaDonBan.DataSource;
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
        int sl = 0;
        private void dgvCTHoaDonBan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            if (i < 0)
            {
                Reset();
                return;
            }
            DataGridViewRow row = new DataGridViewRow();
            row = dgvCTHoaDonBan.Rows[i];
            MaHD.Text = row.Cells[0].Value.ToString();
            MaMH.Text = row.Cells[1].Value.ToString();
            TenMH.Text = row.Cells[2].Value.ToString();
            DonGia.Text = row.Cells[4].Value.ToString();
            SoLuong.Text = row.Cells[3].Value.ToString();
            if (MaHD.Text == "")
                return;
            sl = int.Parse(SoLuong.Text.Trim());
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn muốn thoát?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                this.Close();
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

        private void dgvCTHoaDonBan_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            TinhTongTien();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            if (!KT_rong())
            {
                MessageBox.Show("Chưa nhập đủ thông tin!", "Thông báo");
                return;
            }
            int soluong = ConnectDB.GetSL(MaMH.Text);
            if ( int.Parse(SoLuong.Text.Trim()) > soluong)
            {
                MessageBox.Show("Hiện tại số lượng trong kho hiện không đủ", "Thông báo");
                return;
            }
            ConnectDB.AddCTHDMH(MaHD.Text.Trim().ToUpper(), MaMH.Text, SoLuong.Text);
            Load_DL();
            Reset();
        }

        private void Del_Click(object sender, EventArgs e)
        {
            if (!ConnectDB.CheckCTHoaDonBan(MaMH.Text.Trim()))
            {
                MessageBox.Show("Mã mặt hàng không tồn tại, hãy kiểm tra lại mã", "Thông báo");
                return;
            }
            if (MessageBox.Show("Có chắc chắn xóa không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                ConnectDB.DelCTHoaDonBan(MaMH.Text.Trim().ToUpper(), MaHD.Text, SoLuong.Text);
                Load_DL();
                Reset();
            }
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
            if ((int.Parse(SoLuong.Text.Trim()) - sl ) >  soluong)
            {
                MessageBox.Show("Hiện tại số lượng trong kho hiện không đủ", "Thông báo");
                return;
            }
            ConnectDB.ChangeCTHoaDonBan(MaMH.Text.Trim().ToUpper(), SoLuong.Text, MaHD.Text, TongTien.Text, soluong2.ToString());
            Load_DL();
            Add.Enabled = true;
            Del.Enabled = true;
            Save.Enabled = false;
            Skip.Enabled = false;
        }
    }
}
