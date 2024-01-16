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
    public partial class fMenu : Form
    {
        private Dictionary<string, CMenu> menu = new Dictionary<string, CMenu>();

        public fMenu()
        {
            InitializeComponent();
            dgvMenu.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvMenu.DefaultCellStyle.Font = new Font("Arial", 11, FontStyle.Regular);
        }
        DataGridView data;
        public fMenu(DataGridView dt)
        {
            InitializeComponent();
            data = dt;
        }
        public DataTable DataFromOtherForm { get; set; }
        public void SetDataFromOtherForm(DataTable data)
        {
            DataFromOtherForm = data;
        }
        private CMenu TimMon(string ten)
        {
            try
            {
                return menu[ten];
            }
            catch
            {
                return null;
            }
        }
        private void HienMenu()
        {
            // Chuyển danh sách từ Dictionary sang List
            List<CMenu> menuList = menu.Values.ToList();

            // Sắp xếp danh sách theo loại, sau đó theo đơn giá, cuối cùng theo tên
            menuList = menuList
                    .OrderBy(x => x.LoaiMon)
                    .ThenBy(x => x.DonGia)
                    .ThenBy(x => x.TenMon)
                    .ToList();

            // Hiển thị lại dữ liệu lên DataGridView
            dgvMenu.DataSource = null;
            dgvMenu.DataSource = menuList;
            dgvMenu.DataSource = menuList.ToArray();
        }

        private void btnThemMon_Click(object sender, EventArgs e)
        {
            CMenu n = new CMenu();
            n.TenMon = txtTenMon.Text;
            n.DonGia = double.Parse(txtDonGia.Text);
            n.LoaiMon = cboChonLoaiMon.Text;
            if (TimMon(n.TenMon) == null)
            {
                menu.Add(n.TenMon, n);
                HienMenu();
            }
            else
                MessageBox.Show(" Món ăn đã tồn tại. Không thể thêm !!! ", " Thông báo ");

        }

        private void btnXoaMon_Click(object sender, EventArgs e)
        {
            string ten = txtTenMon.Text;
            if (TimMon(ten) == null)
                MessageBox.Show(" Không tồn tại món ăn này !!! ", " Thông báo ");
            else
            {
                if (MessageBox.Show(" Bạn có muốn xóa món này không ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    menu.Remove(ten);
                    HienMenu();
                }
            }

        }

        private void btnSuaMon_Click(object sender, EventArgs e)
        {
            string ten = txtTenMon.Text;
            CMenu n = TimMon(ten);
            if (n == null)
                MessageBox.Show(" Không tồn tại món ăn này !!! ", " Thông báo ");
            else
            {
                n.TenMon = txtTenMon.Text;
                n.LoaiMon = cboChonLoaiMon.Text;
                n.DonGia = double.Parse(txtDonGia.Text);
                HienMenu();
                MessageBox.Show(" Bạn đã sửa thành công !!!", "Thông báo");
            }

        }

        private void btnLuuMon_Click(object sender, EventArgs e)
        {
            using (StreamWriter w = new StreamWriter("Menu.txt"))
            {
                foreach (var n in menu)
                {
                    w.WriteLine($"{n.Value.TenMon},{n.Value.LoaiMon},{n.Value.DonGia}");
                }
                MessageBox.Show("Đã lưu thành công.");
            }


        }

        private void dgvMenu_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtTenMon.Text = dgvMenu.Rows[e.RowIndex].Cells[0].Value.ToString();
            if (dgvMenu.Rows[e.RowIndex].Cells[1].Value.ToString() == "Cà Phê Máy")
                cboChonLoaiMon.Text = "Cà Phê Máy";
            else if (dgvMenu.Rows[e.RowIndex].Cells[1].Value.ToString() == "Cà Phê Việt Nam")
                cboChonLoaiMon.Text = "Cà Phê Việt Nam";
            else if (dgvMenu.Rows[e.RowIndex].Cells[1].Value.ToString() == "HighFee")
                cboChonLoaiMon.Text = "HighFee";
            else if (dgvMenu.Rows[e.RowIndex].Cells[1].Value.ToString() == "HighTea")
                cboChonLoaiMon.Text = "HighTea";
            else if (dgvMenu.Rows[e.RowIndex].Cells[1].Value.ToString() == "ColdBrew")
                cboChonLoaiMon.Text = "ColdBrew";
            else if (dgvMenu.Rows[e.RowIndex].Cells[1].Value.ToString() == "Ice Blended")
                cboChonLoaiMon.Text = "Ice Blended";
            else if (dgvMenu.Rows[e.RowIndex].Cells[1].Value.ToString() == "R-Tea")
                cboChonLoaiMon.Text = "R-Tea";
            else if (dgvMenu.Rows[e.RowIndex].Cells[1].Value.ToString() == "Trà Sữa")
                cboChonLoaiMon.Text = "Trà Sữa";
            else if (dgvMenu.Rows[e.RowIndex].Cells[1].Value.ToString() == "Trà Trái Cây")
                cboChonLoaiMon.Text = "Trà Trái Cây";
            else if (dgvMenu.Rows[e.RowIndex].Cells[1].Value.ToString() == "Trà Xanh - Chocolate")
                cboChonLoaiMon.Text = "Trà Xanh - Chocolate";
            else if (dgvMenu.Rows[e.RowIndex].Cells[1].Value.ToString() == "Bánh Ngọt")
                cboChonLoaiMon.Text = "Bánh Ngọt";
            else
                cboChonLoaiMon.Text = "Bánh Mặn";
            txtDonGia.Text = dgvMenu.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void fMenu_Load(object sender, EventArgs e)
        {
            dgvMenu.EditMode = DataGridViewEditMode.EditOnEnter;

            if (File.Exists("Menu.txt"))
            {
                using (StreamReader r = new StreamReader("Menu.txt"))
                {
                    string dong;
                    while ((dong = r.ReadLine()) != null)
                    {
                        string[] mang = dong.Split(',');
                        CMenu n = new CMenu();
                        n.TenMon = mang[0];
                        n.LoaiMon = mang[1];
                        n.DonGia = double.Parse(mang[2]);
                        n.TrangThai = int.Parse(mang[3]);
                        menu.Add(n.TenMon, n);
                        HienMenu();
                    }
                }
            }

        }
    }
}
