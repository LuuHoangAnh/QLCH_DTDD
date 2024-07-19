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
    public partial class ThongKe : Form
    {
        public ThongKe()
        {
            InitializeComponent();
        }
        ConnectDataBase ConnectDB = new ConnectDataBase();
        int i = 0;
        private void ThongKe_Load(object sender, EventArgs e)
        {
            dgvDoanhThu.DataSource = ConnectDB.ThongKeDoanhThu();
            i = 1;
            TinhTongTien();
            Load_DL();
        }
        private void TinhTongTien()
        {
            if (i == 0) return;
            decimal Tong = 0;
            DataTable dt = (DataTable)dgvDoanhThu.DataSource;
            foreach (DataRow row in dt.Rows)
            {
                if (row["TongThu"].ToString() != null && row["TongThu"].ToString() != "")
                {
                    decimal ThanhTien;
                    if (decimal.TryParse(row["TongThu"].ToString(), out ThanhTien))
                    {
                        Tong += ThanhTien;
                    }
                }
            }
            TongTien.Text = Tong.ToString();
        }
        public void Load_DL()
        {
            dgvDoanhThu.DataSource = ConnectDB.ThongKeDoanhThu();
            int i = 1;
            TinhTongTien();
        }
        private void dgvDoanhThu_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            TinhTongTien();
        }
    }
}
