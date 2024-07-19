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
    public partial class PhieuMuaHang : Form
    {
        public PhieuMuaHang()
        {
            InitializeComponent();
        }
        ConnectDataBase ConnectDB = new ConnectDataBase();
        //combobox nhan vien
        public void LoadDataComboBoxNV()
        {
            MaNV.Items.Clear();
            List<string> data = ConnectDB.PhieuMuaHangCBNhanVien();

            //Gắn dữ liệu từ list vào combo box
            MaNV.Items.AddRange(data.ToArray());
        }
        private void PhieuMuaHang_Load(object sender, EventArgs e)
        {
            TenNV.Enabled = false;
            dgvPhieuMuaHang.DataSource = ConnectDB.PhieuMuaHang();
            LoadDataComboBoxNV();
        }
        public void Load_DL()
        {
            TenNV.Enabled = false;
            dgvPhieuMuaHang.DataSource = ConnectDB.PhieuMuaHang();
            LoadDataComboBoxNV();
        }
        private void MaNV_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string SelectMaNV = MaNV.SelectedItem.ToString();
            string tennv = ConnectDB.LoadPMHTenNV(SelectMaNV);
            TenNV.Text = tennv;
        }
        public bool KT_rong()
        {
            if (SoPhieuMua.Text == "")
                return false;
            if (TenNhaCungCap.Text == "")
                return false;
            if (MaNV.Text == "")
                return false;
            return true;
        }
        public void Reset()
        {
            MaNV.Text = "";
            TenNV.Text = "";
            TenNhaCungCap.Text = "";
            SoPhieuMua.Focus();
        }
        private void dgvPhieuMuaHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            if (i < 0)
            {
                Reset();
                return;
            }
            DataGridViewRow row = new DataGridViewRow();
            row = dgvPhieuMuaHang.Rows[i];
            SoPhieuMua.Text = row.Cells[0].Value.ToString();
            MaNV.Text = row.Cells[1].Value.ToString();
            TenNV.Text = row.Cells[2].Value.ToString();
            TenNhaCungCap.Text = row.Cells[3].Value.ToString();
            Ngay.Text = row.Cells[4].Value.ToString();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn muốn thoát?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                Application.Exit();
        }

        private void Skip_Click(object sender, EventArgs e)
        {
            Add.Enabled = true;
            Del.Enabled = true;
            SoPhieuMua.Enabled = true;
        }

        private void Change_Click(object sender, EventArgs e)
        {
            if (!ConnectDB.CheckPhieuMuaHang(SoPhieuMua.Text.Trim()))
            {
                MessageBox.Show("Chưa chọn phiếu mua cần sửa thông tin! ", "Thông báo");
                return;
            }
            Add.Enabled = false;
            Del.Enabled = false;
            SoPhieuMua.Enabled = false;
        }

        private void Save_Click(object sender, EventArgs e)
        {
            if (!KT_rong())
            {
                MessageBox.Show("Chưa nhập đủ thông tin", "Thông báo");
                return;
            }
            ConnectDB.ChangePhieuMuaHang(SoPhieuMua.Text.Trim().ToUpper(), MaNV.Text, DateTime.Parse(Ngay.Text), TenNhaCungCap.Text);
            Load_DL();
            Add.Enabled = true;
            Del.Enabled = true;
            SoPhieuMua.Enabled = true;
        }

        private void Add_Click(object sender, EventArgs e)
        {
            if (!KT_rong())
            {
                MessageBox.Show("Chưa nhập đủ thông tin!", "Thông báo");
                return;
            }
            if (ConnectDB.CheckPhieuMuaHang(SoPhieuMua.Text.Trim()))
            {
                MessageBox.Show("Số phiếu mua đã tồn tại, hãy nhập lại!", "Thông báo");
                MaNV.Focus();
                return;
            }
            ConnectDB.AddPhieuMuaHang(SoPhieuMua.Text.Trim().ToUpper(), MaNV.Text, DateTime.Parse(Ngay.Text), TenNhaCungCap.Text);
            Load_DL();
            Reset();
        }

        private void ChiTietPhieuMuaHang_Click(object sender, EventArgs e)
        {
            string sophieumua = SoPhieuMua.Text.Trim().ToUpper();
            //kiểm tra xem đã chọn hóa đơn nào trong Combobox chưa
            if (!string.IsNullOrEmpty(sophieumua))
            {
                //tạo và hiển thị form chi tiết hóa đơn với mã hóa đơn đã chọn
                ChiTietPhieuMua formCTphieumua = new ChiTietPhieuMua(SoPhieuMua.Text);
                formCTphieumua.Show();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một phiếu mua hàng để xem chi tiết!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ThanhToan_Click(object sender, EventArgs e)
        {
            string sophieumua = SoPhieuMua.Text.Trim().ToUpper();
            //kiểm tra xem đã chọn hóa đơn nào trong Combobox chưa
            if (!string.IsNullOrEmpty(sophieumua))
            {
                //tạo và hiển thị form thanh toán với mã hóa đơn đã chọn
                HoaDonMua formHoaDonMua = new HoaDonMua(SoPhieuMua.Text);
                formHoaDonMua.Show();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một phiếu mua hàng để thanh toán!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Del_Click(object sender, EventArgs e)
        {
            if (!ConnectDB.CheckPhieuMuaHang(SoPhieuMua.Text.Trim()))
            {
                MessageBox.Show("Số phiếu mua không tồn tại, hãy kiểm tra lại mã", "Thông báo");
                return;
            }
            if (MessageBox.Show("Có chắc chắn xóa không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                ConnectDB.DelPhieuMuaHang(SoPhieuMua.Text.Trim());
                Load_DL();
                Reset();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
