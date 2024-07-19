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
    public partial class MatHang : Form
    {
        public MatHang()
        {
            InitializeComponent();
        }

        ConnectDataBase ConnectDB = new ConnectDataBase();

        private void MatHang_Load(object sender, EventArgs e)
        {
            dgvMatHang.DataSource = ConnectDB.dsMatHang();
        }

        public void Load_DL()
        {
            dgvMatHang.DataSource = ConnectDB.dsMatHang();
        }
        public bool KT_rong()
        {
            if (MaMH.Text == "")
                return false;
            if (TenMH.Text == "")
                return false;
            if (ThongSo.Text == "")
                return false;
            if (MauSac.Text == "")
                return false;
            if (CauHinh.Text == "")
                return false;
            if (Pin.Text == "")
                return false;
            if (DonGiaBan.Text == "")
                return false;
            if (PhuKien.Text == "")
                return false;
            if (KhuyenMai.Text == "")
                return false;
            if (hangsx.Text == "")
                return false;
            if (xuatxu.Text == "")
                return false;
            return true;
        }

        public void Reset()
        {
            MaMH.Text = "";
            TenMH.Text = "";
            ThongSo.Text = "";
            MauSac.Text = "";
            CauHinh.Text = "";
            Pin.Text = "";
            DonGiaBan.Text = "";
            PhuKien.Text = "";
            KhuyenMai.Text = "";
            hangsx.Text = "";
            xuatxu.Text = "";
            MaMH.Focus();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            {
                if (!KT_rong())
                {
                    MessageBox.Show("Chưa nhập đủ thông tin!", "Thông báo");
                    return;
                }
                if (ConnectDB.CheckMH(MaMH.Text.Trim()))
                {
                    MessageBox.Show("Mã mặt hàng đã tồn tại, hãy nhập lại!", "Thông báo");
                    MaMH.Focus();
                    return;
                }
                ConnectDB.AddMH(MaMH.Text.Trim().ToUpper(), TenMH.Text, ThongSo.Text, MauSac.Text, CauHinh.Text, Pin.Text, decimal.Parse(DonGiaBan.Text), PhuKien.Text, KhuyenMai.Text, hangsx.Text, xuatxu.Text);
                Load_DL();
                Reset();
            }
        }

        private void Fix_Click(object sender, EventArgs e)
        {
            if (!ConnectDB.CheckMH(MaMH.Text.Trim()))
            {
                MessageBox.Show("Chưa chọn mặt hàng cần sửa thông tin! ", "Thông báo");
                return;
            }
            MaMH.Enabled = false;
            Add.Enabled = false;
            Del.Enabled = false;
            TenMH.Focus();
        }

        private void Del_Click(object sender, EventArgs e)
        {
            if (!ConnectDB.CheckMH(MaMH.Text.Trim()))
            {
                MessageBox.Show("Mã mặt hàng không tồn tại, hãy kiểm tra lại mã", "Thông báo");
                return;
            }
            if (MessageBox.Show("Có chắc chắn xóa không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                ConnectDB.DeleteMH(MaMH.Text.Trim());
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
            ConnectDB.ChangeMH(MaMH.Text.Trim().ToUpper(), TenMH.Text, ThongSo.Text, MauSac.Text, CauHinh.Text, Pin.Text, decimal.Parse(DonGiaBan.Text), PhuKien.Text, KhuyenMai.Text, hangsx.Text, xuatxu.Text);
            Load_DL();
            MaMH.Enabled = true;
            Add.Enabled = true;
            Del.Enabled = true;
        }

        private void Skip_Click(object sender, EventArgs e)
        {
            MaMH.Enabled = true;
            Add.Enabled = true;
            Del.Enabled = true;
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Có chắc chắn thoát không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                this.Close();
        }

        private void dgvMatHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            if (i < 0)
            {
                Reset();
                return;
            }
            DataGridViewRow row = new DataGridViewRow();
            row = dgvMatHang.Rows[i];
            MaMH.Text = row.Cells[0].Value.ToString();
            TenMH.Text = row.Cells[1].Value.ToString();
            ThongSo.Text = row.Cells[2].Value.ToString();
            MauSac.Text = row.Cells[3].Value.ToString();
            CauHinh.Text = row.Cells[4].Value.ToString();
            Pin.Text = row.Cells[5].Value.ToString();
            DonGiaBan.Text = row.Cells[6].Value.ToString();
            PhuKien.Text = row.Cells[7].Value.ToString();
            KhuyenMai.Text = row.Cells[8].Value.ToString();
            hangsx.Text = row.Cells[9].Value.ToString();
            xuatxu.Text = row.Cells[10].Value.ToString();
        }

    }
}
