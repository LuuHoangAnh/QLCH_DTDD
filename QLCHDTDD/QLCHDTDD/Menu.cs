using Microsoft.Identity.Client.Kerberos;
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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private Form currentFormChild;
        private void OpenChildForm(Form childForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel_body.Controls.Add(childForm);
            panel_body.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            pictureBox2.Hide();
        }
        private void frmMatHang_Click(object sender, EventArgs e)
        {
            OpenChildForm(new MatHang());
            label1.Text = frmMatHang.Text;
        }

        private void frmKhachHang_Click(object sender, EventArgs e)
        {
            OpenChildForm(new KhachHang());
            label1.Text = frmKhachHang.Text;
        }

        private void frmNhanVien_Click(object sender, EventArgs e)
        {
            OpenChildForm(new NhanVien());
            label1.Text = frmNhanVien.Text;
        }

        private void frmNhapHang_Click(object sender, EventArgs e)
        {
            OpenChildForm(new PhieuMuaHang());
            label1.Text = frmNhapHang.Text;
        }

        private void frmBanHang_Click(object sender, EventArgs e)
        {
            OpenChildForm(new HoaDonBan());
            label1.Text = frmBanHang.Text;
        }

        private void frmTKKhachHang_Click(object sender, EventArgs e)
        {
            OpenChildForm(new TimKiemKhachHang());
            label1.Text = frmTKKhachHang.Text;
        }

        private void frmTKMatHang_Click(object sender, EventArgs e)
        {
            OpenChildForm(new TimKiemMatHang());
            label1.Text = frmTKMatHang.Text;
        }

        private void frmTKHoaDonBan_Click(object sender, EventArgs e)
        {
            OpenChildForm(new TimKiemHoaDonBan());
            label1.Text = frmTKHoaDonBan.Text;
        }

        private void frmThongKe_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ThongKe());
            label1.Text = frmThongKe.Text;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            label1.Text = "LOVE PHONE STORE";
            pictureBox2.Show();
        }
    }
}
