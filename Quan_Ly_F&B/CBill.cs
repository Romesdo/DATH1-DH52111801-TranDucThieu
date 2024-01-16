using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Ly_F_B
{
    internal class CBill
    {
        private string m_mahoadon;// m_trangthai;
        private DateTime m_ngaylapbill;
        private List<COrder> m_danhsachmonan;
        private double m_tongtien;
        public string MaHoaDon
        {
            get { return m_mahoadon; }
            set { m_mahoadon = value; }
        }
        //public string TrangThai
        //{
        //    get { return m_trangthai; }
        //    set { m_trangthai = value; }
        //}
        public DateTime NgayLapBill
        {
            get { return m_ngaylapbill; }
            set { m_ngaylapbill = value; }
        }
        public List<COrder> DanhSachMonAn
        {
            get { return m_danhsachmonan; }
            set { m_danhsachmonan = value; }
        }
        public double TongTien
        {
            get { 
                m_tongtien = 0;
            foreach(COrder c in m_danhsachmonan){
                    m_tongtien += c.ThanhTien;
                }
            return m_tongtien;
            }
            set { m_tongtien = value; }
        }
        public CBill()
        {
            m_mahoadon = "";
            m_ngaylapbill = DateTime.Now;
            m_danhsachmonan = new List<COrder>();
            m_tongtien = 0;
        }
    }
}
