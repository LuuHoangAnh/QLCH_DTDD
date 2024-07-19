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
    public partial class TimKiemHoaDonBan : Form
    {
        public TimKiemHoaDonBan()
        {
            InitializeComponent();
        }
        ConnectDataBase ConnectDB = new ConnectDataBase();
        private void Search_Click(object sender, EventArgs e)
        {
            DataTable dtResult = ConnectDB.TimKiemHoaDonBan(MaHD.Text.Trim().ToUpper());

            if (dtResult != null && dtResult.Rows.Count > 0 && dtResult.Rows[0] != null)
            {
                // Bạn có thể thực hiện hành động cụ thể ở đây
                dgvTimKiemHoaDonBan.DataSource = ConnectDB.TimKiemHoaDonBan(MaHD.Text.Trim().ToUpper());
            }
            else
            {
                MessageBox.Show("Mã hóa đơn không tồn tại!!", "Thông báo");
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn muốn thoát?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                Application.Exit();
        }
    }
}
