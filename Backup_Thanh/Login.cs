using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Backup_Thanh
{
    public partial class Login : DevExpress.XtraEditors.XtraForm
    {
        public Login()
        {
            InitializeComponent();
        }

      

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txbLoginName.Text.Trim() == "")
            {
                MessageBox.Show("Login name không được trống", "", MessageBoxButtons.OK);
                return;
            }
            if (txbServer.Text.Trim() == "")
            {
                MessageBox.Show("Server name không được trống", "", MessageBoxButtons.OK);
                return;
            }
            if (txbPassword.Text.Trim() == "")
            {
                MessageBox.Show("Mật khẩu không được trống", "", MessageBoxButtons.OK);
                return;
            }
            Program.serverName = txbServer.Text;
            Program.username = txbLoginName.Text;
            Program.passWord = txbPassword.Text;
            if (Program.KetNoi() == 0)
            {
                return;
            }
            Program.conn.Close();

            MessageBox.Show("Đăng nhập thành công !");
            frmMain frmmain = new frmMain();
            frmmain.ShowDialog();

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
