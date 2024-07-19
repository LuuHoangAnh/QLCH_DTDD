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
    public partial class TimKiemKhachHang : Form
    {
        public TimKiemKhachHang()
        {
            InitializeComponent();
        }
        ConnectDataBase ConnectDB = new ConnectDataBase();

        bool kt = false;
        private void Change_Click(object sender, EventArgs e)
        {
            if (!kt)
            {
                KhachHang form2 = new KhachHang();
                form2.Show();
                kt = true;
                form2.FormClosed += (s, args) => { kt = false; };
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn muốn thoát?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                Application.Exit();
        }

        private void Search_Click(object sender, EventArgs e)
        {
            DataTable dtResult = ConnectDB.TimKiemKhachHang(MaKH.Text.Trim().ToUpper());

            if (dtResult != null && dtResult.Rows.Count > 0 && dtResult.Rows[0] != null)
            {
                // Bạn có thể thực hiện hành động cụ thể ở đây
                dgvTimKiemKhachHang.DataSource = ConnectDB.TimKiemKhachHang(MaKH.Text.Trim().ToUpper());
            }
            else
            {
                MessageBox.Show("Mã khách hàng không hợp lệ!!", "Thông báo");
            }

        }

    }
}
