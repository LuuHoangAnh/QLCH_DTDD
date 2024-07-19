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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        ConnectDataBase ConnectDB = new ConnectDataBase();
        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void LoginAcount_Click(object sender, EventArgs e)
        {
            if (TenDN.Text == "")
            {
                MessageBox.Show("Chua nhap ten dang nhap!");
                TenDN.Focus();
                return;
            }

            if (MK.Text == "")
            {
                MessageBox.Show("chua nhap mat khau!");
                MK.Focus();
                return;
            }

            if (!ConnectDB.CheackAccount(TenDN.Text.Trim(), MK.Text))
            {
                MessageBox.Show("Sai Ten Dang nhap hoac mat khau! ");
                return;
            }
            MessageBox.Show("Wellcome! ");
            /*
            Main frm = new Main(TenDN.Text);
            frm.Show();
            this.Hide();
            */
            Menu frm = new Menu();
            frm.Show();
            this.Hide();
        }
    }
}
