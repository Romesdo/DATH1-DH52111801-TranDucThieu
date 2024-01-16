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
    public partial class fPOSOrder : Form
    {
        private List<CMenu> danhsachmon = new List<CMenu>();
        private List<COrder> order = new List<COrder>();

        public fPOSOrder()
        {
            InitializeComponent();
            docFileMenu();
            dgvPOSOrder.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvPOSOrder.DefaultCellStyle.Font = new Font("Arial", 9, FontStyle.Regular);

        }
        private void luuDanhSachOrder()
        {
            using (StreamWriter w = new StreamWriter("DanhSachOrder.txt"))
            {
                foreach (var n in order)
                {
                    w.WriteLine($"{n.TenMon},{n.SoLuong},{n.GiaBan},{n.ThanhTien}");
                }
            }
        }
        public void SetData(string data)
        {
            // Cập nhật TextBox trong Form này
            txtPOSOrder.Text = data;
        }
        public void docFileMenu()
        {
            if (File.Exists("Menu.txt"))
            {
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
                        danhsachmon.Add(menu);
                    }
                }
            }
        }
        private void hienThiDanhSachLoaiMon(List<CMenu> danhsach)
        {
            flpDanhSachLoaiMon.Controls.Clear();
            foreach (CMenu n in danhsach)
            {
               
                Button btn = new Button();
                btn.Text = n.TenMon;
                btn.Size = new Size(165, 82);
                btn.BackColor = Color.LightYellow;
                if (n.TrangThai == 0)
                {
                    btn.Enabled = false; // Nếu trạng thái là 0 thì vô hiệu hóa button
                    btn.BackColor = Color.Gray; // Màu nền xám để chỉ định là món đã hết
                }
                else
                {
                    btn.Click += (sender, e) =>
                    {
                        COrder c = new COrder();
                        c.TenMon = n.TenMon;
                        c.GiaBan = n.DonGia;
                        order.Add(c);
                        BindingSource bs = new BindingSource();
                        bs.DataSource = order;
                        dgvPOSOrder.DataSource = bs;
                        CapNhatTongTien();
                        luuDanhSachOrder();
                    };
                }

                flpDanhSachLoaiMon.Controls.Add(btn);
            }
        }
        private COrder timMon(string ten)
        {
            foreach (COrder n in order)
            {
                if (n.TenMon == ten)
                    return n;
            }
            return null;
        }
        private void btnBoMon_Click(object sender, EventArgs e)
        {
            string ten = txtTenMon.Text;
            COrder n = timMon(ten);
            if (n == null)
                MessageBox.Show(" BẤM vào tên món bạn muốn bỏ !!! ", " Thông báo ");
            else
            {
                order.Remove(n);
                BindingSource bs = new BindingSource();
                bs.DataSource = order;
                dgvPOSOrder.DataSource = bs;
                txtTenMon.Text = "";
                CapNhatTongTien();
            }
        }
        private void btnCaPheVietNam_Click(object sender, EventArgs e)
        {
            List<CMenu> danhsachloaimon = new List<CMenu>();
            foreach (CMenu n in danhsachmon)
            {
                if (n.LoaiMon == "Cà Phê Việt Nam")
                {
                    danhsachloaimon.Add(n);
                }
            }
            hienThiDanhSachLoaiMon(danhsachloaimon);
        }
        private void btnCaPheMay_Click(object sender, EventArgs e)
        {
            List<CMenu> danhsachloaimon = new List<CMenu>();
            foreach (CMenu n in danhsachmon)
            {
                if (n.LoaiMon == "Cà Phê Máy")
                {
                    danhsachloaimon.Add(n);
                }
            }
            hienThiDanhSachLoaiMon(danhsachloaimon);
        }
        private void btnColdBrew_Click(object sender, EventArgs e)
        {
            List<CMenu> danhsachloaimon = new List<CMenu>();
            foreach (CMenu n in danhsachmon)
            {
                if (n.LoaiMon == "ColdBrew")
                {
                    danhsachloaimon.Add(n);
                }
            }
            hienThiDanhSachLoaiMon(danhsachloaimon);
        }
        private void btnTraTraiCay_Click(object sender, EventArgs e)
        {
            List<CMenu> danhsachloaimon = new List<CMenu>();
            foreach (CMenu n in danhsachmon)
            {
                if (n.LoaiMon == "Trà Trái Cây")
                {
                    danhsachloaimon.Add(n);
                }
            }
            hienThiDanhSachLoaiMon(danhsachloaimon);
        }
        private void btnTraSua_Click(object sender, EventArgs e)
        {
            List<CMenu> danhsachloaimon = new List<CMenu>();
            foreach (CMenu n in danhsachmon)
            {
                if (n.LoaiMon == "Trà Sữa")
                {
                    danhsachloaimon.Add(n);
                }
            }
            hienThiDanhSachLoaiMon(danhsachloaimon);
        }
        private void btnHighTea_Click(object sender, EventArgs e)
        {
            List<CMenu> danhsachloaimon = new List<CMenu>();
            foreach (CMenu n in danhsachmon)
            {
                if (n.LoaiMon == "HighTea")
                {
                    danhsachloaimon.Add(n);
                }
            }
            hienThiDanhSachLoaiMon(danhsachloaimon);
        }
        private void btnHighFee_Click(object sender, EventArgs e)
        {
            List<CMenu> danhsachloaimon = new List<CMenu>();
            foreach (CMenu n in danhsachmon)
            {
                if (n.LoaiMon == "HighFee")
                {
                    danhsachloaimon.Add(n);
                }
            }
            hienThiDanhSachLoaiMon(danhsachloaimon);
        }
        private void btnRTea_Click(object sender, EventArgs e)
        {
            List<CMenu> danhsachloaimon = new List<CMenu>();
            foreach (CMenu n in danhsachmon)
            {
                if (n.LoaiMon == "R-Tea")
                {
                    danhsachloaimon.Add(n);
                }
            }
            hienThiDanhSachLoaiMon(danhsachloaimon);
        }
        private void btnTraXanhChocolate_Click(object sender, EventArgs e)
        {
            List<CMenu> danhsachloaimon = new List<CMenu>();
            foreach (CMenu n in danhsachmon)
            {
                if (n.LoaiMon == "Trà Xanh - Chocolate")
                {
                    danhsachloaimon.Add(n);
                }
            }
            hienThiDanhSachLoaiMon(danhsachloaimon);
        }
        private void btnIceBlended_Click(object sender, EventArgs e)
        {
            List<CMenu> danhsachloaimon = new List<CMenu>();
            foreach (CMenu n in danhsachmon)
            {
                if (n.LoaiMon == "Ice Blended")
                {
                    danhsachloaimon.Add(n);
                }
            }
            hienThiDanhSachLoaiMon(danhsachloaimon);
        }
        private void btnBanhMan_Click(object sender, EventArgs e)
        {
            List<CMenu> danhsachloaimon = new List<CMenu>();
            foreach (CMenu n in danhsachmon)
            {
                if (n.LoaiMon == "Bánh Mặn")
                {
                    danhsachloaimon.Add(n);
                }
            }
            hienThiDanhSachLoaiMon(danhsachloaimon);
        }
        private void btnBanhNgot_Click(object sender, EventArgs e)
        {
            List<CMenu> danhsachloaimon = new List<CMenu>();
            foreach (CMenu n in danhsachmon)
            {
                if (n.LoaiMon == "Bánh Ngọt")
                {
                    danhsachloaimon.Add(n);
                }
            }
            hienThiDanhSachLoaiMon(danhsachloaimon);
        }
        private void bỏMónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnBoMon_Click(sender, e);
        }
        private void tổngTiềnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnTongTien_Click(sender, e);
        }
        private void btnTongTien_Click(object sender, EventArgs e)
        {
            if (dgvPOSOrder.RowCount != 1)
            {
                fBill f = new fBill();
                f.setData(txtPOSOrder.Text);
                this.Close();
                f.ShowDialog();
            }
            else
            {
                MessageBox.Show(" Bạn cần phải chọn món để thanh toán !!!", " Thông Báo ", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
        }
        private void dgvPOSOrder_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {

                // Lấy giá trị của ô được click
                object cellValue = dgvPOSOrder.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;

                // Truyền giá trị cho TextBox
                txtTenMon.Text = cellValue.ToString();
            }
        }
        private void CapNhatTongTien()
        {
            double tongTien = 0;
            foreach (DataGridViewRow row in dgvPOSOrder.Rows)
            {
                if (!row.IsNewRow)
                {
                    double thanhTien;
                    if (double.TryParse(row.Cells[3].Value?.ToString(), out thanhTien))
                        tongTien += thanhTien;
                }
            }
            txtTongTien1.Text = tongTien.ToString();
            txtTongTien2.Text = tongTien.ToString();
        }
        private void dgvPOSOrder_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            CapNhatTongTien();
            luuDanhSachOrder();
        }
        private void dgvPOSOrder_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            CapNhatTongTien();
            luuDanhSachOrder();
        }
        private void dgvPOSOrder_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            CapNhatTongTien();
            luuDanhSachOrder();
        }
        private void fPOSOrder_Load(object sender, EventArgs e)
        {
            hienThiDanhSachLoaiMon(danhsachmon);
            btnBoMon.Click += btnBoMon_Click;
            btnTongTien.Click += btnTongTien_Click;
            btnCaPheVietNam.Click += btnCaPheVietNam_Click;
            btnCaPheMay.Click += btnCaPheMay_Click;
            btnColdBrew.Click += btnColdBrew_Click;
            btnTraTraiCay.Click += btnTraTraiCay_Click;
            btnTraSua.Click += btnTraSua_Click;
            btnHighTea.Click += btnHighTea_Click;
            btnHighFee.Click += btnHighFee_Click;
            btnRTea.Click += btnRTea_Click;
            btnTraXanhChocolate.Click += btnTraXanhChocolate_Click;
            btnIceBlended.Click += btnIceBlended_Click;
            btnBanhMan.Click += btnBanhMan_Click;
            btnBanhNgot.Click += btnBanhNgot_Click;
            dgvPOSOrder.CellClick += dgvPOSOrder_CellClick;
            dgvPOSOrder.CellValueChanged += dgvPOSOrder_CellValueChanged;
            dgvPOSOrder.RowsAdded += dgvPOSOrder_RowsAdded;
            dgvPOSOrder.RowsRemoved += dgvPOSOrder_RowsRemoved;
        }

        private void fPOSOrder_FormClosed(object sender, FormClosedEventArgs e)
        {
            fTableManager f = new fTableManager();
            f.Show();
        }
    }
}
