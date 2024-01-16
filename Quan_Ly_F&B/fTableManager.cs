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
    public partial class fTableManager : Form
    {
        public fTableManager()
        {
            InitializeComponent();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            fMenu f = new fMenu();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
        private void bthNhanVien_Click(object sender, EventArgs e)
        {
            fStaff f = new fStaff();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
        private void btnDoanhThu_Click(object sender, EventArgs e)
        {
            fRevenue f = new fRevenue();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
        private void btnThongBaoHetMon_Click(object sender, EventArgs e)
        {
            fNotification f = new fNotification();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnMenu_Click(this, new EventArgs());
        }
        private void doanhThuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnDoanhThu_Click(this,new EventArgs());
        }
        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bthNhanVien_Click(this, new EventArgs());
        }
        private void hếtMónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnThongBaoHetMon_Click((object)sender, new EventArgs());
        }
        private void btn01_Click(object sender, EventArgs e)
        {
            fPOSOrder f = new fPOSOrder();
            f.SetData(btn01.Text = "01");
            this.Hide();
            f.ShowDialog();
            btn01.Text = string.Empty;
        }
        private void btn02_Click(object sender, EventArgs e)
        {
            fPOSOrder f = new fPOSOrder();
            f.SetData(btn01.Text = "02");
            this.Hide();
            f.ShowDialog();
            btn01.Text = string.Empty;
        }
        private void btn03_Click(object sender, EventArgs e)
        {
            fPOSOrder f = new fPOSOrder();
            f.SetData(btn01.Text = "03");
            this.Hide();
            f.ShowDialog();
            btn01.Text = string.Empty;
        }
        private void btn04_Click(object sender, EventArgs e)
        {
            fPOSOrder f = new fPOSOrder();
            f.SetData(btn01.Text = "04");
            this.Hide();
            f.ShowDialog();
            btn01.Text = string.Empty;
        }
        private void btn05_Click(object sender, EventArgs e)
        {
            fPOSOrder f = new fPOSOrder();
            f.SetData(btn01.Text = "05");
            this.Hide();
            f.ShowDialog();
            btn01.Text = string.Empty;
            
        }
        private void btn06_Click(object sender, EventArgs e)
        {
            fPOSOrder f = new fPOSOrder();
            f.SetData(btn01.Text = "06");
            this.Hide();
            f.ShowDialog();
            btn01.Text = string.Empty;
            
        }
        private void btn07_Click(object sender, EventArgs e)
        {
            fPOSOrder f = new fPOSOrder();
            f.SetData(btn01.Text = "07");
            this.Hide();
            f.ShowDialog();
            btn01.Text = string.Empty;
            
        }
        private void btn08_Click(object sender, EventArgs e)
        {
            fPOSOrder f = new fPOSOrder();
            f.SetData(btn01.Text = "08");
            this.Hide();
            f.ShowDialog();
            btn01.Text = string.Empty;
            
        }
        private void btn09_Click(object sender, EventArgs e)
        {
            fPOSOrder f = new fPOSOrder();
            f.SetData(btn01.Text = "09");
            this.Hide();
            f.ShowDialog();
            btn01.Text = string.Empty;
            
        }
        private void btn10_Click(object sender, EventArgs e)
        {
            fPOSOrder f = new fPOSOrder();
            f.SetData(btn01.Text = "10");
            this.Hide();
            f.ShowDialog();
            btn01.Text = string.Empty;
            
        }
        private void btn11_Click(object sender, EventArgs e)
        {
            fPOSOrder f = new fPOSOrder();
            f.SetData(btn01.Text = "11");
            this.Hide();
            f.ShowDialog();
            btn01.Text = string.Empty;
            
        }
        private void btn12_Click(object sender, EventArgs e)
        {
            fPOSOrder f = new fPOSOrder();
            f.SetData(btn01.Text = "12");
            this.Hide();
            f.ShowDialog();
            btn01.Text = string.Empty;
            
        }
        private void btn13_Click(object sender, EventArgs e)
        {
            fPOSOrder f = new fPOSOrder();
            f.SetData(btn01.Text = "13");
            this.Hide();
            f.ShowDialog();
            btn01.Text = string.Empty;
            
        }
        private void btn14_Click(object sender, EventArgs e)
        {
            fPOSOrder f = new fPOSOrder();
            f.SetData(btn01.Text = "14");
            this.Hide();
            f.ShowDialog();
            btn01.Text = string.Empty;
            
        }
        private void btn15_Click(object sender, EventArgs e)
        {
            fPOSOrder f = new fPOSOrder();
            f.SetData(btn01.Text = "15");
            this.Hide();
            f.ShowDialog();
            btn01.Text = string.Empty;
            
        }
        private void btn16_Click(object sender, EventArgs e)
        {
            fPOSOrder f = new fPOSOrder();
            f.SetData(btn01.Text = "16");
            this.Hide();
            f.ShowDialog();
            btn01.Text = string.Empty;
            
        }
        private void btn17_Click(object sender, EventArgs e)
        {
            fPOSOrder f = new fPOSOrder();
            f.SetData(btn01.Text = "17");
            this.Hide();
            f.ShowDialog();
            btn01.Text = string.Empty;
            
        }
        private void btn18_Click(object sender, EventArgs e)
        {
            fPOSOrder f = new fPOSOrder();
            f.SetData(btn01.Text = "18");
            this.Hide();
            f.ShowDialog();
            btn01.Text = string.Empty;
            
        }
        private void btn19_Click(object sender, EventArgs e)
        {
            fPOSOrder f = new fPOSOrder();
            f.SetData(btn01.Text = "19");
            this.Hide();
            f.ShowDialog();
            btn01.Text = string.Empty;
            
        }
        private void btn20_Click(object sender, EventArgs e)
        {
            fPOSOrder f = new fPOSOrder();
            f.SetData(btn01.Text = "20");
            this.Hide();
            f.ShowDialog();
            btn01.Text = string.Empty;
            
        }
        private void btn21_Click(object sender, EventArgs e)
        {
            fPOSOrder f = new fPOSOrder();
            f.SetData(btn01.Text = "21");
            this.Hide();
            f.ShowDialog();
            btn01.Text = string.Empty;
            
        }
        private void btn22_Click(object sender, EventArgs e)
        {
            fPOSOrder f = new fPOSOrder();
            f.SetData(btn01.Text = "22");
            this.Hide();
            f.ShowDialog();
            btn01.Text = string.Empty;
            
        }
        private void btn23_Click(object sender, EventArgs e)
        {
            fPOSOrder f = new fPOSOrder();
            f.SetData(btn01.Text = "23");
            this.Hide();
            f.ShowDialog();
            btn01.Text = string.Empty;
            
        }
        private void btn24_Click(object sender, EventArgs e)
        {
            fPOSOrder f = new fPOSOrder();
            f.SetData(btn01.Text = "24");
            this.Hide();
            f.ShowDialog();
            btn01.Text = string.Empty;
            
        }
        private void btn25_Click(object sender, EventArgs e)
        {
            fPOSOrder f = new fPOSOrder();
            f.SetData(btn01.Text = "25");
            this.Hide();
            f.ShowDialog();
            btn01.Text = string.Empty;
            
        }
        private void fTableManager_FormClosed(object sender, FormClosedEventArgs e)
        {
                Application.Exit();
        }

        private void fTableManager_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show(" Bạn có thật sự muốn thoát chương trình? ", " Thông báo ", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
                e.Cancel = true;
        }
    }
}
