namespace QLCHDTDD
{
    public partial class NhanVien : Form
    {
        public NhanVien()
        {
            InitializeComponent();
        }

        ConnectDataBase ConnectDB = new ConnectDataBase();
        private void NhanVien_Load(object sender, EventArgs e)
        {
            dgvNhanVien.DataSource = ConnectDB.dsNhanVien();
        }

        public void Load_DL()
        {
            dgvNhanVien.DataSource = ConnectDB.dsNhanVien();
        }

        public bool KT_rong()
        {
            if (MaNV.Text == "")
                return false;
            if (HoTen.Text == "")
                return false;
            if (DiaChi.Text == "")
                return false;
            if (SoDienThoai.Text == "")
                return false;
            return true;
        }

        public void Reset()
        {
            MaNV.Text = "";
            HoTen.Text = "";
            NgaySinh.Text = "";
            rdbNam.Checked = true;
            DiaChi.Text = "";
            SoDienThoai.Text = "";
            MaNV.Focus();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            if (!KT_rong())
            {
                MessageBox.Show("Chưa nhập đủ thông tin!", "Thông báo");
                return;
            }
            if (ConnectDB.CheckNV(MaNV.Text.Trim()))
            {
                MessageBox.Show("Mã nhân viên đã tồn tại, hãy nhập lại!", "Thông báo");
                MaNV.Focus();
                return;
            }
            string gt;
            if (rdbNam.Checked)
                gt = "Nam";
            else
                gt = "Nữ";
            ConnectDB.AddInformation(MaNV.Text.Trim().ToUpper(), HoTen.Text, DateTime.Parse(NgaySinh.Text), gt, DiaChi.Text, SoDienThoai.Text);
            Load_DL();
            Reset();
        }

        private void Fix_Click(object sender, EventArgs e)
        {
            if (!ConnectDB.CheckNV(MaNV.Text.Trim()))
            {
                MessageBox.Show("Chưa chọn nhân viên cần sửa thông tin! ", "Thông báo");
                return;
            }
            MaNV.Enabled = false;
            Add.Enabled = false;
            Del.Enabled = false;
            HoTen.Focus();
        }

        private void Del_Click(object sender, EventArgs e)
        {
            if (!ConnectDB.CheckNV(MaNV.Text.Trim()))
            {
                MessageBox.Show("Mã nhân viên không tồn tại, hãy kiểm tra lại mã", "Thông báo");
                return;
            }
            if (MessageBox.Show("Có chắc chắn xóa không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                ConnectDB.DeleteInfomation(MaNV.Text.Trim());
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
            string gt;
            if (rdbNam.Checked)
                gt = "Nam";
            else
                gt = "Nữ";
            ConnectDB.ChangeInformation(MaNV.Text.Trim().ToUpper(), HoTen.Text, DateTime.Parse(NgaySinh.Text), gt, DiaChi.Text, SoDienThoai.Text);
            Load_DL();
            MaNV.Enabled = true;
            Add.Enabled = true;
            Del.Enabled = true;
        }

        private void Skip_Click(object sender, EventArgs e)
        {
            MaNV.Enabled = true;
            Add.Enabled = true;
            Del.Enabled = true;
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Có chắc chắn thoát không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                this.Close();
        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            if (i < 0)
            {
                Reset();
                return;
            }
            DataGridViewRow row = new DataGridViewRow();
            row = dgvNhanVien.Rows[i];
            MaNV.Text = row.Cells[0].Value.ToString();
            HoTen.Text = row.Cells[1].Value.ToString();
            NgaySinh.Text = row.Cells[2].Value.ToString();
            string gt = row.Cells[3].Value.ToString();
            if (gt == "Nam")
                rdbNam.Checked = true;
            else
                rdbNu.Checked = true;
            DiaChi.Text = row.Cells[4].Value.ToString();
            SoDienThoai.Text = row.Cells[5].Value.ToString();
        }
    }
}