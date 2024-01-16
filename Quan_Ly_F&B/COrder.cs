using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Ly_F_B
{
    internal class COrder
    {
        private string m_tenmon;
        private int i_soluong;
        private double m_giaban, m_thanhtien, m_tongtien;

        public string TenMon
        {
            get { return m_tenmon; }
            set { m_tenmon = value; }
        }
        public int SoLuong
        {
            get { return i_soluong; }
            set { i_soluong = value; }
        }

        public double GiaBan
        {
            get { return m_giaban; }
            set { m_giaban = value; }
        }

        public double ThanhTien
        {
            get { return i_soluong*m_giaban; }
            set { m_thanhtien = value; }
        }
        public COrder()
        {
            m_tenmon = "";
            i_soluong = 1;
            m_giaban = 0;
            m_thanhtien = 0;
        }
    }
}
