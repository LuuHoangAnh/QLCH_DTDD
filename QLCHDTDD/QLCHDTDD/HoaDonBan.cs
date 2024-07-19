using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCHDTDD
{
    public partial class HoaDonBan : Form
    {
        public HoaDonBan()
        {
            InitializeComponent();
        }

        ConnectDataBase ConnectDB = new ConnectDataBase();
        //combobox nhan vien
        public void LoadDataComboBoxNV()
        {
            MaNV.Items.Clear();
            List<string> data = ConnectDB.DataCBNhanVien();

            //Gắn dữ liệu từ list vào combo box
            MaNV.Items.AddRange(data.ToArray());
        }
        private void MaNV_SelectedIndexChanged(object sender, EventArgs e)
        {
            string SelectMaNV = MaNV.SelectedItem.ToString();
            string tennv = ConnectDB.LoadTenNV(SelectMaNV);
            TenNV.Text = tennv;
        }
        //combobox khach hang
        public void LoadDataComboBoxKH()
        {
            MaKH.Items.Clear();
            List<string> data = ConnectDB.DataCBKhachHang();
            MaKH.Items.AddRange(data.ToArray());
        }
        private void MaKH_SelectedIndexChanged(object sender, EventArgs e)
        {
            string SelectMaKH = MaKH.SelectedItem.ToString();
            string tenkh = ConnectDB.LoadTenKH(SelectMaKH);
            string cccd = ConnectDB.LoadCCCDKH(SelectMaKH);
            string sdt = ConnectDB.LoadSDTKH(SelectMaKH);
            string diachi = ConnectDB.LoadDiaChiKH(SelectMaKH);
            TenKH.Text = tenkh;
        }
        private void HoaDonBan_Load(object sender, EventArgs e)
        {
            dgvHoaDonBan.DataSource = ConnectDB.dsHoaDonBan();
            TenNV.Enabled = false;
            TenKH.Enabled = false;
            Save.Enabled = false;
            Skip.Enabled = false;
            LoadDataComboBoxKH();
            LoadDataComboBoxNV();
        }
        public void Load_DL()
        {
            dgvHoaDonBan.DataSource = ConnectDB.dsHoaDonBan();
            TenNV.Enabled = false;
            TenKH.Enabled = false;
            Save.Enabled = false;
            Skip.Enabled = false;
            LoadDataComboBoxKH();
            LoadDataComboBoxNV();
        }

        public bool KT_rong()
        {
            if (MaKH.Text == "")
                return false;
            if (MaDonBan.Text == "")
                return false;
            if (MaNV.Text == "")
                return false;
            return true;
        }
        public void Reset()
        {
            MaKH.Text = "";
            TenKH.Text = "";
            MaNV.Text = "";
            TenNV.Text = "";
            GhiChu.Text = "";
            MaDonBan.Focus();
        }
        private void Exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn muốn thoát?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                Application.Exit();
        }
        private void dgvHoaDonBan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            if (i < 0)
            {
                Reset();
                return;
            }
            DataGridViewRow row = new DataGridViewRow();
            row = dgvHoaDonBan.Rows[i];
            MaDonBan.Text = row.Cells[0].Value.ToString();
            NgayBan.Text = row.Cells[5].Value.ToString();
            MaNV.Text = row.Cells[1].Value.ToString();
            TenNV.Text = row.Cells[2].Value.ToString();
            MaKH.Text = row.Cells[3].Value.ToString();
            TenKH.Text = row.Cells[4].Value.ToString();
            GhiChu.Text = row.Cells[7].Value.ToString();
        }

        private void Skip_Click(object sender, EventArgs e)
        {
            MaDonBan.Enabled = true;
            Add.Enabled = true;
            Del.Enabled = true;
            Save.Enabled = false;
            Skip.Enabled = false;
        }

        private void Add_Click(object sender, EventArgs e)
        {
            if (!KT_rong())
            {
                MessageBox.Show("Chưa nhập đủ thông tin!", "Thông báo");
                return;
            }
            if (ConnectDB.CheckHoaDonBan(MaDonBan.Text.Trim()))
            {
                MessageBox.Show("Mã hóa đơn đã tồn tại, hãy nhập lại!", "Thông báo");
                MaNV.Focus();
                return;
            }
            ConnectDB.AddHoaDonBan(MaDonBan.Text.Trim().ToUpper(), MaNV.Text, MaKH.Text, DateTime.Parse(NgayBan.Text), GhiChu.Text);
            Load_DL();
            Reset();
        }

        private void Change_Click(object sender, EventArgs e)
        {
            if (!ConnectDB.CheckHoaDonBan(MaDonBan.Text.Trim()))
            {
                MessageBox.Show("Chưa chọn hóa đơn cần sửa thông tin! ", "Thông báo");
                return;
            }
            MaDonBan.Enabled = false;
            Add.Enabled = false;
            Del.Enabled = false;
            Save.Enabled = true;
            Skip.Enabled = true;
        }

        private void Del_Click(object sender, EventArgs e)
        {
            if (!ConnectDB.CheckHoaDonBan(MaDonBan.Text.Trim()))
            {
                MessageBox.Show("Mã hóa đơn không tồn tại, hãy kiểm tra lại mã", "Thông báo");
                return;
            }
            if (MessageBox.Show("Có chắc chắn xóa không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                ConnectDB.DelHoaDonBan(MaDonBan.Text.Trim());
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
            ConnectDB.ChangeHoaDonBan(MaDonBan.Text.Trim().ToUpper(), MaKH.Text, MaNV.Text, DateTime.Parse(NgayBan.Text), GhiChu.Text);
            Load_DL();
            MaDonBan.Enabled = true;
            Add.Enabled = true;
            Del.Enabled = true;
            Save.Enabled = false;
            Skip.Enabled = false;
        }
        bool kt = false;

        private void XemChiTiet_Click(object sender, EventArgs e)
        {
            string mahoadon = MaDonBan.Text.Trim().ToUpper();
            //kiểm tra xem đã chọn hóa đơn nào trong Combobox chưa
            if (!string.IsNullOrEmpty(mahoadon))
            {
                //tạo và hiển thị form chi tiết hóa đơn với mã hóa đơn đã chọn
                ChiTietHoaDonBan formCThoadonban = new ChiTietHoaDonBan(MaDonBan.Text);
                formCThoadonban.FormClosed += Form2_FormClosed;
                formCThoadonban.Show();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một hóa đơn để xem chi tiết!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgvHoaDonBan_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
        }
        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            ConnectDB.ChangeHoaDonBan(MaDonBan.Text.Trim().ToUpper(), MaKH.Text, MaNV.Text, DateTime.Parse(NgayBan.Text), GhiChu.Text);
            Load_DL();
            MaDonBan.Enabled = true;
            Add.Enabled = true;
            Del.Enabled = true;
            Save.Enabled = false;
            Skip.Enabled = false;
        }
    }
}
