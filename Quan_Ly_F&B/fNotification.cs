using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quan_Ly_F_B
{
    public partial class fNotification : Form
    {
        private List<CMenu> dsMenuMon;

        public fNotification()
        {
            InitializeComponent();
            dgvMonHet.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvMonHet.DefaultCellStyle.Font = new Font("Arial", 11, FontStyle.Regular);
            dsMenuMon = new List<CMenu>();

    }
        private void fNotification_Load(object sender, EventArgs e)
        {
            taiDuLieuMenu();
            hienThiMenuMonCon();
            hienThiMenuMonHet();
        }
        private void taiDuLieuMenu()
        {
            // Kiểm tra xem tệp "Menu.txt" có tồn tại không
            if (File.Exists("Menu.txt"))
            {
                // Đọc dữ liệu từ tệp "Menu.txt" và thêm vào danh sách
                using (StreamReader r = new StreamReader("Menu.txt"))
                {
                    string dong;
                    while ((dong = r.ReadLine()) != null)
                    {
                        string[] mang = dong.Split(',');
                        CMenu menu = new CMenu();
                        menu.TenMon = mang[0];
                        menu.LoaiMon = mang[1];
                        menu.DonGia = double.Parse(mang[2]);
                        menu.TrangThai = int.Parse(mang[3]);
                        dsMenuMon.Add(menu);

                    }
                }
            }
        }
        private void hienThiMenuMonCon()
        {
            //Xóa tất cả các cột trước khi thêm mới
            dgvMonCon.Columns.Clear();
            dgvMonCon.Columns.Add("TenMon", "Tên Món");

            foreach (var menu in dsMenuMon)
            {
                if(menu.TrangThai == 1)
                {
                    dgvMonCon.Rows.Add(menu.TenMon);
                }
                    
            }
        }
        private void btnHetMon_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtTenMonKhaiBao.Text))
            {
                string selectedMenuName = txtTenMonKhaiBao.Text;

                CMenu selectedMenu = dsMenuMon.Find(menu => menu.TenMon.Equals(selectedMenuName));

                if (selectedMenu != null)
                {
                    selectedMenu.TrangThai = 0;

                    hienThiMenuMonCon();
                    hienThiMenuMonHet();
                }
            }
        }
        private void hienThiMenuMonHet()
        {
            // Xóa tất cả các cột trước khi thêm mới
            dgvMonHet.Columns.Clear();
            dgvMonHet.Columns.Add("TenMon", "Tên Món");

            foreach (var menu in dsMenuMon)
            {
                if(menu.TrangThai==0)
                {
                   dgvMonHet.Rows.Add(menu.TenMon);
                }
            }
        }
        private void btnConMon_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtTenMonKetQua.Text))
            {
                string selectedMenuName = txtTenMonKetQua.Text;

                CMenu selectedMenu = dsMenuMon.Find(menu => menu.TenMon.Equals(selectedMenuName));

                if (selectedMenu != null)
                {
                    selectedMenu.TrangThai = 1;

                    hienThiMenuMonCon();
                    hienThiMenuMonHet();
                }
            }
        }
        private void dgvKhaiBao_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvMonCon.Rows.Count - 1)
            {
                txtTenMonKhaiBao.Text = dgvMonCon.Rows[e.RowIndex].Cells["TenMon"].Value.ToString();
            }
        }
        private void dgvKetQua_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvMonHet.Rows.Count - 1)
            {
                txtTenMonKetQua.Text = dgvMonHet.Rows[e.RowIndex].Cells["TenMon"].Value.ToString();
            }
        }
        private void txtTenMonKhaiBao_TextChanged(object sender, EventArgs e)
        {
            string timMon = txtTenMonKhaiBao.Text.Trim();

            // Xóa dữ liệu cũ trước khi thêm mới
            dgvMonCon.Rows.Clear();

            foreach (CMenu c in dsMenuMon)
            {
                if (c.TenMon.Contains(timMon) && c.TrangThai == 1)
                {
                    dgvMonCon.Rows.Add(c.TenMon);
                }
            }
        }
        private void btnOk_Click(object sender, EventArgs e)
        {

            // Lưu lại dữ liệu vào tệp "Menu.txt"
            luuDanhSachMenu("Menu.txt");

            // Đóng form
            this.Close();
        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void luuDanhSachMenu(string dsMenu)
        {
            using (StreamWriter w = new StreamWriter(dsMenu))
            {
                foreach (var menu in dsMenuMon)
                {
                    w.WriteLine($"{menu.TenMon},{menu.LoaiMon},{menu.DonGia},{menu.TrangThai}");
                }
            }
        }
    }
}
