using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Ly_F_B
{
    public class CMenu
    {
        private string m_tenmon, m_loaimon;
        private double m_dongia;
        private int i_trangthai;

        public string TenMon
        {
            get { return m_tenmon; }
            set { m_tenmon = value; }
        }
        public string LoaiMon
        {
            get { return m_loaimon; }
            set { m_loaimon = value; }
        }
        public double DonGia
        {
            get { return m_dongia; }
            set { m_dongia = value; }
        }

        public int TrangThai
        {
            get { return i_trangthai; }
            set { i_trangthai = value; }
        }        
        public CMenu()
        {
            m_tenmon = "";
            m_loaimon = "";
            m_dongia = 0;
            i_trangthai = 1;
        }
    }
}
