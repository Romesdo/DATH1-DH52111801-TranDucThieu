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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Quan_Ly_F_B
{
    public partial class fStaff : Form
    {
        private Dictionary<string, CNhanVien> nhanvien = new Dictionary<string, CNhanVien>();
        public fStaff()
        {
            InitializeComponent();
        }

        private CNhanVien TimNhanVien(string ten)
        {
            try
            {
                return nhanvien[ten];
            }
            catch
            {
                return null;
            }
        }

        private void HienNhanVien()
        {
            dgvQuanLyNhanVien.DataSource = nhanvien.Values.ToList();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            CNhanVien n = new CNhanVien();
            n.MaNhanVien = txtMaNhanVien.Text;
            n.TenNhanVien = txtTenNhanVien.Text;
            n.ChucVu = cboChucVu.Text;
            n.TongGioLam = Convert.ToInt32(txtTongGioLam.Text);
            n.SoDienThoai = txtSoDienThoai.Text;
            n.MucLuong = Convert.ToInt32(cboMucLuong.Text);
            n.Luong = n.TongGioLam * n.MucLuong;
            if (TimNhanVien(n.MaNhanVien) == null)
            {
                nhanvien.Add(n.MaNhanVien, n);
                HienNhanVien();
            }
            else
                MessageBox.Show(" Nhân viên đã tồn tại. Không thể thêm !!! ", " Thông báo ");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string ma = txtMaNhanVien.Text;
            if (TimNhanVien(ma) == null)
                MessageBox.Show(" Không tồn tại nhân viên này !!! ", " Thông báo ");
            else
            {
                if (MessageBox.Show(" Bạn có muốn xóa nhân viên này không ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    nhanvien.Remove(ma);
                    HienNhanVien();
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string ma = txtMaNhanVien.Text;
            CNhanVien n = TimNhanVien(ma);
            if (n == null)
                MessageBox.Show(" Không tồn tại nhân viên này !!! ", " Thông báo ");
            else
            {
                n.MaNhanVien = txtMaNhanVien.Text;
                n.TenNhanVien = txtTenNhanVien.Text;
                n.ChucVu = cboChucVu.Text;
                n.TongGioLam = int.Parse(txtTongGioLam.Text);
                n.SoDienThoai = txtSoDienThoai.Text;
                n.MucLuong = int.Parse(cboMucLuong.Text);
                n.Luong = n.TongGioLam * n.MucLuong;
                HienNhanVien();
                MessageBox.Show(" Bạn đã sửa thành công !!!", "Thông báo");
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            using (StreamWriter w = new StreamWriter("NhanVien.txt"))
            {
                foreach (var n in nhanvien)
                {
                    w.WriteLine($"{n.Value.MaNhanVien},{n.Value.TenNhanVien},{n.Value.ChucVu},{n.Value.SoDienThoai},{n.Value.MucLuong},{n.Value.TongGioLam},{n.Value.Luong}");
                }
                MessageBox.Show("Đã lưu thành công.");
            }
        }

        private void dgvQuanLyNhanVien_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtMaNhanVien.Text = dgvQuanLyNhanVien.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtTenNhanVien.Text = dgvQuanLyNhanVien.Rows[e.RowIndex].Cells[1].Value.ToString();

            if (dgvQuanLyNhanVien.Rows[e.RowIndex].Cells[2].Value.ToString() == "Customer Welcome")
                cboChucVu.Text = "Customer Welcome";
            else if (dgvQuanLyNhanVien.Rows[e.RowIndex].Cells[2].Value.ToString() == "Barista - Part Time")
                cboChucVu.Text = "Barista - Part Time";
            else if (dgvQuanLyNhanVien.Rows[e.RowIndex].Cells[2].Value.ToString() == "Barista - Full Time")
                cboChucVu.Text = "Barista - Full Time";
            else if (dgvQuanLyNhanVien.Rows[e.RowIndex].Cells[2].Value.ToString() == "Shift Supervisor")
                cboChucVu.Text = "Shift Supervisor"; 
            else
                cboChucVu.Text = "Store Manager";

            txtSoDienThoai.Text = dgvQuanLyNhanVien.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtTongGioLam.Text = dgvQuanLyNhanVien.Rows[e.RowIndex].Cells[4].Value.ToString();
            if (dgvQuanLyNhanVien.Rows[e.RowIndex].Cells[5].Value.ToString() == "30000")
                cboMucLuong.Text = "30000";
            else if (dgvQuanLyNhanVien.Rows[e.RowIndex].Cells[5].Value.ToString() == "35000")
                cboMucLuong.Text = "35000";
            else if (dgvQuanLyNhanVien.Rows[e.RowIndex].Cells[5].Value.ToString() == "40000")
                cboMucLuong.Text = "40000";
            else
                cboMucLuong.Text = "70000";



        }

        private void fStaff_Load(object sender, EventArgs e)
        {
            dgvQuanLyNhanVien.EditMode = DataGridViewEditMode.EditOnEnter;

            if (File.Exists("NhanVien.txt"))
            {
                using (StreamReader r = new StreamReader("NhanVien.txt"))
                {
                    string dong;
                    while ((dong = r.ReadLine()) != null)
                    {
                        string[] mang = dong.Split(',');
                        CNhanVien n = new CNhanVien();
                        n.MaNhanVien = mang[0];
                        n.TenNhanVien = mang[1];
                        n.ChucVu = mang[2];
                        n.SoDienThoai = mang[3];
                        n.MucLuong = double.Parse(mang[4]);
                        n.TongGioLam = int.Parse(mang[5]);
                        n.Luong = double.Parse(mang[6]);
                        nhanvien.Add(n.MaNhanVien, n);
                    }
                    HienNhanVien();
                }
            }
        }
    }
}
