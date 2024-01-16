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
using System.Xml.Linq;

namespace Quan_Ly_F_B
{
    public partial class fBill : Form
    {
        Dictionary<string, CBill> dsBill = new Dictionary<string, CBill>();
        private List<COrder> order = new List<COrder>();
        public fBill()
        {
            InitializeComponent();
            dgvBill.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvBill.DefaultCellStyle.Font = new Font("Arial", 11, FontStyle.Regular);
            docBill();
        }
        private CBill timBill(string ma)
        {
            try
            {
                return dsBill[ma];
            }
            catch { return null; }
        }
        public void setData(string data)
        {
            lbnHienSo.Text = data;
        }
        public void docFileDanhSachOrder()
        {
            if (File.Exists("DanhSachOrder.txt"))
            {
                using (StreamReader r = new StreamReader("DanhSachOrder.txt"))
                {
                    string dong;
                    while ((dong = r.ReadLine()) != null)
                    {
                        string[] mang = dong.Split(',');
                        COrder c = new COrder();
                        c.TenMon = mang[0];
                        c.SoLuong = int.Parse(mang[1]);
                        c.GiaBan = double.Parse(mang[2]);
                        c.ThanhTien = double.Parse(mang[3]);
                        order.Add(c);
                    }
                }
            }
        }
        private void hienThiDanhSachOrder()
        {
            docFileDanhSachOrder();
            CBill c = new CBill();
            c.NgayLapBill = DateTime.Now;
            c.MaHoaDon = "I" + DateTime.Now.ToString("ddMMyyhhmmss");
            c.DanhSachMonAn = order;
            dsBill.Add(c.MaHoaDon, c);
            lbnHienThoiGian.Text = DateTime.Now.ToString();
            lbnHienSoBill.Text = "I" + DateTime.Now.ToString("ddMMyyhhmmss");
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = order;
            dgvBill.DataSource = bindingSource;
        }
        private void CapNhatTongTien()
        {
            double tongTien = 0;
            foreach (DataGridViewRow row in dgvBill.Rows)
            {
                if (!row.IsNewRow)
                {
                    double thanhTien;
                    if (double.TryParse(row.Cells[3].Value?.ToString(), out thanhTien))
                        tongTien += thanhTien;
                }
            }
            lbnHienThanhTien.Text = tongTien.ToString();
        }
        private void fBill_Load(object sender, EventArgs e)
        {
            //docBill();
            hienThiDanhSachOrder();
            CapNhatTongTien();
        }
        private string chuyenDoiOrderThanhChuoi(List<COrder> order)
        {
            string chuoiOrder = "";
            foreach (COrder n in order)
            {
                chuoiOrder += $"{n.TenMon}|{n.SoLuong}|{n.GiaBan}|{n.ThanhTien};";
            }
            return chuoiOrder;
        }
        private void LuuBill()
        {
            using (StreamWriter w = new StreamWriter("DanhSachBill.txt"))
            {
                foreach (var n in dsBill)
                {
                    string chuoiOrder = chuyenDoiOrderThanhChuoi(n.Value.DanhSachMonAn);
                    w.WriteLine($"{n.Value.NgayLapBill},{n.Value.MaHoaDon},{chuoiOrder},{n.Value.TongTien}");
                }
            }
        }
        private void docBill()
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
                        c.NgayLapBill = DateTime.Parse(mang[0]);
                        c.MaHoaDon = mang[1];
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
                        c.TongTien = double.Parse(mang[3]);
                        dsBill.Add(c.MaHoaDon, c);
                    }
                }
            }
        }
        private void btnXuatHoaDon_Click(object sender, EventArgs e)
        {
            LuuBill();
            fTableManager f =new fTableManager();
            this.Close();
            f.Show();
        }
    }
}
