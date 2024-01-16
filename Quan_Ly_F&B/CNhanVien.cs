using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Ly_F_B
{
    internal class CNhanVien
    {
        private string m_manv, m_tennv, m_chucvu, m_sdt;
        private int i_tonggiolam;
        private double m_mucluong, m_luong;

        public string MaNhanVien
        {
            get { return m_manv; }
            set { m_manv = value; }
        }
        public string TenNhanVien
        {
            get { return m_tennv; }
            set { m_tennv = value; }
        }
        public string ChucVu
        {
            get { return m_chucvu; }
            set { m_chucvu = value; }
        }
        public string SoDienThoai
        {
            get { return m_sdt; }
            set { m_sdt = value; }
        }
        public int TongGioLam
        {
            get { return i_tonggiolam; }
            set { i_tonggiolam = value; }
        }

        public double MucLuong
        {
            get { return m_mucluong; }
            set { m_mucluong = value; }
        }
        public double Luong
        {
            get { return m_luong; }
            set { m_luong = value; }
        }

        public CNhanVien()
        {
            MaNhanVien = "";
            TenNhanVien = "";
            ChucVu = "";
            SoDienThoai = "";
            MucLuong = 0;
            TongGioLam = 0;
            Luong = 0;

        }
    }
}
