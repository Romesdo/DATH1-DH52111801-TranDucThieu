using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quan_Ly_F_B
{
    public partial class fLogin : Form
    {
        string tendangnhap = "admin";
        string matkhau = "123";
        public fLogin()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (KiemTraDangNhap(txtTenDangNhap.Text, txtMatKhau.Text))
            {
                fTableManager f = new fTableManager();
                this.Hide();
                f.ShowDialog();
            }
            else
            {
                MessageBox.Show(" Sai tên tài khoản hoặc mật khẩu ", " Lỗi !!! ");
                txtTenDangNhap.Focus();
            }

        }
        bool KiemTraDangNhap(string tendangnhap, string matkhau)
        {
            if(tendangnhap == this.tendangnhap && matkhau == this.matkhau)
            {
                return true;
            }
            return false;
        }

        private void ckbHienThiMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbHienThiMatKhau.Checked)
            {
                txtMatKhau.UseSystemPasswordChar = false;
            }
            else
            {
                txtMatKhau.UseSystemPasswordChar = true;
            }
        }
    }
}
