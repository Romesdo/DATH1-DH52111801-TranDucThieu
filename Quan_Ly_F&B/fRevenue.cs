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
    public partial class fRevenue : Form
    {
        Dictionary<string, CBill>  dsBill = new Dictionary<string, CBill>();
        public fRevenue()
        {
            InitializeComponent();
            layDanhSachBill();
            dtpNgay.CustomFormat = "dd";
            dtpThang.CustomFormat = "MM";
            dtpNam.CustomFormat = "yy";
        }
        private CBill timBill (string ma)
        {
            try
            {
                return dsBill[ma];
            }
            catch { return null; }
        }

        private void layDanhSachBill()
        {
            if (File.Exists("DanhSachBill.txt"))
            {
                using (StreamReader r = new StreamReader("DanhSachBill.txt"))
                {
                    string dong;
                    while ((dong = r.ReadLine()) != null)
                    {
                        string[] mang = dong.Split(',');
                        CBill c = new CBill();
                        c.MaHoaDon = mang[1];
                        c.NgayLapBill = DateTime.Parse(mang[0]);
                        c.TongTien = double.Parse(mang[3]);
                        string danhSachOrder = mang[2];
                        string[] mangDSOrder = danhSachOrder.Split(';');
                        foreach (string lo in mangDSOrder)
                        {
                            if (!string.IsNullOrEmpty(lo))
                            {
                                string[] arrayOrder = lo.Split('|');
                                COrder cOrder = new COrder();
                                cOrder.TenMon = arrayOrder[0];
                                cOrder.SoLuong = int.Parse(arrayOrder[1]);
                                cOrder.GiaBan = double.Parse(arrayOrder[2]);
                                cOrder.ThanhTien = double.Parse(arrayOrder[3]);
                                c.DanhSachMonAn.Add(cOrder);
                            }
                        }
                        dsBill.Add(c.MaHoaDon, c);
                    }
                }
            }
        }
        private void hienBill()
        {
            dgvDoanhThu.DataSource = dsBill.Values.ToList();
        }
        private void hienDanhSachMonTungBill(List<COrder> listMonAn)
        {
            listViewMon.Items.Clear();
            foreach(COrder c in listMonAn)
            {
                ListViewItem newItem = new ListViewItem();
                newItem.Text = c.TenMon.ToString();
                newItem.SubItems.Add(c.SoLuong.ToString());
                newItem.SubItems.Add(c.GiaBan.ToString());
                newItem.SubItems.Add(c.ThanhTien.ToString());
                listViewMon.Items.Add(newItem);
            }
        }
        private void fRevenue_Load(object sender, EventArgs e)
        {
            hienBill();
        }
        private void dgvDoanhThu_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            string mahoadon = dgvDoanhThu.Rows[e.RowIndex].Cells[0].Value.ToString();
            CBill b = timBill(mahoadon);
            if (b != null)
            {
                hienDanhSachMonTungBill(b.DanhSachMonAn);
            }
        }
        private void btnTim_Click(object sender, EventArgs e)
        {
            List<CBill> dsLoc = new List<CBill>();
            DateTime ngaybatdau = dtpkTuNgay.Value.Date;
            DateTime ngayketthuc = dtpkDenNgay.Value.Date;

            foreach (var b in dsBill)
            {
                DateTime ngaylap = b.Value.NgayLapBill.Date;
                if (ngaylap >= ngaybatdau && ngaylap <= ngayketthuc)
                {
                    dsLoc.Add(b.Value);
                }
            }
            dgvDoanhThu.DataSource = dsLoc;
        }
        private void TinhTongDoanhThu()
        {
            DateTime ngayLoc = new DateTime(dtpNam.Value.Year, dtpThang.Value.Month, dtpNgay.Value.Day);

            // Lọc danh sách theo ngày/tháng/năm
            List<CBill> dsLocNgay = dsBill.Values.Where(b => b.NgayLapBill.Date == ngayLoc.Date).ToList();
            List<CBill> dsLocThang = dsBill.Values.Where(b => b.NgayLapBill.Month == dtpThang.Value.Month && b.NgayLapBill.Year == dtpNam.Value.Year).ToList();
            List<CBill> dsLocNam = dsBill.Values.Where(b => b.NgayLapBill.Year == dtpNam.Value.Year).ToList();

            // Tính tổng doanh thu
            double tongDoanhThuNgay = dsLocNgay.Sum(b => b.TongTien);
            double tongDoanhThuThang = dsLocThang.Sum(b => b.TongTien);
            double tongDoanhThuNam = dsLocNam.Sum(b => b.TongTien);

            // Hiển thị kết quả trên Label
            lbnNgay.Text = $"Doanh thu ngày: {tongDoanhThuNgay.ToString("C")}";
            lbnThang.Text = $"Doanh thu tháng: {tongDoanhThuThang.ToString("C")}";
            lbnNam.Text = $"Doanh thu năm: {tongDoanhThuNam.ToString("C")}";

            // Hiển thị danh sách lên DataGridView
            dgvDoanhThu.DataSource = dsLocNgay;

        }
        private void dtpNgay_ValueChanged(object sender, EventArgs e)
        {
            TinhTongDoanhThu();
        }

        private void dtpThang_ValueChanged(object sender, EventArgs e)
        {
            TinhTongDoanhThu();
        }

        private void dtpNam_ValueChanged(object sender, EventArgs e)
        {
            TinhTongDoanhThu();
        }
    }
}
