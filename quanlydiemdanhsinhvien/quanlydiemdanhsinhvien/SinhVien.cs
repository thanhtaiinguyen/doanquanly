using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quanlydiemdanhsinhvien
{
    internal class SinhVien
    {
        private string m_HoVaTen, m_MaSoSinhVien, m_Lop;
        private DateTime m_NgayDiemDanh;
        private bool m_GioiTinh;
        private string m_MonHoc;

        public string MaSoSinhVien
        {
            get
            {
                return m_MaSoSinhVien;
            }
            set
            {
                m_MaSoSinhVien = value;
            }
        }
        public string HoVaTen
        {
            get
            {
                return m_HoVaTen;
            }
            set
            {
                m_HoVaTen = value;
            }
        }
        public string Lop
        {
            get
            {
                return m_Lop;
            }
            set
            {
                m_Lop = value;
            }
        }
        public DateTime NgayDiemDanh
        {
            get
            {
                return m_NgayDiemDanh;
            }
            set
            {
                m_NgayDiemDanh = value;
            }
        }
        public bool GioiTinh
        {
            get
            {
                return m_GioiTinh;
            }
            set
            {
                m_GioiTinh = value;
            }
        }
        public string MonHoc
        {
            get
            {
                return m_MonHoc;
            }
            set
            {
                m_MonHoc = value;
            }
        }
        public SinhVien()
        {
            m_HoVaTen = " ";
            m_MaSoSinhVien = " ";
            m_Lop = " ";
            m_GioiTinh = true;
            m_NgayDiemDanh = DateTime.Now;
            m_MonHoc = string.Empty;
        }
        public SinhVien(string ten, string ma, string lop, DateTime ngay, bool gioi,string mon)
        {
            HoVaTen = ten;
            MaSoSinhVien = ma;
            Lop = lop;
            NgayDiemDanh = ngay;
            GioiTinh = gioi;
            MonHoc = mon;
        }
    }
}
