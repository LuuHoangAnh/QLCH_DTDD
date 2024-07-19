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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        public Main(string Acoount)
        {
            InitializeComponent();
            mnAcount.Text = Acoount;
        }
        ConnectDataBase ConnectDB = new ConnectDataBase();
        private void quảnLýNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool kt = false;
            foreach (Form form in this.MdiChildren)
            {
                if (form.Name.Equals("NhanVien"))
                {
                    form.Activate();
                    kt = true;
                    break;
                }
            }
            if (!kt)
            {
                NhanVien frmNhanVien = new NhanVien();
                frmNhanVien.MdiParent = this;
                frmNhanVien.Show();
            }
        }

        private void quảnLýMặtHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool kt = false;
            foreach (Form form in this.MdiChildren)
            {
                if (form.Name.Equals("MatHang"))
                {
                    form.Activate();
                    kt = true;
                    break;
                }
            }
            if (!kt)
            {
                MatHang frmMatHang = new MatHang();
                frmMatHang.MdiParent = this;
                frmMatHang.Show();
            }
        }

        private void quảnLýDanhMụcKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool kt = false;
            foreach (Form form in this.MdiChildren)
            {
                if (form.Name.Equals("KhachHang"))
                {
                    form.Activate();
                    kt = true;
                    break;
                }
            }
            if (!kt)
            {
                KhachHang frmKhachHang = new KhachHang();
                frmKhachHang.MdiParent = this;
                frmKhachHang.Show();
            }
        }
        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn muốn thoát?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                Application.Exit();
        }

        private void quảnLýNhậpHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool kt = false;
            foreach (Form form in this.MdiChildren)
            {
                if (form.Name.Equals("PhieuMuaHang"))
                {
                    form.Activate();
                    kt = true;
                    break;
                }
            }
            if (!kt)
            {
                PhieuMuaHang frmPhieuMuaHang = new PhieuMuaHang();
                frmPhieuMuaHang.MdiParent = this;
                frmPhieuMuaHang.Show();
            }
        }

        private void quảnLýBánHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool kt = false;
            foreach (Form form in this.MdiChildren)
            {
                if (form.Name.Equals("HoaDonBan"))
                {
                    form.Activate();
                    kt = true;
                    break;
                }
            }
            if (!kt)
            {
                HoaDonBan frmhoadonban = new HoaDonBan();
                frmhoadonban.MdiParent = this;
                frmhoadonban.Show();
            }
        }

        private void thốngKêBáoCáoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool kt = false;
            foreach (Form form in this.MdiChildren)
            {
                if (form.Name.Equals("ThongKe"))
                {
                    form.Activate();
                    kt = true;
                    break;
                }
            }
            if (!kt)
            {
                ThongKe frmThongKe = new ThongKe();
                frmThongKe.MdiParent = this;
                frmThongKe.Show();
            }
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool kt = false;
            foreach (Form form in this.MdiChildren)
            {
                if (form.Name.Equals("TimKiemKhachHang"))
                {
                    form.Activate();
                    kt = true;
                    break;
                }
            }
            if (!kt)
            {
                TimKiemKhachHang frmTKKhach = new TimKiemKhachHang();
                frmTKKhach.MdiParent = this;
                frmTKKhach.Show();
            }
        }

        private void mặtHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool kt = false;
            foreach (Form form in this.MdiChildren)
            {
                if (form.Name.Equals("TimKiemMatHang"))
                {
                    form.Activate();
                    kt = true;
                    break;
                }
            }
            if (!kt)
            {
                TimKiemMatHang frmTKMatHang = new TimKiemMatHang();
                frmTKMatHang.MdiParent = this;
                frmTKMatHang.Show();
            }
        }

        private void hóaĐơnBánToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool kt = false;
            foreach (Form form in this.MdiChildren)
            {
                if (form.Name.Equals("TimKiemHoaDonBan"))
                {
                    form.Activate();
                    kt = true;
                    break;
                }
            }
            if (!kt)
            {
                TimKiemHoaDonBan frmTKHoaDon = new TimKiemHoaDonBan();
                frmTKHoaDon.MdiParent = this;
                frmTKHoaDon.Show();
            }
        }
    }
}
