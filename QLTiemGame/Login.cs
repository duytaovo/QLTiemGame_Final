using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTiemGame
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (cboUser.Text.Equals("") || cboUser.Text.Equals("--Lựa Chọn--"))
            {
                MessageBox.Show("Chưa chọn loại tài khoản! Vui lòng chọn!");
                cboUser.Select();
            }
            else if (txtMK.Text.Equals(""))
            {
                MessageBox.Show("Chưa nhập mật khẩu! Vui lòng nhập vào");
                txtMK.Select();
            }
            else
            {
                if (cboUser.Text.Equals("Nhân viên") && txtTenDN.Text.Equals("Nhân viên") && txtMK.Text.Equals("123456"))
                {
                    Home frmHome = new Home();
                    frmHome.ShowDialog();
                }
                else if (cboUser.Text.Equals("Quản lý") && txtTenDN.Text.Equals("Quản lý") && txtMK.Text.Equals("123456"))
                {
                    Option frmOption = new Option();
                    frmOption.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu không đúng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
