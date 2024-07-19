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
    public partial class KhachHang : Form
    {
        public KhachHang()
        {
            InitializeComponent();
        }

        ConnectDataBase ConnectDB = new ConnectDataBase();
        private void KhachHang_Load(object sender, EventArgs e)
        {
            dgvKhachHang.DataSource = ConnectDB.dsKhachHang();
        }

        public void Load_DL()
        {
            dgvKhachHang.DataSource = ConnectDB.dsKhachHang();
        }

        public bool KT_rong()
        {
            if (txtMaKH.Text == "")
                return false;
            if (txtHoTen.Text == "")
                return false;
            if (txtDiaChi.Text == "")
                return false;
            if (txtCCCD.Text == "")
                return false;
            if (txtSDT.Text == "")
                return false;
            if (txtGhiChu.Text == "")
                return false;
            return true;
        }

        public void Reset()
        {
            txtMaKH.Text = "";
            txtHoTen.Text = "";
            txtDiaChi.Text = "";
            txtCCCD.Text = "";
            txtSDT.Text = "";
            txtGhiChu.Text = "";
            txtMaKH.Focus();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            if (!KT_rong())
            {
                MessageBox.Show("Chưa nhập đủ thông tin!", "Thông báo");
                return;
            }
            if (ConnectDB.CheckKH(txtMaKH.Text.Trim()))
            {
                MessageBox.Show("Mã khách hàng đã tồn tại, hãy nhập lại!", "Thông báo");
                txtMaKH.Focus();
                return;
            }
            ConnectDB.AddKH(txtMaKH.Text.Trim().ToUpper(), txtHoTen.Text, txtDiaChi.Text, txtCCCD.Text, txtSDT.Text, txtGhiChu.Text);
            Load_DL();
            Reset();
        }

        private void Fix_Click(object sender, EventArgs e)
        {
            if (!ConnectDB.CheckKH(txtMaKH.Text.Trim()))
            {
                MessageBox.Show("Chưa chọn khách hàng cần sửa thông tin! ", "Thông báo");
                return;
            }
            txtMaKH.Enabled = false;
            Add.Enabled = false;
            Del.Enabled = false;
            txtHoTen.Focus();
        }

        private void Del_Click(object sender, EventArgs e)
        {
            if (!ConnectDB.CheckKH(txtMaKH.Text.Trim()))
            {
                MessageBox.Show("Mã khách hàng không tồn tại, hãy kiểm tra lại mã", "Thông báo");
                return;
            }
            if (MessageBox.Show("Có chắc chắn xóa không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                ConnectDB.DeleteKH(txtMaKH.Text.Trim());
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
            ConnectDB.ChangeKH(txtMaKH.Text.Trim().ToUpper(), txtHoTen.Text, txtDiaChi.Text, txtCCCD.Text, txtSDT.Text, txtGhiChu.Text);
            Load_DL();
            txtMaKH.Enabled = true;
            Add.Enabled = true;
            Del.Enabled = true;
        }

        private void Skip_Click(object sender, EventArgs e)
        {
            txtMaKH.Enabled = true;
            Add.Enabled = true;
            Del.Enabled = true;
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Có chắc chắn thoát không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                this.Close();
        }

        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            if (i < 0)
            {
                Reset();
                return;
            }
            DataGridViewRow row = new DataGridViewRow();
            row = dgvKhachHang.Rows[i];
            txtMaKH.Text = row.Cells[0].Value.ToString();
            txtHoTen.Text = row.Cells[1].Value.ToString();
            txtDiaChi.Text = row.Cells[2].Value.ToString();
            txtCCCD.Text = row.Cells[3].Value.ToString();
            txtSDT.Text = row.Cells[4].Value.ToString();
            txtGhiChu.Text = row.Cells[5].Value.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
